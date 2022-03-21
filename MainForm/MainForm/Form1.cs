using bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            Help=5,
            Start_Page=6
        }

        public enum Star_Marks : int
        {
            NoMark=0,
            Mark1=1,
            Mark2=2,
            Mark3=3,
            Mark4=4,
            Mark5=5
        }
            //ПРОВЕРЬ СООТВЕТСТВИЕ ВСЕХ КНОПОК
        public int whatClicked = (int)Star_Marks.NoMark;

        public int whatButtonClicked = -1;

        public string ImageFileNameOpacity = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\opacity_star.png";

        public string ImageFileNameFull = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\full_star.png";

        public Instruments Instruments;

        List<TableLayoutPanel> myList ;

        public MainForm()
        {
            InitializeComponent();
            
            ControllerForBD.Сonnect("Server = localhost; Port = 5432;UserId = postgres; Password =01dr10kv; Database = MyDatabase; ");//Подключение БД

            formChanges(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 50);

            languageChanges();

            LangCB.SelectedIndex = 0;//Начальный язык - русский

            markDif.SelectedIndex = 0;//Начальная оценка сложности  - 1

            tabContr.SelectedIndex = (int)Buttons.Start_Page;//Стартовая страница
            
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Обработка нажатия кнопок меню
        private void myRecB_Click(object sender, EventArgs e)//Раздел "Мои рецепты"
        {
            checkButtonsColors((int)Buttons.My_Rec);
            tabContr.SelectedIndex = (int)Buttons.My_Rec;
            whatButtonClicked=(int)Buttons.My_Rec;
            ControllerForBD.StartSelectAllMyRecipes();
            Thread thread = new Thread(showAllMyRecipes);
            thread.Start();
        
        }

        private void favB_Click(object sender, EventArgs e)//Раздел "Избранное"
        {
            checkButtonsColors((int)Buttons.Fav_Rec);
            tabContr.SelectedIndex = (int)Buttons.Fav_Rec;
            whatButtonClicked = (int)Buttons.Fav_Rec;
        }

        private void generalB_Click(object sender, EventArgs e)//Раздел "Общие рецепты"
        {
            checkButtonsColors((int)Buttons.General_Rec);
            tabContr.SelectedIndex = (int)Buttons.General_Rec;
            whatButtonClicked = (int)Buttons.General_Rec;
        }

        private void addRecB_Click(object sender, EventArgs e)//Раздел "Добавление рецепта"
        {
            checkButtonsColors((int)Buttons.Add_Rec);
            tabContr.SelectedIndex = (int)Buttons.Add_Rec;
            whatButtonClicked = (int)Buttons.Add_Rec;
        }
        
        private void settingsB_Click(object sender, EventArgs e)//Раздел "Настройки"
        {
            checkButtonsColors((int)Buttons.Settings);
            tabContr.SelectedIndex = (int)Buttons.Settings;
            whatButtonClicked = (int)Buttons.Settings;
        }

        private void helpB_Click(object sender, EventArgs e)//Раздел "Помощь"
        {
            checkButtonsColors((int)Buttons.Help);
            tabContr.SelectedIndex = (int)Buttons.Help;
            whatButtonClicked = (int)Buttons.Help;
        }

        //Обработка событий с оценкой рецепта
        //ДОДЕЛАТЬ ЛОГИКУ С БД!
        // МБ ЧТО-ТО С НОМЕРАМИ ТИПА ЕСЛИ 4, ТО ПЕРЕД ЭТИМ ЕЩЕ 1,2,3,4??

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            allStarsOpacityNull();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//Star1
        {
            whatClicked = (int)Star_Marks.Mark1;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (whatClicked == (int)Star_Marks.NoMark)
            {
                pictureBox1.Image = Image.FromFile(ImageFileNameFull);
                pictureBox2.Image = Image.FromFile(ImageFileNameFull);
                pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
            }
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)//Star2
        {
            whatClicked = (int)Star_Marks.Mark2;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameFull);
            pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (whatClicked == (int)Star_Marks.NoMark)
            {
                pictureBox1.Image = Image.FromFile(ImageFileNameFull);
                pictureBox2.Image = Image.FromFile(ImageFileNameFull);
                pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)//Star3
        {
            whatClicked = (int)Star_Marks.Mark3;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameFull);
            pictureBox3.Image = Image.FromFile(ImageFileNameFull);
            pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (whatClicked == (int)Star_Marks.NoMark)
            {
                pictureBox1.Image = Image.FromFile(ImageFileNameFull);
                pictureBox2.Image = Image.FromFile(ImageFileNameFull);
                pictureBox3.Image = Image.FromFile(ImageFileNameFull);
                pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
            }
        }
        
        private void pictureBox4_Click(object sender, EventArgs e)//Star4
        {
            whatClicked = (int)Star_Marks.Mark4;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameFull);
            pictureBox3.Image = Image.FromFile(ImageFileNameFull);
            pictureBox4.Image = Image.FromFile(ImageFileNameFull);
            pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (whatClicked == (int)Star_Marks.NoMark)
            {
                pictureBox1.Image = Image.FromFile(ImageFileNameFull);
                pictureBox2.Image = Image.FromFile(ImageFileNameFull);
                pictureBox3.Image = Image.FromFile(ImageFileNameFull);
                pictureBox4.Image = Image.FromFile(ImageFileNameFull);
                pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)//Star5
        {
            whatClicked = (int)Star_Marks.Mark5;
            pictureBox1.Image = Image.FromFile(ImageFileNameFull);
            pictureBox2.Image = Image.FromFile(ImageFileNameFull);
            pictureBox3.Image = Image.FromFile(ImageFileNameFull);
            pictureBox4.Image = Image.FromFile(ImageFileNameFull);
            pictureBox5.Image = Image.FromFile(ImageFileNameFull);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (whatClicked == (int)Star_Marks.NoMark)
            {
                pictureBox1.Image = Image.FromFile(ImageFileNameFull);
                pictureBox2.Image = Image.FromFile(ImageFileNameFull);
                pictureBox3.Image = Image.FromFile(ImageFileNameFull);
                pictureBox4.Image = Image.FromFile(ImageFileNameFull);
                pictureBox5.Image = Image.FromFile(ImageFileNameFull);
            }
        }

        private void RecReadyB_Click(object sender, EventArgs e)//Добавление рецепта в таблицу "Мои рецепты"
        {
            if (ControllerForBD.InsertToMyRecipes(rec_name.Text, CategoryCB.Text, Ingr_rec.Text, Instr_rec.Text, whatClicked.ToString(), markDif.Text, time_rec.Text, Instruments.convertImageIntoB(this.RecPhoto.Image))){
                MessageBox.Show("Рецепт успешно добавлен.","Добавление рецепта");//МБ СДЕЛАТЬ СВОЮ ФОРМУ
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

        private void LangCB_SelectedIndexChanged(object sender, EventArgs e)//Смена языка в приложении
        {
            if (LangCB.SelectedIndex == 0)//Русский
            {
                LanguagesForAddingRecipe.isRu = true;
            }
            if (LangCB.SelectedIndex == 1)//Английский
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

        private void RecPhoto_Click(object sender, EventArgs e)//Добавление фото в рецепт ДОДЕЛАТЬ!??!?!?
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            string filename = openFileDialog.FileName;

            RecPhoto.Image = Image.FromFile(filename);

            //RecPhoto.Size = new Size(Height/3, Height / 3);//ПОДУМАТЬ над фото(размер, основное) и т.п.
            
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)//Изменение размеров элементов при изменении размеров формы
        {
            if (Size.Width <= 1560||Size.Height<=746)
            {
                myRecB.Font = new Font(myRecB.Font.FontFamily, 14.5f, myRecB.Font.Style);
                favB.Font = new Font(myRecB.Font.FontFamily, 14.5f, myRecB.Font.Style);
                generalB.Font = new Font(myRecB.Font.FontFamily, 14.5f, myRecB.Font.Style);
                settingsB.Font = new Font(myRecB.Font.FontFamily, 14.5f, myRecB.Font.Style);
                helpB.Font = new Font(myRecB.Font.FontFamily, 14.5f, myRecB.Font.Style);
                addRecB.Font = new Font(myRecB.Font.FontFamily, 14.5f, myRecB.Font.Style);
                startLabel.Font= new Font(startLabel.Font.FontFamily, 40f, startLabel.Font.Style);
            }
            else
            {
                myRecB.Font = new Font(myRecB.Font.FontFamily, 16.5f, myRecB.Font.Style);
                favB.Font = new Font(myRecB.Font.FontFamily, 16.5f, myRecB.Font.Style);
                generalB.Font = new Font(myRecB.Font.FontFamily, 16.5f, myRecB.Font.Style);
                settingsB.Font = new Font(myRecB.Font.FontFamily, 16.5f, myRecB.Font.Style);
                helpB.Font = new Font(myRecB.Font.FontFamily, 16.5f, myRecB.Font.Style);
                addRecB.Font = new Font(myRecB.Font.FontFamily, 16.5f, myRecB.Font.Style);
                startLabel.Font = new Font(startLabel.Font.FontFamily, 46f, startLabel.Font.Style);
            }
            formChanges(Size.Width, Size.Height);
        }
        

        public void formChanges(int x,int y)//Изменения размеров элементов формы
        {
            Instruments = new Instruments(x,y);

            Width =x;
            
            Height =y;

            buttonPanel.Size = new Size(Instruments.buttonPanelWidth, Instruments.formHeight);

            buttonPanel.BackColor = Instruments.buttonPanelColor;

            tabContr.SetBounds(buttonPanel.Size.Width - 1, Instruments.heightOfLabels + 5 - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth + 3, Instruments.formHeight - lab.Height + Instruments.tabControlOffset);

            myRecB.FlatAppearance.MouseOverBackColor= favB.FlatAppearance.MouseOverBackColor = generalB.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 248, 248);

            addRecB.FlatAppearance.MouseOverBackColor= settingsB.FlatAppearance.MouseOverBackColor= helpB.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 248, 248);

            Instruments.SetRoundedShape(myRecB, Instruments.radius);

            Instruments.SetRoundedShape(favB, Instruments.radius);

            Instruments.SetRoundedShape(generalB, Instruments.radius);

            Instruments.SetRoundedShape(addRecB, Instruments.radius);

            Instruments.SetRoundedShape(settingsB, Instruments.radius);

            Instruments.SetRoundedShape(helpB, Instruments.radius);

            Instruments.SetRoundedShape(startBox, Instruments.radius);

            startBox.SetBounds(Instruments.intervalX + Instruments.intervalX / 6, Instruments.intervalHeight / 4, (int)((Instruments.formWidth - Instruments.buttonPanelWidth) / 1.5), 7 * Instruments.intervalHeight);

            startLabel.SetBounds(startBox.Bounds.X, startBox.Bounds.Y + startBox.Height, startBox.Width, Instruments.intervalHeight);

            lab.Size = new Size(Instruments.formWidth, Instruments.heightOfLabels+5);

            lab.BackColor = Instruments.myPurpleColor;
            
            closeB.SetBounds(Instruments.formWidth-Instruments.heightOfLabels-20, 0, Instruments.heightOfLabels +5, Instruments.heightOfLabels + 5);

            closeB.BackColor = Instruments.myPurpleColor;

            //AddRecPage changes 
            {
                //"Заголовок"
                {
                    AddLabel.SetBounds(addRecPage.Bounds.X, addRecPage.Bounds.Y - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.intervalHeight);
                }
                
                //"Название"
                {
                    Instruments.SetRoundedShape(TitlePanel, Instruments.radius);

                    TitlePanel.BackColor = Instruments.myPurpleColor;

                    TitlePanel.SetBounds(addRecPage.Bounds.X + Instruments.intervalX/4,AddLabel.Height+Instruments.intervalHeight/4, (int)(3.25*Instruments.intervalX),Instruments.intervalHeight);
                }

                //"Фото"
                {
                    Instruments.SetRoundedShape(PhotoPanel, Instruments.radius);

                    PhotoPanel.BackColor = Instruments.myPurpleColor;

                    PhotoPanel.SetBounds(TitlePanel.Bounds.X, TitlePanel.Bounds.Y+TitlePanel.Height+Instruments.intervalHeight/2, 2*Instruments.intervalX/*5 * Instruments.intervalHeight*/,  5*Instruments.intervalHeight);

                    RecPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                //"Оценка рецепта"
                {
                    Instruments.SetRoundedShape(RatingPanel, Instruments.radius);

                    RatingPanel.BackColor = Instruments.myPurpleColor;

                    RatingPanel.SetBounds(PhotoPanel.Bounds.X+PhotoPanel.Width+Instruments.intervalX/8, TitlePanel.Bounds.Y + TitlePanel.Height + Instruments.intervalHeight/2,Instruments.intervalX + Instruments.intervalX / 8, Instruments.intervalHeight);
                }
                
                //"Категория"
                {
                    Instruments.SetRoundedShape(CategoryPanel, Instruments.radius);

                    CategoryPanel.BackColor = Instruments.myPurpleColor;

                    CategoryPanel.SetBounds(RatingPanel.Bounds.X, RatingPanel.Bounds.Y+RatingPanel.Height+Instruments.intervalHeight/3,Instruments.intervalX + Instruments.intervalX / 8, Instruments.intervalHeight);
                }

                //"Время приготовления"
                {
                    Instruments.SetRoundedShape(TimePanel, Instruments.radius);

                    TimePanel.BackColor = Instruments.myPurpleColor;

                    TimePanel.SetBounds(RatingPanel.Bounds.X, CategoryPanel.Bounds.Y + CategoryPanel.Height + Instruments.intervalHeight / 3, Instruments.intervalX + Instruments.intervalX / 8, Instruments.intervalHeight);

                    //В МАСКУ ДОПИСЫВАТЬ ":00"!!!!!!!!!!!!!!!!!!!!
                }

                //"Сложность"
                {
                    Instruments.SetRoundedShape(DifficultyPanel, Instruments.radius);

                    DifficultyPanel.BackColor = Instruments.myPurpleColor;

                    DifficultyPanel.SetBounds(RatingPanel.Bounds.X, TimePanel.Bounds.Y+TimePanel.Height + Instruments.intervalHeight / 3, Instruments.intervalX + Instruments.intervalX / 8, Instruments.intervalHeight);
                }
                
                //"Ингредиенты"
                {
                    Instruments.SetRoundedShape(IngrPanel, Instruments.radius);

                    IngrPanel.BackColor = Instruments.myPurpleColor;

                    IngrPanel.SetBounds(TitlePanel.Bounds.X+TitlePanel.Width+Instruments.intervalX / 4, AddLabel.Height + Instruments.intervalHeight / 4, (int)(3.07 * Instruments.intervalX), 3 * Instruments.intervalHeight);
                }

                //"Инструкция"
                {
                    Instruments.SetRoundedShape(InstrPanel, Instruments.radius);

                    InstrPanel.BackColor = Instruments.myPurpleColor;

                    InstrPanel.SetBounds(IngrPanel.Bounds.X, IngrPanel.Bounds.Y + IngrPanel.Height + Instruments.intervalHeight/2, (int)(3.07 * Instruments.intervalX), 3 * Instruments.intervalHeight);
                }

                //Кнопка "добавить"
                {
                    RecReadyB.BackColor = Instruments.myPurpleColor;

                    RecReadyB.SetBounds((int)(2 * Instruments.intervalX), InstrPanel.Bounds.Y + InstrPanel.Height + Instruments.intervalHeight/2, Instruments.intervalX, (int)(0.75 * Instruments.intervalHeight));
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
                    Instruments.SetRoundedShape(LanguagePanel, Instruments.radius);

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
                //Панель для избранных рецептов
                {
                    fav_recipes_list.SetBounds(FavPage.Bounds.X + (int)(Instruments.intervalX), myL.Bounds.Y + myL.Height , 5 * Instruments.intervalX, Instruments.heightOfTabControlWithoutLabels - (int)(1.5 * Instruments.intervalHeight));
                }
            }

            //MyRecPage changes
            {
                //"Заголовок"
                {
                    myL.SetBounds(MyRecPage.Bounds.X, MyRecPage.Bounds.Y - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.intervalHeight);
                }

                //Панель для моих рецептов
                {
                    my_recipes_list.SetBounds(MyRecPage.Bounds.X + (int)( Instruments.intervalX), myL.Bounds.Y + myL.Height , 5 * Instruments.intervalX, Instruments.heightOfTabControlWithoutLabels-(int)(1.5*Instruments.intervalHeight)); 
                }
            }

            //GeneralPage changes
            {
                //"Заголовок"
                {
                    genL.SetBounds(MyRecPage.Bounds.X, MyRecPage.Bounds.Y - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.intervalHeight);
                }

                //Панель для общих рецептов
                {
                    general_recipes_list.SetBounds(FavPage.Bounds.X + (int)(Instruments.intervalX), myL.Bounds.Y + myL.Height , 5 * Instruments.intervalX, Instruments.heightOfTabControlWithoutLabels - (int)(1.5 * Instruments.intervalHeight));
                    //ControllerForBD.StartSelectAllMyRecipes();
                    //Thread thread = new Thread(showAllMyRecipes);
                    //thread.Start();
                }
            }
        }

        public void languageChanges()
        {
            categoryInit();

            startLabel.Text= LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.startRu : LanguagesForAddingRecipe.startEn;

            myRecB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.myRecRu : LanguagesForAddingRecipe.myRecEn;

            favB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.favRu : LanguagesForAddingRecipe.favEn;

            generalB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.generalRu : LanguagesForAddingRecipe.generalEn;

            addRecB.Text = LanguagesForAddingRecipe.isRu  ? LanguagesForAddingRecipe.addRu : LanguagesForAddingRecipe.addEn;

            settingsB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.setLRu : LanguagesForAddingRecipe.setLEn;

            helpB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.helpRu : LanguagesForAddingRecipe.helpEn;
            
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

        public void categoryInit()//Инициализация категорий в соответствии с языком
        {
            CategoryCB.Items.Clear();
            if (LanguagesForAddingRecipe.isRu)
            {
                foreach (var item in LanguagesForAddingRecipe.categoriesRu)
                {
                    CategoryCB.Items.Add(item);
                }
                CategoryCB.SelectedIndex = 0;
            }
            else
            {
                foreach (var item in LanguagesForAddingRecipe.categoriesEn)
                {
                    CategoryCB.Items.Add(item);
                }
                CategoryCB.SelectedIndex = 1;
            }
        }

        private void allStarsOpacityNull()
        {
            if (whatClicked ==(int)Star_Marks.NoMark)
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

            markDif.SelectedIndex = 0;

            time_rec.Clear();

            CategoryCB.SelectedIndex = 0;

            Ingr_rec.Clear();

            Instr_rec.Clear();

            whatClicked = (int)Star_Marks.NoMark;

            allStarsOpacityNull();

            //RecPhoto.Image = Image.FromFile();
        }

        //Функция для проверки активности кнопок
        public void checkButtonsColors(int num)//ОПТИМАЛЬНЕЕ??
        {
            if (num == (int)Buttons.My_Rec)
            {
                if (myRecB.BackColor != Instruments.myButtonHighlightColor) { myRecB.BackColor = Instruments.myButtonHighlightColor; }
            }
            else { myRecB.BackColor = Color.Transparent; }

            if (num == (int)Buttons.Fav_Rec)
            {
                if (favB.BackColor != Instruments.myButtonHighlightColor) { favB.BackColor = Instruments.myButtonHighlightColor; }
            }
            else { favB.BackColor = Color.Transparent; }

            if (num == (int)Buttons.General_Rec)
            {
                if (generalB.BackColor != Instruments.myButtonHighlightColor) { generalB.BackColor = Instruments.myButtonHighlightColor; }
            }
            else { generalB.BackColor = Color.Transparent; }

            if (num == (int)Buttons.Add_Rec)
            {
                if (addRecB.BackColor != Instruments.myButtonHighlightColor) { addRecB.BackColor = Instruments.myButtonHighlightColor; }
            }
            else { addRecB.BackColor = Color.Transparent; }

            if (num == (int)Buttons.Settings)
            {
                if (settingsB.BackColor != Instruments.myButtonHighlightColor) { settingsB.BackColor = Instruments.myButtonHighlightColor; }
            }
            else { settingsB.BackColor = Color.Transparent; }

            if (num == (int)(int)Buttons.Help)
            {
                if (helpB.BackColor != Instruments.myButtonHighlightColor) {helpB.BackColor = Instruments.myButtonHighlightColor; }
            }
            else { helpB.BackColor = Color.Transparent; }
        }
    
        public void showAllMyRecipes()//Вывести все "Мои рецепты"
        {
            bool isAll = false;

            int intervalX = my_recipes_list.Width / 20;

            int intervalY = Instruments.intervalY;

            int partsForPanel = 18;

            int i = 0;
            
            int counter = 0;
            
            myList = new List<TableLayoutPanel>();

            while (!isAll)
            {
                if (ControllerForBD.isStartMy)
                {
                    if (ControllerForBD.myRecipes.Count != 0)
                    {
                       Recipe r = ControllerForBD.myRecipes.ElementAt(0);

                       TableLayoutPanel t = new TableLayoutPanel();

                       counter++;

                       if (counter % 2 == 0)
                       {
                            t.SetBounds(intervalX+ (partsForPanel/2) * intervalX, i, (partsForPanel/2) * intervalX, 2*InstrPanel.Height);//НЕ ЗАБУДЬ КНОПКУ ИЗБРАННОЕ

                            i += t.Height + intervalY;
                        }
                       else
                       {
                            t.SetBounds(0, (i), (partsForPanel / 2) * intervalX, 2*InstrPanel.Height);//НЕ ЗАБУДЬ КНОПКУ ИЗБРАННОЕ
                       }
                      
                       Instruments.SetRoundedShape(t, 20);
                        //ИЗМЕНЕНИЕ РАЗМЕРОВ ПАНЕЛИ ПРИ ИЗМЕНЕНИИ РАЗМЕРОВ ФОРМЫ ДОДЕЛАТЬ
                       t.ColumnCount = 1;

                       t.RowCount = 10;
     
                       t.BackgroundImage = Image.FromFile("C: \\Users\\diana\\Desktop\\c.jpg");

                       t.RowStyles.Add(new RowStyle(SizeType.Percent, 60));

                       t.RowStyles.Add(new RowStyle(SizeType.Percent, 20));

                       Label l = new Label();

                       l.Text = r.Name;

                       l.Size = new Size(t.Width, t.Height / 6);//СДЕЛАТЬ ЗАВИСИМОСТЬ ОТ КОЛИЧЕСТВА СИМВОЛОВ?

                       l.AutoSize = false;

                       l.TextAlign = ContentAlignment.MiddleRight;

                       l.Font= new Font(CategoryCB.Font.FontFamily, 20f, CategoryCB.Font.Style);//MYRECB!

                       t.Controls.Add(l,1,9);
                        
                       t.SetRowSpan(t.Controls[0], 2);//С МЕРЦАНИЕМ РАЗОБРАТЬСЯ?ЧТО ДЕЛАТЬ С ОБНОВЛЕНИЕМ7!

                        Label time = new Label();
                       time.Font = l.Font;
                        time.Size = new Size(t.Width, t.Height / 10);//ТОЖЕ ЗАВИСИМОСТЬ 
                        time.TextAlign = ContentAlignment.MiddleRight;
                        time.AutoSize = false;
                        time.Text = "Время приготовления(ч:м:с):"+r.Time;

                        t.Controls.Add(time, 1, 10);

                        t.SetRowSpan(t.Controls[1], 2);//С МЕРЦАНИЕМ РАЗОБРАТЬСЯ?

                        myList.Add(t);
                       
                       my_recipes_list.BeginInvoke((MethodInvoker)(() => my_recipes_list.Controls.Add(t)));
                        
                       ControllerForBD.myRecipes.Remove(r);
                    }
                    if ((ControllerForBD.myRecipes.Count == 0) && (ControllerForBD.isDoneMy))
                    {
                        isAll = true;
                    }
                }
                else
                {
                    if ((ControllerForBD.isDoneMy))
                    {
                        isAll = true;
                        Label l = new Label();
                        l.Font = new Font(myL.Font.FontFamily, 14, myL.Font.Style);
                        l.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.haveSomeRecRu : LanguagesForAddingRecipe.haveSomeRecEn;
                        //my_recipes_list.BeginInvoke((MethodInvoker)(() => my_recipes_list.Controls.Add(l, 1, 0)));
                       
                        //my_recipes_list.Controls.Add(l, 1, 0);
                    }
                }

            }
        }

        public static void SetDoubleBuffered(Control c)//Устранение мерцания
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }
       
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


        //А КАК ЛУЧШЕ СДЕЛАТЬ СЧЕТ?g КООРДИНАТАМ!!!
        /*Обработчик для нескольких кнопок
         foreach (var item in this.Controls) //обходим все элементы формы
    {
        if (item is Button) // проверяем, что это кнопка
        {
            ((Button)item).Click += CommonBtn_Click; //приводим к типу и устанавливаем обработчик события  
        }
    } 
             */


    }
}