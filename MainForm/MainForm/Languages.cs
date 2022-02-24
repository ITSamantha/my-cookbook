using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    //Для двуязычия и логики программы
    public static class Languages
    {
        static public bool isRu = true;

        static public string[] categoriesRu = new string[] { "Закуски", "Салаты", "Первые блюда", "Вторые блюда", "Соусы", "Выпечка", "Напитки", "Десерты" };

        static public string[] categoriesEn = new string[] { "Snacks", "Salads", "First courses", "Main courses", "Sauces", "Pastries", "Drinks", "Desserts" };

        static public string titleRu = "Название";

        static public string titleEn = "Title";

        static public string photoRu = "Фото рецепта";

        static public string photoEn = "Recipe photo";

        static public string categoryRu = "Категория";

        static public string categoryEn = "Category";

        static public string timeRu = "Время приготовления";

        static public string timeEn = "Cooking time";
    }
}
