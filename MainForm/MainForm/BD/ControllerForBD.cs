using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bd
{
    internal static class ControllerForBD
    {


        private static string configConnection;

        public static List<Recipe> myRecipes;
        public static List<Recipe> inetRecipes;
        public static List<Recipe> starRecipes;
        public static List<Recipe> searchRecipes;
        public static Boolean isDone;
        public static Boolean isDoneMy;
        public static Boolean isDoneInet;
        public static Boolean isDoneStar;
        public static Boolean isDoneSearch;

        /*
        Метод подключения:
        параметром является строка с информацией о сервере,
        порте, пользователе, пароле и базой данных
        в данной программе конфигурация у всех одинакова, кроме пароля(у каждого свой)
        метод возвращает тру - если подключен, фолс - если нет.
        Пример конфига: "Server = localhost; Port = 5432;UserId = postgres; Password = пароль; Database = MyDatabase; "
        */
        public static bool Сonnect(string config_connect)
        {

            try
            {

                configConnection = config_connect;
                NpgsqlConnection test = new NpgsqlConnection(config_connect);
                test.Open();
                test.Close();
                return true;

                /*
                connection = new NpgsqlConnection(config_connect);
                connection.Open();
                Console.WriteLine("Connection is done!");
                isDone = false; 
                return true;
                */
            }
            catch (Exception e)
            {
                Console.WriteLine($"Connection error: \n {e} ");
                return false;
            }
        }
       
        /*
        Метод добавления данных для пользователя:
        параметрами являются следующие данные в виде строк: 
        название, категория, ингридиенты, инструкция, оценка, цена , время(особенность см. ниже)
        оценку и цену перед переводом в строку ОКРУГЛИТЬ ДО ДВУХ ЗНАКОВ ПОСЛЕ ЗАПЯТОЙ!!!
        Временно добавление не включает в себя картинки
        Использовать только после подключения!
        Время требуется передавать в виде строки в след. формате: "12:00:00"
        Возвращает тру - если добавил, фолс - если нет.
        */
        public static bool InsertToMyRecipes(string name, string category, string ingredients, string guide, string marklike, string markdif, string time)
        {
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(configConnection);
                connection.Open();
                string textCommand = "Insert into myrecipes(name, category, ingredients, guide, time, marklike, markdif )";
                textCommand += $"values ('{name}','{category}','{ingredients}','{guide}','{time}',{marklike},{markdif})";
                textCommand += " returning id;";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(textCommand, connection);
                int id = (int)npgsqlCommand.ExecuteScalar();
                // Еще добавление изображения нужно!!!
                Console.WriteLine($"Recipe is insert with id = {id}");
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Insert error: \n {e} ");
                return false;
            }
        }
        /*
           ImageConverter converter = new ImageConverter();
            Byte[] b = (byte[])converter.ConvertTo(this.pictureBox1.Image, typeof(byte[]));
               -------------------------------------------------
                Image img = (Image)converter.ConvertFrom(b);


         */
        public static bool InsertToInetRecipes(string name, string category, string ingredients, string guide, string marklike, string markdif, string time, byte[] image)
        {
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(configConnection);
                connection.Open();
                string textCommand = "Insert into inetrecipes(name, category, ingredients, guide, time, marklike, markdif )";
                textCommand += $"values ('{name}','{category}','{ingredients}','{guide}','{time}',{marklike},{markdif})";
                textCommand += " returning id;";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(textCommand, connection);

                int id = (int)npgsqlCommand.ExecuteScalar();
                npgsqlCommand = new NpgsqlCommand("Insert into images (id, pic) values(id,:dataparam)", connection);
                NpgsqlParameter parameter = new NpgsqlParameter("dataparam", NpgsqlTypes.NpgsqlDbType.Bytea);
                parameter.Value = image;
                npgsqlCommand.Parameters.Add(parameter);
                
                npgsqlCommand.ExecuteNonQuery();

                Console.WriteLine($"Recipe is insert with id = {id}");
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Insert error: \n {e} ");
                return false;
            }
        }



        /*
        Метод получения по айди:
        При выводе списков рецептов дается не вся информация о рецептах,
        поэтому при выборе пользователем определенного рецепта, через айди дается полная информация
        параметр TABLE - из какой таблицы беруться данные: избранные = starrecipes, пользовательские = myrecipes, с интернета = inetrecipes, все рецепты = recipes
         */


        public static Recipe SelectById(int id, string table)
        {
            try
            {

                // !!!!!!!!!!!!!!!!!!
                NpgsqlConnection connection = new NpgsqlConnection(configConnection);
                connection.Open();
                // !!!!1!!!!!!!!!!!!!!!!!!
                string textCommand;
                if (table.Equals("starrecipes"))
                {
                    textCommand = $"Select * from recipes where ((id = {id}) and (star = true))";
                }
                else
                {
                    textCommand = $"Select * from {table} where id = {id}";
                }
                Recipe r = null;

                var command = new NpgsqlCommand(textCommand, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    r = new Recipe(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetTimeSpan(8).ToString(), reader.GetString(3), reader.GetDouble(4).ToString(), reader.GetString(5), reader.GetDouble(6).ToString(), reader.GetBoolean(7));
                }
                reader.Close();
                connection.Close();
                return r;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error of select by id : \n" + e);
                return null;
            }
        }
        /*
        Метод получения рецептов из таблицы Мои рецепты:  StartSelectAllMyRecipes

        myRecipes - массив, в котором хранятся полученные из БД рецепты
        isDoneMy - булевая, которая сигнализирует, что вся инфа из БД загруженны
        метод запускает параллельный поток с загрузкой
        ПРИМЕР ИСПОЛЬЗОВАНИЯ (на примере просто вывод в консоль, !!! - то, что нужно изменить, остальное - оставить):


          ControllerForBD.StartSelectAllMyRecipes();
          bool isAll = false;
                while (!isAll)
                {
                    if (ControllerForBD.myRecipes != null)
                    {
                        if (ControllerForBD.myRecipes.Count != 0)
                        {
                            Recipe r = ControllerForBD.myRecipes.ElementAt(0);
                          !!!  Console.WriteLine(r.Name); !!!
                            ControllerForBD.myRecipes.Remove(r);
                        }
                        if ((ControllerForBD.myRecipes.Count == 0) && (ControllerForBD.isDoneMy))
                        {
                            isAll = true;
                        }
                    }
                    
                }


         */
        private static void SelectAllMyRecipes()
        {
            myRecipes = new List<Recipe>();
            
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(configConnection);
                connection.Open();
                Recipe r = null;
                string textCommand = "Select id, name ,  category, time, marklike, markdif, star from myrecipes";
                var command = new NpgsqlCommand(textCommand, connection);
                var reader = command.ExecuteReader();
                isDoneMy = false;
                while (reader.Read())
                {
                    r = new Recipe(reader.GetInt32(0), reader.GetString(2), null, reader.GetTimeSpan(3).ToString(), null, reader.GetDouble(4).ToString(), reader.GetString(1), reader.GetDouble(5).ToString(), reader.GetBoolean(6));
                    myRecipes.Add(r);
                }
                isDoneMy = true;
                reader.Close();
                connection.Close();

            }
            catch (Exception e)
            {

                Console.WriteLine("Error of select all from MyRecipes : \n" + e);
                myRecipes = null;
                isDoneMy = true;
            }
        }
        public static void StartSelectAllMyRecipes()
        {
            try
            {
                Thread th = new Thread(SelectAllMyRecipes);
                th.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /*
    Метод получения рецептов из таблицы рецепты с интернета:  StartSelectAllInetRecipes

    inetRecipes - массив, в котором хранятся полученные из БД рецепты
    isDoneInet - булевая, которая сигнализирует, что вся инфа из БД загруженны
    метод запускает параллельный поток с загрузкой
    ПРИМЕР ИСПОЛЬЗОВАНИЯ (на примере просто вывод в консоль, !!! - то, что нужно изменить, остальное - оставить):


      ControllerForBD.StartSelectAllMyRecipes();
      bool isAll = false;
            while (!isAll)
            {
                if (ControllerForBD.inetRecipes != null)
                {
                    if (ControllerForBD.inetRecipes.Count != 0)
                    {
                        Recipe r = ControllerForBD.inetRecipes.ElementAt(0);
                      !!!  Console.WriteLine(r.Name); !!!
                        ControllerForBD.inetRecipes.Remove(r);
                    }

                    if ((ControllerForBD.inetRecipes.Count == 0) && (ControllerForBD.isDoneInet))
                    {
                        isAll = true;
                    }
                }

            }


     */

        public static void StartSelectAllInetRecipes()
        {
            try
            {
                Thread th = new Thread(SelectAllInetRecipes);
                th.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void SelectAllInetRecipes()
        {
            inetRecipes = new List<Recipe>();


            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(configConnection);
                connection.Open();
                Recipe r = null;
                string textCommand = "Select id, name ,  category, time, marklike, markdif, star from inetrecipes";
                var command = new NpgsqlCommand(textCommand, connection);
                var reader = command.ExecuteReader();
                isDoneInet = false;
                while (reader.Read())
                {
                    r = new Recipe(reader.GetInt32(0), reader.GetString(2), null, reader.GetTimeSpan(8).ToString(), null, reader.GetDouble(4).ToString(), reader.GetString(1), reader.GetDouble(5).ToString(), reader.GetBoolean(6));
                    inetRecipes.Add(r);
                }
                isDoneInet = true;
                reader.Close();
                connection.Close();

            }
            catch (Exception e)
            {

                Console.WriteLine("Error of select all from inetRecipes : \n" + e);
                inetRecipes = null;
                isDoneInet = true;
            }
        }

        public static void deleteById(int id)
        {
            string textCommand = $"delete from recipes where(id = {id})";
            NpgsqlConnection connection = new NpgsqlConnection(configConnection);
            connection.Open();
            var command = new NpgsqlCommand(textCommand, connection);
            command.ExecuteNonQuery();
        }
















        public static void StartSelectSearchRecipes(object pair)
        {
            try
            {
                Thread th = new Thread(SelectForSearch);
                th.Start(pair);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void SelectForSearch(object pair)
        {
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(configConnection);
                connection.Open();
                searchRecipes = new List<Recipe>();

                string f, text = "";
                    string textCommand = "";
                PairSearch p = (PairSearch)pair;
                if (p is PairSearch)
                {
                   
                    isDoneSearch = false;
                   textCommand = "Select id, name  from recipes";
                    f = p.filter;
                    text = p.textSearch;
                    if (!f.Equals(""))
                    {
                        textCommand += "where";
                        textCommand += f;
                    }
                




            




                    var command = new NpgsqlCommand(textCommand, connection);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Recipe r;
                        double index;
                        int id;
                        string name;
                        name = reader.GetString(1);
                        id = reader.GetInt32(0);
                        /*
                               ДЛЯ БОЛЕЕ ТОЧНЫХ РЕЗУЛЬТАТОВ - СДЕЛАТЬ СОРТИРОВКУ = МЕДЛЕНЕЕ, НО ТОЧНЕЕ (НУЖНО БУДЕТ СОЗДАТЬ СПИСОК ПАР: ID , INDEX)
                               Если результаты достаточно точны будут, сделать многопоток
                         */
                        if (text.Equals(""))
                        {
                            r = SelectById(id, "recipes");
                            searchRecipes.Add(r);
                        }
                        else
                        {
                            if (Search.indexEquals(text, name) >= 49) // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                            {
                                r = SelectById(id, "recipes");
                                searchRecipes.Add(r);

                            }
                        }

                    }
                    isDoneSearch = true;
                    reader.Close();
                    connection.Close();
                }
                else
                {
                    isDoneSearch = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                searchRecipes = null;

            }



        }

        /*
          Метод изменения поля Избранное в Рецепте:
            Параметры: id - айди рецепта
                        star - булевая
         */

        public static void setStar(int id, bool star)
        {
            string textCommand = $"update recipes set star= {star} where(id = {id})";
            NpgsqlConnection connection = new NpgsqlConnection(configConnection);
            connection.Open();
            var command = new NpgsqlCommand(textCommand, connection);
            command.ExecuteNonQuery();


        }

        public static void loadAllDate( Recipe r)
        {

            NpgsqlConnection connection = new NpgsqlConnection(configConnection);
            connection.Open();
            string textCommand = "";
            textCommand = $"Select ingredients, guide  from recipes where id = {r.Id}";
            var command = new NpgsqlCommand(textCommand, connection);
            var reader = command.ExecuteReader();
         
            while (reader.Read())
            {
                r.Guide = reader.GetString(1);
                r.Ingredients = reader.GetString(0);
            }
            
            reader.Close();
            connection.Close();
        }
    }
}
