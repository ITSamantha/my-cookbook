using bd;
using System;
using System.IO;
using System.Text;
using System.Threading;
using AngleSharp;

namespace MainForm
{
    //Класс парсера
    public class Parser
    {
        private FileStream fs;
        private StreamWriter sw;
        private StreamReader sr;
        private string nameFile = "FileParserCheck.txt";
        private bool check = true;
        //Массив ссылок на рецепты, которые будем считывать (для считывания ссылок парсер не делал, поскольку занимает много памяти и c# не предназначен для
        //считывания ссылок на ресурсы)
        private string[] massive = new string[] { "https://www.povarenok.ru/recipes/show/44035/", "https://www.povarenok.ru/recipes/show/58465/", "https://www.povarenok.ru/recipes/show/89272/",
            "https://www.povarenok.ru/recipes/show/89272/", "https://www.povarenok.ru/recipes/show/51369/", "https://www.povarenok.ru/recipes/show/14885/","https://www.povarenok.ru/recipes/show/29822/",
            "https://www.povarenok.ru/recipes/show/13083/","https://www.povarenok.ru/recipes/show/5659/","https://www.povarenok.ru/recipes/show/22982/",
            "https://www.povarenok.ru/recipes/show/54138/","https://www.povarenok.ru/recipes/show/16995/","https://www.povarenok.ru/recipes/show/25691/","https://www.povarenok.ru/recipes/show/18778/",
            "https://www.povarenok.ru/recipes/show/61149/","https://www.povarenok.ru/recipes/show/59980/","https://www.povarenok.ru/recipes/show/60698/","https://www.povarenok.ru/recipes/show/52338/",
            "https://www.povarenok.ru/recipes/show/54138/","https://www.povarenok.ru/recipes/show/46837/","https://www.povarenok.ru/recipes/show/89841/","https://www.povarenok.ru/recipes/show/113360/",
            "https://www.povarenok.ru/recipes/show/28523/","https://www.povarenok.ru/recipes/show/139496/","https://www.povarenok.ru/recipes/show/33727/","https://www.povarenok.ru/recipes/show/134413/",
            "https://www.povarenok.ru/recipes/show/34756/", "https://www.povarenok.ru/recipes/show/81717/","https://www.povarenok.ru/recipes/show/21994/","https://www.povarenok.ru/recipes/show/86900/",
            "https://www.povarenok.ru/recipes/show/13764/", "https://www.povarenok.ru/recipes/show/34105/","https://www.povarenok.ru/recipes/show/59147/","https://www.povarenok.ru/recipes/show/90763/",
            "https://www.povarenok.ru/recipes/show/59296/", "https://www.povarenok.ru/recipes/show/23962/","https://www.povarenok.ru/recipes/show/23856/","https://www.povarenok.ru/recipes/show/64177/",
            "https://www.povarenok.ru/recipes/show/18534/","https://www.povarenok.ru/recipes/show/59743/","https://www.povarenok.ru/recipes/show/43683/","https://www.povarenok.ru/recipes/show/46800/",
            "https://www.povarenok.ru/recipes/show/48392/", "https://www.povarenok.ru/recipes/show/52345/","https://www.povarenok.ru/recipes/show/58459/","https://www.povarenok.ru/recipes/show/25758/",
            "https://www.povarenok.ru/recipes/show/51051/","https://www.povarenok.ru/recipes/show/101045/","https://www.povarenok.ru/recipes/show/54309/","https://www.povarenok.ru/recipes/show/57690/",
            "https://www.povarenok.ru/recipes/show/90014/","https://www.povarenok.ru/recipes/show/29943/","https://www.povarenok.ru/recipes/show/57726/","https://www.povarenok.ru/recipes/show/48210/",
            "https://www.povarenok.ru/recipes/show/76443/","https://www.povarenok.ru/recipes/show/47416/"
        };
        //Метод для парсинга ресурсов
        public async void parse()
        {
            try
            {
                if (!File.Exists(nameFile))
                {
                    fs = File.Create(nameFile);
                    fs.Close();
                    sw = new StreamWriter(nameFile);
                    sw.WriteLine("True");
                    sw.Close();
                }
                else
                {
                    sr = new StreamReader("testfor.txt");
                    string info = sr.ReadLine();
                    if (info.Equals("True"))
                        check = false;
                    sr.Close();
                }

            }
            catch (Exception ex) { }
            if (check)
            {
                for (int index = 0; index < massive.Length; index++)
                {
                    var config = Configuration.Default.WithDefaultLoader();
                    using (var context = BrowsingContext.New(config))
                    using (var doc = await context.OpenAsync(massive[index]))
                    {
                        var _recipe = doc.GetElementsByClassName("content-md")[0].GetElementsByClassName("item-bl item-about");
                        string name = _recipe[0].QuerySelector("h1").TextContent.Trim();
                        string category = _recipe[0].GetElementsByClassName("article-breadcrumbs")[0].QuerySelector("span").TextContent.Trim();
                        if (category.Equals("Бульоны и супы"))
                            category = "Первые блюда";
                        if (category.Equals("Горячие блюда"))
                            category = "Вторые блюда";
                        var massiveIngridients = _recipe[0].GetElementsByClassName("ingredients-bl")[0].QuerySelectorAll("li");
                        string ingridients = "";
                        foreach (var g in massiveIngridients)
                            ingridients += g.TextContent.Trim().Replace("\n", string.Empty).Replace("  ", string.Empty) + ';';
                        var massiveGuid = _recipe[0].GetElementsByClassName("cooking-bl");
                        string guid = "";
                        for (int i = 0; i < massive2.Length; i++)
                        {
                            var g2 = massive2[i].QuerySelector("p");
                            guid += g2.TextContent.Trim().Replace("\n", string.Empty);

                        }
                        Random random = new Random();
                        int star = random.Next(1, 5);
                        int timeStar = random.Next(1, 5);
                        string time = "";
                        int hour = random.Next(0, 4);
                        int minute = random.Next(0, 59);
                        int second = random.Next(0, 59);
                    }
                }
            }
}
