using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            //Получение информации о разрешении экрана пользователя
            Width = (int)System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            //ИЗМЕНЕНИЕ ФОРМЫ-ИЗМЕНЕНИЕ РАЗМЕРОВ ДОДЕЛАЙ!
            Height = (int)System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            buttonPanel.Size = new Size((int)(Width / 10), Height);//Размер панели кнопок

            lab.BackColor = Color.FromArgb(126, 124, 232);//Размер и цвет лэйбла

            lab.Size = new Size(Width, Height / 16);

            tabContr.SetBounds(buttonPanel.Size.Width - 5, Height / 16 - 30, (int)((Width) - (Width / 10)), Height - Height / 16);//TabControl размер

            BD.ControllerForBD.Сonnect("Server = localhost; Port = 5432;UserId = postgres; Password = 01dr10kv; Database = MyDatabase; ");

        }//СДЕЛАТЬ НЕ КЛИКАБЕЛЬНЫМИ СТРАНИЧНЫЕ ТАБЫ
        
        //ДОБАВИТЬ ТАБ ДЛЯ РЕЗУЛЬТАТА ПОИСКА?

        private void addRecB_Click(object sender, EventArgs e)
        {
            checkButtonsColors(0);
        }

        private void myRecB_Click(object sender, EventArgs e)
        {
            checkButtonsColors(1);
        }

        private void favB_Click(object sender, EventArgs e)
        {
            checkButtonsColors(2);
        }

        private void recommendB_Click(object sender, EventArgs e)
        {
            checkButtonsColors(3);
        }

        private void settingsB_Click(object sender, EventArgs e)
        {
            checkButtonsColors(4);
        }

        private void helpB_Click(object sender, EventArgs e)
        {
            checkButtonsColors(5);
        }

        //Функция для проверки активности кнопок
        public void checkButtonsColors(int num)//Оптимальнее??
        {
            if(addRecB.BackColor == Color.Transparent && num == 0)
            {
                addRecB.BackColor = Color.LightGray;
            }
            else{addRecB.BackColor = Color.Transparent;}

            if (myRecB.BackColor == Color.Transparent && num == 1)
            {
                myRecB.BackColor = Color.LightGray;
            }
            else{ myRecB.BackColor = Color.Transparent;}

            if (favB.BackColor == Color.Transparent && num ==2)
            {
                favB.BackColor = Color.LightGray;
            }
            else{favB.BackColor = Color.Transparent;}

            if (favB.BackColor == Color.Transparent && num == 3)
            {
                recommendB.BackColor = Color.LightGray;
            }
            else{recommendB.BackColor = Color.Transparent;}

            if (settingsB.BackColor == Color.Transparent && num == 4)
            {
                settingsB.BackColor = Color.LightGray;
            }
            else{settingsB.BackColor = Color.Transparent;}

            if (helpB.BackColor == Color.Transparent && num == 5)
            {
                helpB.BackColor = Color.LightGray;
            }
            else{helpB.BackColor = Color.Transparent;}   
        }
    }
}
