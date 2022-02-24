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
            tabContr.SelectedIndex = (int)Buttons.My_Rec;
        }

        private void favB_Click(object sender, EventArgs e)
        {
            checkButtonsColors((int)Buttons.Fav_Rec);
            tabContr.SelectedIndex = (int)Buttons.Fav_Rec;
        }

        private void generalB_Click(object sender, EventArgs e)
        {
            checkButtonsColors((int)Buttons.General_Rec);
            tabContr.SelectedIndex = (int)Buttons.General_Rec;
        }

        private void addRecB_Click(object sender, EventArgs e)
        {
            checkButtonsColors((int)Buttons.Add_Rec);
            tabContr.SelectedIndex = (int)Buttons.Add_Rec;
        }
        
        private void settingsB_Click(object sender, EventArgs e)
        {
            checkButtonsColors((int)Buttons.Settings);
            tabContr.SelectedIndex = (int)Buttons.Settings;
        }

        private void helpB_Click(object sender, EventArgs e)
        {
            checkButtonsColors((int)Buttons.Help);
            tabContr.SelectedIndex = (int)Buttons.Help;
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
                int pieces = 9;

                float eps = 6.65f;

                //"Заголовок"
                {
                    AddLabel.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.addRu : LanguagesForAddingRecipe.addEn;

                    AddLabel.SetBounds(addRecPage.Bounds.X, addRecPage.Bounds.Y - 30, (int)((Width) - (Width / 10)), Height / 16);
                }
                
                //Lavender

                //"Название"
                {
                    TitlePanel.BackColor = Color.FromArgb(126, 124, 232);

                    TitlePanel.SetBounds(addRecPage.Bounds.X + Instruments.intervalX, addRecPage.Bounds.Y + Instruments.intervalY/2, (int)( (Width / 2.5)), Height / 12);

                    TitleL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.titleRu : LanguagesForAddingRecipe.titleEn;
                }

                //"Фото"
                {
                    PhotoPanel.BackColor = Color.FromArgb(126, 124, 232);

                    PhotoPanel.SetBounds(TitlePanel.Bounds.X, TitlePanel.Bounds.Y + Instruments.intervalY, (int)(Height / 2.5), (int)(Height / 2.5));

                    PhotoLab.Text= LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.photoRu : LanguagesForAddingRecipe.photoEn;

                    //RecPhoto.Size = new Size(256, 256);//ПОДУМАТЬ над фото(размер, основное) и т.п.

                    //RecPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                //"Категория"
                {
                    CategoryPanel.BackColor = Color.FromArgb(126, 124, 232);

                    CategoryPanel.SetBounds(TitlePanel.Bounds.X + (int)(4*Instruments.intervalX), TitlePanel.Bounds.Y + Instruments.intervalY, (int)(Width/eps), Height / pieces);

                    CategoryL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.categoryRu : LanguagesForAddingRecipe.categoryEn;
                }

                //"Время приготовления"
                {
                    TimePanel.BackColor = Color.FromArgb(126, 124, 232);

                    TimePanel.SetBounds(TitlePanel.Bounds.X + (int)(4 * Instruments.intervalX), addRecPage.Bounds.Y+CategoryPanel.Bounds.Y + Instruments.intervalY, (int)(Width / eps), Height / pieces);
                    
                    TimeL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.timeRu : LanguagesForAddingRecipe.timeEn;    
                }

                //"Сложность"
                {
                    DifficultyPanel.BackColor = Color.FromArgb(126, 124, 232);

                    DifficultyPanel.SetBounds(TimePanel.Bounds.X, addRecPage.Bounds.Y + TimePanel.Bounds.Y + Instruments.intervalY, (int)(Width / eps), Height / pieces);

                    DiffL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.diffRu : LanguagesForAddingRecipe.diffEn;
                }
                
                //"Оценка рецепта"
                {
                    RatingPanel.BackColor = Color.FromArgb(126, 124, 232);

                    RatingPanel.SetBounds(PhotoPanel.Bounds.X, DifficultyPanel.Bounds.Y + (int)(1.2*Instruments.intervalY), (int)(Width / 6), Height / pieces);

                    RateLable.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.rateRu : LanguagesForAddingRecipe.rateEn;
                }

                //"Ингредиенты"
                {
                    IngrPanel.BackColor = Color.FromArgb(126, 124, 232);

                    IngrPanel.SetBounds(TitlePanel.Bounds.X+7*Instruments.intervalX, TitlePanel.Bounds.Y, (int)(Height / 1.7), (int)(Height /4 ));

                    IngredL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.ingRu : LanguagesForAddingRecipe.ingEn;
                }

                //"Инструкция"
                {
                    InstrPanel.BackColor = Color.FromArgb(126, 124, 232);

                    InstrPanel.SetBounds(IngrPanel.Bounds.X , TitlePanel.Bounds.Y+2*Instruments.intervalX+35, (int)(Height / 1.7), (int)(Height / 4));

                    InstrL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.guideRu : LanguagesForAddingRecipe.guideEn;
                }

                

            }
        }

        public void categoryInit()
        {
            if (LanguagesForAddingRecipe.isRu)
            {
                foreach (var item in LanguagesForAddingRecipe.categoriesRu)//Инициализация категорий
                {
                    CategoryCB.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in LanguagesForAddingRecipe.categoriesEn)//Инициализация категорий
                {
                    CategoryCB.Items.Add(item);
                }
            }
           
        }
    }
}
