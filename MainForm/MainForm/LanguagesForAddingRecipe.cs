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

        //Page "AddRec"
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

        static public string addBRu = "Добавить";

        static public string addBEn = "Add";

        static public string cancelRu = "Очистить";

        static public string cancelEn = "Clean";

        //Page "Settings"
        static public string setLRu = "Настройки";

        static public string setLEn = "Settings";

        static public string changeLRu = "Смена языка";

        static public string changeLEn = "Changing language";

        static public string RuRu = "Русский";

        static public string RuEn = "Russian";

        static public string EnRu = "Английский";

        static public string EnEn = "English";

        //Page "General Rec"
        static public string generalRu = "Общие рецепты";

        static public string generalEn = "General recipes";

        //Page "Favourite Rec"
        static public string favRu = "Избранные рецепты";

        static public string favEn = "Favourite recipes";

        //Page "My Rec"
        static public string myRecRu = "Мои рецепты";

        static public string myRecEn = "My recipes";

        //Page "Help"
        static public string helpRu = "Помощь";

        static public string helpEn = "Help";


    }
}
