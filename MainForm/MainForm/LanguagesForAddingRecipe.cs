using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    //Для двуязычия и логики программы
    public static class LanguagesForAddingRecipe
    {
        static public bool isRu = true;

        static public string[] categoriesRu = new string[] { "Закуски", "Салаты", "Первые блюда", "Вторые блюда", "Соусы", "Выпечка", "Напитки", "Десерты" };

        static public string[] categoriesEn = new string[] { "Snacks", "Salads", "First courses", "Main courses", "Sauces", "Pastries", "Drinks", "Desserts" };

        static public string addRu = "Добавление рецепта";

        static public string addEn = "Adding a recipe";

        static public string titleRu = "Название ";

        static public string titleEn = "Title";

        static public string photoRu = "Фото блюда";

        static public string photoEn = "Dish photo";

        static public string categoryRu = "Категория";

        static public string categoryEn = "Category";

        static public string timeRu = "Время приготовления";

        static public string timeEn = "Cooking time";

        static public string rateRu = "Оценка рецепта";

        static public string rateEn = "Prescription evaluation";

        static public string diffRu = "Оценка сложности рецепта(1-10)";//По-другому?

        static public string diffEn = "Recipe Difficulty Score(1-10)";

        static public string ingRu = "Ингредиенты";

        static public string ingEn = "Ingredients";

        static public string guideRu = "Инструкция";

        static public string guideEn = "Instruction";
    }
}
