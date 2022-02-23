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
        public enum Buttons: int//Перечисление номера кнопок
        {
            My_Rec=0,
            Fav_Rec=1,
            General_Rec=2,
            Add_Rec=3,
            Settings=4,
            Help=5
        }

        
        //static public int CountOfButtons = 6;//Количество кнопок
        
        public MainForm()
        {
            InitializeComponent();

            formChanges();
            
            //Подключение БД
            BD.ControllerForBD.Сonnect("Server = localhost; Port = 5432;UserId = postgres; Password = 01dr10kv; Database = MyDatabase; ");

            categoryInit();
            
        }//СДЕЛАТЬ НЕ КЛИКАБЕЛЬНЫМИ СТРАНИЧНЫЕ ТАБЫ

        //ДОБАВИТЬ ТАБ ДЛЯ РЕЗУЛЬТАТА ПОИСКА?
        //ПРИ ЗАКРЫТИИ ФОРМЫ ЗАКРЫТИЕ DB
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)//Отключение БД
        {
            BD.ControllerForBD.Disconnect();
        }

        private void myRecB_Click(object sender, EventArgs e)
        {
            checkButtonsColors((int)Buttons.My_Rec);
        }

        private void favB_Click(object sender, EventArgs e)
        {
            checkButtonsColors((int)Buttons.Fav_Rec);
        }

        private void generalB_Click(object sender, EventArgs e)
        {
            checkButtonsColors((int)Buttons.General_Rec);
        }

        private void addRecB_Click(object sender, EventArgs e)
        {
            checkButtonsColors((int)Buttons.Add_Rec);
            tabContr.SelectedIndex = (int)Buttons.Add_Rec;
        }
        
        private void settingsB_Click(object sender, EventArgs e)
        {
            checkButtonsColors((int)Buttons.Settings);
        }

        private void helpB_Click(object sender, EventArgs e)
        {
            checkButtonsColors((int)Buttons.Help);
        }

        //Функция для проверки активности кнопок
        public void checkButtonsColors(int num)//ОПТИМАЛЬНЕЕ??
        {
            if (num == (int)Buttons.My_Rec)
            {
                if (myRecB.BackColor != Color.LightGray) { myRecB.BackColor = Color.LightGray; }
            }
            else { myRecB.BackColor = Color.Transparent; }

            if (num == (int)Buttons.Fav_Rec)
            {
                if (favB.BackColor != Color.LightGray) { favB.BackColor = Color.LightGray; }
            }
            else { favB.BackColor = Color.Transparent; }

            if (num == (int)Buttons.General_Rec)
            {
                if (generalB.BackColor != Color.LightGray) { generalB.BackColor = Color.LightGray; }
            }
            else { generalB.BackColor = Color.Transparent; }

            if (num == (int)Buttons.Add_Rec)
            {
                if (addRecB.BackColor != Color.LightGray) { addRecB.BackColor = Color.LightGray; }
            }
            else { addRecB.BackColor = Color.Transparent; }

            if (num == (int)Buttons.Settings)
            {
                if (settingsB.BackColor != Color.LightGray) { settingsB.BackColor = Color.LightGray; }
            }
            else { settingsB.BackColor = Color.Transparent; }

            if (num == (int)(int)Buttons.Help)
            {
                if (helpB.BackColor != Color.LightGray) { helpB.BackColor = Color.LightGray; }
            }
            else { helpB.BackColor = Color.Transparent; }
        }

        public void formChanges()
        {
            //Получение информации о разрешении экрана пользователя
            Width = (int)System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            //ИЗМЕНЕНИЕ ФОРМЫ-ИЗМЕНЕНИЕ РАЗМЕРОВ ДОДЕЛАЙ!
            Height = (int)System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            buttonPanel.Size = new Size((int)(Width / 10), Height);//Размер панели кнопок

            lab.BackColor = Color.FromArgb(126, 124, 232);//Размер и цвет лэйбла

            lab.Size = new Size(Width, Height / 16);

            tabContr.SetBounds(buttonPanel.Size.Width - 5, Height / 16 - 30, (int)((Width) - (Width / 10)), Height - Height / 16);//TabControl размер

            //AddRecPage changes 
            {
                AddLabel.SetBounds(addRecPage.Bounds.X, addRecPage.Bounds.Y-30, (int)((Width) - (Width / 10)), Height / 16);

                rec_name.SetBounds(addRecPage.Bounds.X, addRecPage.Bounds.Y + helpThings.intervalY, (int)((Width) - (Width / 2)), Height / 16);

                CategoryCB.SetBounds(addRecPage.Bounds.X, addRecPage.Bounds.Y +  2*helpThings.intervalY, (int)((Width) - (Width / 2)), Height / 16);


            }
        }

        public void categoryInit()//ДОБАВИТЬ ПАРАМЕТР ЯЗЫК!
        {
            if (foodInfoForInterface.isRu)
            {
                foreach (var item in foodInfoForInterface.categoriesRu)//Инициализация категорий
                {
                    CategoryCB.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in foodInfoForInterface.categoriesEn)//Инициализация категорий
                {
                    CategoryCB.Items.Add(item);
                }
            }
           
        }
    }
}
