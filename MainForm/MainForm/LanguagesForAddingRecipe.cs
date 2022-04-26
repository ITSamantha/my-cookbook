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
        static public string[] categoriesRu = new string[] { "Другое", "Закуски", "Салаты", "Первые блюда", "Вторые блюда", "Соусы", "Выпечка", "Напитки", "Десерты" };

        static public string[] categoriesEn = new string[] { "Other", "Snacks", "Salads", "First courses", "Main courses", "Sauces", "Pastries", "Drinks", "Desserts" };
        
        static public string RuRu = "Русский";

        static public string EnEn = "English";


        static public string haveSomeRecRu = "В этом разделе нет рецептов.";

        static public string haveSomeRecEn = "There are no recipes in this section.";

    }
}