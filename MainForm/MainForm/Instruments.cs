using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Instruments   
    {
        public Instruments(int x, int y)
        {
            formWidth = x;

            formHeight = y;

            heightOfElements = formHeight / piecesOfScreenForElements;

            heightOfLabels = formHeight / piecesOfScreenForLabel;

            intervalX = (formWidth - buttonPanelWidth) / 8;
            
            heightOfTabControlWithoutLabels = formHeight - 2* heightOfLabels;

            buttonPanelWidth = (int)(formWidth / 10);
            
            intervalHeight = heightOfTabControlWithoutLabels / 10;

            intervalY = intervalHeight / 4;//??

        }

        public int formWidth;

        public int formHeight;

        public int heightOfTabControlWithoutLabels;
        
        public int intervalX;

        public int intervalY;

        public int intervalHeight;
        //Получение информации о разрешении экрана пользователя
        
        public  int buttonPanelWidth;

        public  Color myPurpleColor = Color.FromArgb(126, 124, 232);

        public  int piecesOfScreenForLabel = 16;

        public  int piecesOfScreenForElements = 12;

        public int heightOfLabels;

        public int heightOfElements;

        public  int tabControlOffset = 30;

        public float eps = 6.65f;
        
    }
}
