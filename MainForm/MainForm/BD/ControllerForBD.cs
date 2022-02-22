using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace MainForm.BD
{
    internal static class ControllerForBD
    {
        static NpgsqlConnection connection;

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
                connection = new NpgsqlConnection(config_connect);
                connection.Open();
                Console.WriteLine("Connection is done!");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Connection error: \n {e} ");
                return false;
            }
        }
        public static bool Disconnect()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Disconnection is done!");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Disconnection error: \n {e} ");
                return false;
            }
        }
        /*
        Метод добавления данных для пользователя:
        параметрами являются следующие данные в виде строк: 
        название, категория, ингридиенты, инструкция, оценка, цена
        оценку и цену перед переводом в строку ОКРУГЛИТЬ ДО ДВУХ ЗНАКОВ ПОСЛЕ ЗАПЯТОЙ!!!
        Временно добавление не включает в себя картинки
        Использовать только после подключения!
        Возвращает тру - если добавил, фолс - если нет.
        */
        public static bool InsertToMyRecipes(string name, string category, string ingredients, string guide, string marklike, string markdif, string time)
        {
            try
            {
                string textCommand = "Insert into myrecipes(name, category, ingredients, guide, time, marklike, markDifficult )";
                textCommand += $"values ('{name}','{category}','{ingredients}','{guide}','{time}',{marklike},{markdif})";
                textCommand += " returning id;";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(textCommand, connection);
                int id = (int)npgsqlCommand.ExecuteScalar();
                // Еще добавление изображения нужно!!!
                Console.WriteLine($"Recipe is insert with id = {id}");

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Insert error: \n {e} ");
                return false;
            }
        }
        public static bool InsertToInetRecipes(string name, string category, string ingredients, string guide, string marklike, string markdif, string time)
        {
            try
            {
                string textCommand = "Insert into inetrecipes(name, category, ingredients, guide, time, marklike, markdif )";
                textCommand += $"values ('{name}','{category}','{ingredients}','{guide}','{time}',{marklike},{markdif})";
                textCommand += " returning id;";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(textCommand, connection);
                int id = (int)npgsqlCommand.ExecuteScalar();
                // Еще добавление изображения нужно!!!
                Console.WriteLine($"Recipe is insert with id = {id}");

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Insert error: \n {e} ");
                return false;
            }
        }

        public static Recipe SelectById(int id, string table)
        {
            try
            {
                Recipe r = null;
                string textCommand = $"Select * from {table} where id = {id}";
                var command = new NpgsqlCommand(textCommand, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    r = new Recipe(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDouble(5).ToString(), reader.GetString(6), reader.GetDouble(7).ToString(), reader.GetBoolean(8));
                }
                reader.Close();

                return r;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error of select by id : \n" + e);
                return null;
            }
        }

    }
}
