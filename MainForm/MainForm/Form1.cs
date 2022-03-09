using bd;
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

        public enum Star_Marks : int
        {
            Mark1=1,
            Mark2=2,
            Mark3=3,
            Mark4=4,
            Mark5=5
        }

        public bool isClicked1 = false;

        public bool isClicked2 = false;

        public bool isClicked3 = false;

        public bool isClicked4 = false;

        public bool isClicked5 = false; 
        //НЕ ЗАБУДЬ ПРИ ПРЕЗЕНТАЦИИ ПРОЕКТА ПОМЕНЯТЬ!
        public string ImageFileNameOpacity = "C:\\Users\\diana\\source\\repos\\My-cookbook\\images\\opacity_star.png";

        public string ImageFileNameFull = "C:\\Users\\diana\\source\\repos\\My-cookbook\\images\\full_star.png";

        public MainForm()
        {
            InitializeComponent();

            formChanges();

            languageChanges();
            
            //Подключение БД
            ControllerForBD.Сonnect("Server = localhost; Port = 5432;UserId = postgres; Password = 01dr10kv; Database = MyDatabase; ");

            categoryInit();
            
        }//СДЕЛАТЬ НЕ КЛИКАБЕЛЬНЫМИ СТРАНИЧНЫЕ ТАБЫ

        //ДОБАВИТЬ ТАБ ДЛЯ РЕЗУЛЬТАТА ПОИСКА?
        //ПРИ ЗАКРЫТИИ ФОРМЫ ЗАКРЫТИЕ DB
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)//Отключение БД
        {
            ControllerForBD.Disconnect();
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
        
        //Обработка событий с оценкой рецепта
        //ДОДЕЛАТЬ ЛОГИКУ С БД!
        // МБ ЧТО-ТО С НОМЕРАМИ ТИПА ЕСЛИ 4, ТО ПЕРЕД ЭТИМ ЕЩЕ 1,2,3,4??
        private void pictureBox1_Click(object sender, EventArgs e)//Star1
        {
            isClicked1 = true;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isClicked1 && !isClicked2 && !isClicked3 && !isClicked4 && !isClicked5)
            {
                pictureBox1.Image = Image.FromFile(ImageFileNameFull);
                pictureBox2.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            allStarsOpacityNull();
        }

        private void pictureBox2_Click(object sender, EventArgs e)//Star2
        {
            isClicked2 = true;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameFull);
            pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isClicked1 && !isClicked2 && !isClicked3 && !isClicked4 && !isClicked5)
            {
                pictureBox1.Image = Image.FromFile(ImageFileNameFull);
                pictureBox2.Image = Image.FromFile(ImageFileNameFull);
                pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
            }
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            allStarsOpacityNull();
        }

        private void pictureBox3_Click(object sender, EventArgs e)//Star3
        {
            isClicked3 = true;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameFull);
            pictureBox3.Image = Image.FromFile(ImageFileNameFull);
            pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isClicked1 && !isClicked2 && !isClicked3 && !isClicked4 && !isClicked5)
            {
                pictureBox1.Image = Image.FromFile(ImageFileNameFull);
                pictureBox2.Image = Image.FromFile(ImageFileNameFull);
                pictureBox3.Image = Image.FromFile(ImageFileNameFull);
                pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
            }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            allStarsOpacityNull();
        }

        private void pictureBox4_Click(object sender, EventArgs e)//Star4
        {
            isClicked4 = true;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameFull);
            pictureBox3.Image = Image.FromFile(ImageFileNameFull);
            pictureBox4.Image = Image.FromFile(ImageFileNameFull);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isClicked1 && !isClicked2 && !isClicked3 && !isClicked4 && !isClicked5)
            {
                pictureBox1.Image = Image.FromFile(ImageFileNameFull);
                pictureBox2.Image = Image.FromFile(ImageFileNameFull);
                pictureBox3.Image = Image.FromFile(ImageFileNameFull);
                pictureBox4.Image = Image.FromFile(ImageFileNameFull);
                pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
            }
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            allStarsOpacityNull();
        }

        private void pictureBox5_Click(object sender, EventArgs e)//Star5
        {
            isClicked5 = true;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameFull);
            pictureBox3.Image = Image.FromFile(ImageFileNameFull);
            pictureBox4.Image = Image.FromFile(ImageFileNameFull);
            pictureBox5.Image = Image.FromFile(ImageFileNameFull);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isClicked1 && !isClicked2 && !isClicked3 && !isClicked4 && !isClicked5)
            {
                pictureBox1.Image = Image.FromFile(ImageFileNameFull);
                pictureBox2.Image = Image.FromFile(ImageFileNameFull);
                pictureBox3.Image = Image.FromFile(ImageFileNameFull);
                pictureBox4.Image = Image.FromFile(ImageFileNameFull);
                pictureBox5.Image = Image.FromFile(ImageFileNameFull);
            }
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            allStarsOpacityNull();
        }
        
        private void RecReadyB_Click(object sender, EventArgs e)//Добавление в БД рецепта
        {
            //Добавление в базу доделать!
        }

        private void LangCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LangCB.SelectedIndex == 0)//Ru
            {
                LanguagesForAddingRecipe.isRu = true;
            }
            if (LangCB.SelectedIndex == 1)//En
            {
                LanguagesForAddingRecipe.isRu = false;
            }
            languageChanges();
        }


        private void CancelB_Click(object sender, EventArgs e)//Очистка формы рецепта
        {
            cleanAddRecForm();//ДОБАВИТЬ в другие места закрытия!!!!!!!!!
        }

        //Функции

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
            
            LangCB.SelectedIndex = 0;//Начальный язык - русский

            markDif.SelectedIndex = 0;

            //AddRecPage changes 
            {
                int pieces = 12;

                float eps = 6.65f;

                //"Заголовок"
                {
                    AddLabel.SetBounds(addRecPage.Bounds.X, addRecPage.Bounds.Y - 30, (int)((Width) - (Width / 10)), Height / 16);
                }
                
                //"Название"
                {
                    TitlePanel.BackColor = Color.FromArgb(126, 124, 232);

                    TitlePanel.SetBounds(addRecPage.Bounds.X + Instruments.intervalX, addRecPage.Bounds.Y + Instruments.intervalY / 2, (int)(Height / 1.4), Height / pieces);
                }

                //"Оценка рецепта"
                {
                    RatingPanel.BackColor = Color.FromArgb(126, 124, 232);

                    RatingPanel.SetBounds(PhotoPanel.Width + 2 * Instruments.intervalX + 9, addRecPage.Bounds.Y + (int)(4 * Instruments.intervalY / 2.6), (int)(Width / eps), Height / pieces);
                }

                //"Фото"
                {
                    PhotoPanel.BackColor = Color.FromArgb(126, 124, 232);

                    PhotoPanel.SetBounds(TitlePanel.Bounds.X, TitlePanel.Bounds.Y + Instruments.intervalY, (int)(Height / 2.5), (int)(Height / 2.4));
                    
                }

                //"Категория"
                {
                    CategoryPanel.BackColor = Color.FromArgb(126, 124, 232);

                    CategoryPanel.SetBounds(TitlePanel.Bounds.X + (int)(4 * Instruments.intervalX), TitlePanel.Bounds.Y + 2 * Instruments.intervalY, (int)(Width / eps), Height / pieces);
                }

                //"Время приготовления"
                {
                    TimePanel.BackColor = Color.FromArgb(126, 124, 232);

                    TimePanel.SetBounds(TitlePanel.Bounds.X + (int)(4 * Instruments.intervalX), CategoryPanel.Bounds.Y + Instruments.intervalY, (int)(Width / eps), Height / pieces);
                }

                //"Сложность"
                {
                    DifficultyPanel.BackColor = Color.FromArgb(126, 124, 232);

                    DifficultyPanel.SetBounds(TimePanel.Bounds.X, TimePanel.Bounds.Y + Instruments.intervalY, (int)(Width / eps), Height / pieces);
                }
                
                //"Ингредиенты"
                {
                    IngrPanel.BackColor = Color.FromArgb(126, 124, 232);

                    IngrPanel.SetBounds(TitlePanel.Bounds.X + 7 * Instruments.intervalX, TitlePanel.Bounds.Y, (int)(Height / 1.7), (int)(Height / 4));
                }

                //"Инструкция"
                {
                    InstrPanel.BackColor = Color.FromArgb(126, 124, 232);

                    InstrPanel.SetBounds(IngrPanel.Bounds.X, TitlePanel.Bounds.Y + 2 * Instruments.intervalX + 35, (int)(Height / 1.7), (int)(Height / 3.76));
                }

                //Кнопка "добавить"
                {
                    RecReadyB.BackColor = Color.FromArgb(126, 124, 232);//ДОБАВИТЬ СМЕНУ ЯЗЫКА КНОПОК

                    RecReadyB.SetBounds(TimePanel.Bounds.X - Instruments.intervalX, addRecPage.Bounds.Y + TimePanel.Bounds.Y + (int)(2 * Instruments.intervalY), (int)(Width / eps), Height / 16);
                }

                //Кнопка "очистить"
                {
                    CancelB.BackColor = Color.FromArgb(126, 124, 232);

                    CancelB.SetBounds(TimePanel.Bounds.X + 2 * Instruments.intervalX, addRecPage.Bounds.Y + TimePanel.Bounds.Y + (int)(2 * Instruments.intervalY), (int)(Width / eps), Height / 16);
                }
            }

            //SettingsPage changes
            {
                //"Заголовок"
                {
                    SettingsL.SetBounds(settingsPage.Bounds.X, settingsPage.Bounds.Y - 30, (int)((Width) - (Width / 10)), Height / 16);
                }

                //"Смена языка"
                {
                    LanguagePanel.BackColor = Color.FromArgb(126, 124, 232);

                    LanguagePanel.SetBounds(settingsPage.Bounds.X + Instruments.intervalX, Instruments.intervalY, (int)(Height / 1.7), (int)(Height / 13));
                }

            }

            //HelpPage changes
            {
                //"Заголовок"
                {
                    helpL.SetBounds(helpPage.Bounds.X, helpPage.Bounds.Y - 30, (int)((Width) - (Width / 10)), Height / 16);
                }
            }

            //FavPage changes
            {
                //"Заголовок"
                {
                    favL.SetBounds(FavPage.Bounds.X, FavPage.Bounds.Y - 30, (int)((Width) - (Width / 10)), Height / 16);
                }
            }

            //MyRecPage changes
            {
                //"Заголовок"
                {
                    myL.SetBounds(MyRecPage.Bounds.X, MyRecPage.Bounds.Y - 30, (int)((Width) - (Width / 10)), Height / 16);
                }
            }

            //GeneralPage changes
            {
                //"Заголовок"
                {
                    genL.SetBounds(MyRecPage.Bounds.X, MyRecPage.Bounds.Y - 30, (int)((Width) - (Width / 10)), Height / 16);
                }
            }
        }

        public void languageChanges()
        {
            categoryInit();

            myRecB.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.myRecRu : LanguagesForAddingRecipe.myRecEn;

            generalB.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.generalRu : LanguagesForAddingRecipe.generalEn;

            settingsB.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.setLRu : LanguagesForAddingRecipe.setLEn;

            helpB.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.helpRu : LanguagesForAddingRecipe.helpEn;

            addRecB.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.addRu : LanguagesForAddingRecipe.addEn;

            favB.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.favRu : LanguagesForAddingRecipe.favEn;

            TitleL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.titleRu : LanguagesForAddingRecipe.titleEn;

            RateLable.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.rateRu : LanguagesForAddingRecipe.rateEn;
            
            PhotoLab.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.photoRu : LanguagesForAddingRecipe.photoEn;
            
            CategoryL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.categoryRu : LanguagesForAddingRecipe.categoryEn;

            IngredL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.ingRu : LanguagesForAddingRecipe.ingEn;
            
            TimeL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.timeRu : LanguagesForAddingRecipe.timeEn;

            genL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.generalRu : LanguagesForAddingRecipe.generalEn;

            myL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.myRecRu : LanguagesForAddingRecipe.myRecEn;
            
            favL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.favRu : LanguagesForAddingRecipe.favEn;

            helpL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.helpRu : LanguagesForAddingRecipe.helpEn;

            ChangeLLabel.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.changeLRu : LanguagesForAddingRecipe.changeLEn;
            
            SettingsL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.setLRu : LanguagesForAddingRecipe.setLEn;

            CancelB.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.cancelRu : LanguagesForAddingRecipe.cancelEn;

            RecReadyB.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.addBRu : LanguagesForAddingRecipe.addBEn;

            AddLabel.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.addRu : LanguagesForAddingRecipe.addEn;

            InstrL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.guideRu : LanguagesForAddingRecipe.guideEn;

            DiffL.Text = LanguagesForAddingRecipe.isRu == true ? LanguagesForAddingRecipe.diffRu : LanguagesForAddingRecipe.diffEn;

        }

        public void categoryInit()
        {
            CategoryCB.Items.Clear();
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

        private void allStarsOpacityNull()
        {
            if (!isClicked1 && !isClicked2 && !isClicked3 && !isClicked4 && !isClicked5)
            {
                pictureBox1.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox2.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
            }
        }

        private void cleanAddRecForm()
        {
            rec_name.Clear();
            //RecPhoto.Image= Image.FromFile(??);
            CategoryCB.Text = "";
            time_rec.Clear();
            markDif.Text = "";
            Ingr_rec.Clear();
            Instr_rec.Clear();
            pictureBox1.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox2.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
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

        private void RecPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)return;

            string filename = openFileDialog.FileName;

            RecPhoto.Image = Image.FromFile(filename);

            RecPhoto.Size = new Size(256, 256);//ПОДУМАТЬ над фото(размер, основное) и т.п.

            RecPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
//ПОПРАВЬ "ДОБАВЛЕНИЕ РЕЦЕПТА!