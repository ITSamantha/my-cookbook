using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public class Instruments   
    {
        public static ImageConverter converter = new ImageConverter();

        public int formWidth;

        public int formHeight;

        public int heightOfTabControlWithoutLabels;

        public int intervalX;

        public int intervalY;

        public int intervalHeight;
        //Получение информации о разрешении экрана пользователя

        public int buttonPanelWidth;

        public Color myPurpleColor = Color.FromArgb(126, 124, 232);

        public Color myButtonHighlightColor = Color.Gainsboro;

        public Color buttonPanelColor= Color.FromArgb(242, 242, 242);

        public int piecesOfScreenForLabel = 16;

        public int piecesOfScreenForElements = 12;

        public int heightOfLabels;

        public int heightOfElements;

        public int tabControlOffset = 30;

        public float eps = 6.65f;

        public int radius = 10;

        public Instruments(int x, int y)
        {
            formWidth = x;

            formHeight = y;

            heightOfElements = formHeight / piecesOfScreenForElements;

            heightOfLabels = formHeight / piecesOfScreenForLabel;

            intervalX = (formWidth - buttonPanelWidth) / 8;
            
            heightOfTabControlWithoutLabels = formHeight - 2* heightOfLabels;

            buttonPanelWidth = (int)(formWidth /9);
            
            intervalHeight = heightOfTabControlWithoutLabels / 10;

            intervalY = intervalHeight / 4;//??

            

        }

        public static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }

        //Конвертация Image в Byte[]
        public static Byte[] convertImageIntoB(Image image) => (byte[])converter.ConvertTo(image, typeof(byte[]));

        //Конвертация Byte[] в Image
        public static Image convertBIntoImage(Byte[] b) => (Image)converter.ConvertFrom(b);

    }
}
