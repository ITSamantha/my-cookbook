using bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{//ДОДЕЛАТЬ ВРЕМЯ ПРИГОТОВЛЕНИЯ В ФОРМАТЕ час : мин : сек
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

        public int whatClicked = 0;

        public string ImageFileNameOpacity = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\opacity_star.png";

        public string ImageFileNameFull = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\full_star.png";

        public Instruments Instruments;

        public MainForm()
        {
            InitializeComponent();


            ControllerForBD.Сonnect("Server = localhost; Port = 5432;UserId = postgres; Password = 01dr10kv; Database = MyDatabase; ");

            formChanges(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 50);
            //formChanges(1400,800);


            LangCB.SelectedIndex = 0;//Начальный язык - русский

            markDif.SelectedIndex = 0;//Начальная оценка сложности-1

            languageChanges();
            
            //Подключение БД
           
            
        }//СДЕЛАТЬ НЕ КЛИКАБЕЛЬНЫМИ СТРАНИЧНЫЕ ТАБЫ
        //ИЗМЕНЕНИЕ ШРИФТА ПРИ ИЗМЕНЕНИИ РАЗМЕРОВ ФОРМ
        //ДОБАВИТЬ ТАБ ДЛЯ РЕЗУЛЬТАТА ПОИСКА?
        
        private void myRecB_Click(object sender, EventArgs e)//Раздел "Мои рецепты"
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
            whatClicked = 1;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (whatClicked ==0)
            {

                pictureBox1.Image = Image.FromFile(ImageFileNameFull);
                pictureBox2.Image = Image.FromFile(ImageFileNameFull);
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
            whatClicked = 2;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameFull);
            pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (whatClicked ==0)
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
            whatClicked = 3;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameFull);
            pictureBox3.Image = Image.FromFile(ImageFileNameFull);
            pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (whatClicked ==0)
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
            whatClicked = 4;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameFull);
            pictureBox3.Image = Image.FromFile(ImageFileNameFull);
            pictureBox4.Image = Image.FromFile(ImageFileNameFull);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (whatClicked ==0)
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
            whatClicked = 5;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameFull);
            pictureBox3.Image = Image.FromFile(ImageFileNameFull);
            pictureBox4.Image = Image.FromFile(ImageFileNameFull);
            pictureBox5.Image = Image.FromFile(ImageFileNameFull);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (whatClicked ==0)
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
        
        private void RecReadyB_Click(object sender, EventArgs e)//Insert recipe into DB
        {
            ImageConverter converter = new ImageConverter();//Конвертация фото в bytea

            Byte[] b = (byte[])converter.ConvertTo(this.RecPhoto.Image, typeof(byte[]));

            Image img = (Image)converter.ConvertFrom(b);

            if (ControllerForBD.InsertToInetRecipes(rec_name.Text, CategoryCB.Text, Ingr_rec.Text, Instr_rec.Text, whatClicked.ToString(), markDif.Text, time_rec.Text, b)){
                MessageBox.Show("Рецепт успешно добавлен.");
            }
        }

        /*
        Метод добавления данных для пользователя:
        параметрами являются следующие данные в виде строк: 
        название, категория, ингридиенты, инструкция, оценка, цена , время(особенность см. ниже)
        оценку и цену перед переводом в строку ОКРУГЛИТЬ ДО ДВУХ ЗНАКОВ ПОСЛЕ ЗАПЯТОЙ!!!
        Временно добавление не включает в себя картинки
        Использовать только после подключения!
        Время требуется передавать в виде строки в след. формате: "12:00:00"
        Возвращает тру - если добавил, фолс - если нет.
        */

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

            markDif.SelectedIndex = 0;

            CategoryCB.SelectedIndex = 0;

        }

        private void RecPhoto_Click(object sender, EventArgs e)//Добавление фото в рецепт
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            string filename = openFileDialog.FileName;

            RecPhoto.Image = Image.FromFile(filename);

            //RecPhoto.Size = new Size(Height/3, Height / 3);//ПОДУМАТЬ над фото(размер, основное) и т.п.
            
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)//Изменение размеров формы
        {
           
            if (Size.Width <= 1560||Size.Height<=746)
            {
                myRecB.Font = new Font(myRecB.Font.FontFamily, 13, myRecB.Font.Style);
                favB.Font = new Font(myRecB.Font.FontFamily, 13, myRecB.Font.Style);
                generalB.Font = new Font(myRecB.Font.FontFamily, 13, myRecB.Font.Style);
                addRecB.Font = new Font(myRecB.Font.FontFamily, 13, myRecB.Font.Style);
                settingsB.Font = new Font(myRecB.Font.FontFamily, 13, myRecB.Font.Style);
                helpB.Font = new Font(myRecB.Font.FontFamily, 13, myRecB.Font.Style);
            }
            else
            {
                myRecB.Font = new Font(myRecB.Font.FontFamily, 15.5f, myRecB.Font.Style);
                favB.Font = new Font(myRecB.Font.FontFamily, 15.5f, myRecB.Font.Style);
                generalB.Font = new Font(myRecB.Font.FontFamily, 15.5f, myRecB.Font.Style);
                addRecB.Font = new Font(myRecB.Font.FontFamily, 15.5f, myRecB.Font.Style);
                settingsB.Font = new Font(myRecB.Font.FontFamily, 15.5f, myRecB.Font.Style);
                helpB.Font = new Font(myRecB.Font.FontFamily, 15.5f, myRecB.Font.Style);
            }
            formChanges(Size.Width, Size.Height);
        }

        //Функции

        public void formChanges(int x,int y)//ДОДЕЛАЙ ОТРИСОВКУ КАК СУММУ ЭЛЕМЕНТОВ !!!!!!!!!!!!!!!!!!!!!!!!!!
        {//ШРИФТЫ?!
            Instruments = new Instruments(x,y);

            Width =x;//ИЗМЕНЕНИЕ ФОРМЫ-ИЗМЕНЕНИЕ РАЗМЕРОВ ДОДЕЛАЙ!Про класс Instruments не забудь
            
            Height =y;

            buttonPanel.Size = new Size(Instruments.buttonPanelWidth, Instruments.formHeight);//Размер панели кнопок

            lab.BackColor = Instruments.myPurpleColor;

            lab.Size = new Size(Instruments.formWidth, Instruments.heightOfLabels);

            tabContr.SetBounds(buttonPanel.Size.Width, Instruments.heightOfLabels-Instruments.tabControlOffset ,Instruments.formWidth - Instruments.buttonPanelWidth,Instruments.formHeight - Instruments.heightOfLabels);//TabControl размер
            //МЕНЯТЬ ШРИФТЫ?!(РАЗМЕР)
            //AddRecPage changes 
            {
                //"Заголовок"
                {
                    AddLabel.SetBounds(addRecPage.Bounds.X, addRecPage.Bounds.Y - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.intervalHeight);
                }
                
                //"Название"
                {
                    TitlePanel.BackColor = Instruments.myPurpleColor;

                    TitlePanel.SetBounds(addRecPage.Bounds.X + Instruments.intervalX/4,AddLabel.Height+Instruments.intervalHeight/2, (int)(3.25*Instruments.intervalX),Instruments.intervalHeight);
                }

                //"Фото"
                {
                    PhotoPanel.BackColor = Instruments.myPurpleColor;

                    PhotoPanel.SetBounds(TitlePanel.Bounds.X, TitlePanel.Bounds.Y+TitlePanel.Height+Instruments.intervalHeight/2, 2*Instruments.intervalX/*5 * Instruments.intervalHeight*/,  5*Instruments.intervalHeight);

                    RecPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                //"Оценка рецепта"
                {
                    RatingPanel.BackColor = Instruments.myPurpleColor;

                    RatingPanel.SetBounds(PhotoPanel.Bounds.X+PhotoPanel.Width+Instruments.intervalX/8, TitlePanel.Bounds.Y + TitlePanel.Height + Instruments.intervalHeight/2,Instruments.intervalX + Instruments.intervalX / 8, Instruments.intervalHeight);
                }
                
                //"Категория"
                {
                    CategoryPanel.BackColor = Instruments.myPurpleColor;

                    CategoryPanel.SetBounds(RatingPanel.Bounds.X, RatingPanel.Bounds.Y+RatingPanel.Height+Instruments.intervalHeight/3,Instruments.intervalX + Instruments.intervalX / 8, Instruments.intervalHeight);
                }

                //"Время приготовления"
                {//ДОБАВИТЬ ПЛЕЙСХОЛДЕР
                    TimePanel.BackColor = Instruments.myPurpleColor;

                    TimePanel.SetBounds(RatingPanel.Bounds.X, CategoryPanel.Bounds.Y + CategoryPanel.Height + Instruments.intervalHeight / 3, Instruments.intervalX + Instruments.intervalX / 8, Instruments.intervalHeight);

                    //В МАСКУ ДОПИСЫВАТЬ ":00"!!!!!!!!!!!!!!!!!!!!
                }

                //"Сложность"
                {
                    DifficultyPanel.BackColor = Instruments.myPurpleColor;

                    DifficultyPanel.SetBounds(RatingPanel.Bounds.X, TimePanel.Bounds.Y+TimePanel.Height + Instruments.intervalHeight / 3, Instruments.intervalX + Instruments.intervalX / 8, Instruments.intervalHeight);
                }
                
                //"Ингредиенты"
                {
                    IngrPanel.BackColor = Instruments.myPurpleColor;

                    IngrPanel.SetBounds(TitlePanel.Bounds.X+TitlePanel.Width+Instruments.intervalX / 4, AddLabel.Height + Instruments.intervalHeight / 2, (int)(3.07 * Instruments.intervalX), 3 * Instruments.intervalHeight);
                }

                //"Инструкция"
                {
                    InstrPanel.BackColor = Instruments.myPurpleColor;

                    InstrPanel.SetBounds(IngrPanel.Bounds.X, IngrPanel.Bounds.Y + IngrPanel.Height + Instruments.intervalHeight/2, (int)(3.07 * Instruments.intervalX), 3 * Instruments.intervalHeight);
                }

                //Кнопка "добавить"
                {
                    RecReadyB.BackColor = Instruments.myPurpleColor;

                    RecReadyB.SetBounds((int)(2 * Instruments.intervalX), InstrPanel.Bounds.Y + InstrPanel.Height + Instruments.intervalHeight, Instruments.intervalX, (int)(0.75 * Instruments.intervalHeight));
                }

                //Кнопка "очистить"
                {
                    CancelB.BackColor = Instruments.myPurpleColor;

                    CancelB.SetBounds((int)(3.5*Instruments.intervalX), RecReadyB.Bounds.Y, Instruments.intervalX, (int)(0.75*Instruments.intervalHeight));
                }
            }

            //SettingsPage changes
            {
                //"Заголовок"
                {
                    SettingsL.SetBounds(settingsPage.Bounds.X, settingsPage.Bounds.Y -Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.intervalHeight);
                }

                //"Смена языка"
                {
                    LanguagePanel.BackColor = Instruments.myPurpleColor;

                    LanguagePanel.SetBounds(settingsPage.Bounds.X + Instruments.intervalX/2, SettingsL.Bounds.X+SettingsL.Height+Instruments.intervalY, 3*Instruments.intervalX, Instruments.intervalHeight);
                }

            }

            //HelpPage changes
            {
                //"Заголовок"
                {
                    helpL.SetBounds(helpPage.Bounds.X, helpPage.Bounds.Y - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.intervalHeight);
                }
            }

            //FavPage changes
            {
                //"Заголовок"
                {
                    favL.SetBounds(FavPage.Bounds.X, FavPage.Bounds.Y - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.intervalHeight);
                }
            }

            //MyRecPage changes
            {
                //"Заголовок"
                {
                    myL.SetBounds(MyRecPage.Bounds.X, MyRecPage.Bounds.Y - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.intervalHeight);
                }

                //Панель для рецептов
                {
                    my_recipes_list.SetBounds(MyRecPage.Bounds.X + (int)( Instruments.intervalX), myL.Bounds.Y + myL.Height + Instruments.intervalHeight / 4, 5 * Instruments.intervalX, Instruments.heightOfTabControlWithoutLabels-(int)(1.5*Instruments.intervalHeight));
                    showAllMyRecipes();
                }
            }

            //GeneralPage changes
            {
                //"Заголовок"
                {
                    genL.SetBounds(MyRecPage.Bounds.X, MyRecPage.Bounds.Y - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.intervalHeight);
                }
            }
        }

        public void languageChanges()
        {
            categoryInit();
            
            myRecB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.myRecRu : LanguagesForAddingRecipe.myRecEn;

            generalB.Text = LanguagesForAddingRecipe.isRu  ? LanguagesForAddingRecipe.generalRu : LanguagesForAddingRecipe.generalEn;

            settingsB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.setLRu : LanguagesForAddingRecipe.setLEn;

            helpB.Text = LanguagesForAddingRecipe.isRu  ? LanguagesForAddingRecipe.helpRu : LanguagesForAddingRecipe.helpEn;

            addRecB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.addRu : LanguagesForAddingRecipe.addEn;

            favB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.favRu : LanguagesForAddingRecipe.favEn;

            TitleL.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.titleRu : LanguagesForAddingRecipe.titleEn;

            RateLable.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.rateRu : LanguagesForAddingRecipe.rateEn;
            
            PhotoLab.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.photoRu : LanguagesForAddingRecipe.photoEn;
            
            CategoryL.Text = LanguagesForAddingRecipe.isRu  ? LanguagesForAddingRecipe.categoryRu : LanguagesForAddingRecipe.categoryEn;

            IngredL.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.ingRu : LanguagesForAddingRecipe.ingEn;
            
            TimeL.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.timeRu : LanguagesForAddingRecipe.timeEn;

            genL.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.generalRu : LanguagesForAddingRecipe.generalEn;

            myL.Text = LanguagesForAddingRecipe.isRu? LanguagesForAddingRecipe.myRecRu : LanguagesForAddingRecipe.myRecEn;
            
            favL.Text = LanguagesForAddingRecipe.isRu  ? LanguagesForAddingRecipe.favRu : LanguagesForAddingRecipe.favEn;

            helpL.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.helpRu : LanguagesForAddingRecipe.helpEn;

            ChangeLLabel.Text = LanguagesForAddingRecipe.isRu  ? LanguagesForAddingRecipe.changeLRu : LanguagesForAddingRecipe.changeLEn;
            
            SettingsL.Text = LanguagesForAddingRecipe.isRu? LanguagesForAddingRecipe.setLRu : LanguagesForAddingRecipe.setLEn;

            CancelB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.cancelRu : LanguagesForAddingRecipe.cancelEn;

            RecReadyB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.addBRu : LanguagesForAddingRecipe.addBEn;

            AddLabel.Text = LanguagesForAddingRecipe.isRu  ? LanguagesForAddingRecipe.addRu : LanguagesForAddingRecipe.addEn;

            InstrL.Text = LanguagesForAddingRecipe.isRu  ? LanguagesForAddingRecipe.guideRu : LanguagesForAddingRecipe.guideEn;

            DiffL.Text = LanguagesForAddingRecipe.isRu  ? LanguagesForAddingRecipe.diffRu : LanguagesForAddingRecipe.diffEn;

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
            CategoryCB.SelectedIndex = 0;
        }

        private void allStarsOpacityNull()
        {
            if (whatClicked ==0)
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
            markDif.SelectedIndex = 0;
            time_rec.Clear();
            CategoryCB.SelectedIndex = 0;
            Ingr_rec.Clear();
            Instr_rec.Clear();
            whatClicked = 0;
            allStarsOpacityNull();
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

        public void showAllMyRecipes()
        {
            //ControllerForBD.StartSelectAllMyRecipes();

            ControllerForBD.StartSelectAllMyRecipes();

            bool isAll = false;
            while (!isAll)
            {
                if (ControllerForBD.myRecipes != null)
                {
                    if (ControllerForBD.myRecipes.Count != 0)
                    {
                        Recipe r = ControllerForBD.myRecipes.ElementAt(0);
                        Console.WriteLine(r.Name);
                        ControllerForBD.myRecipes.Remove(r);
                    }
                    if ((ControllerForBD.myRecipes.Count == 0) && (ControllerForBD.isDoneMy))
                    {
                        isAll = true;
                    }
                }

            }
        }
    }
}