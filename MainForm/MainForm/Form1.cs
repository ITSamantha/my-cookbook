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
{
    //РЕШИТЬ ПРОБЛЕМУ С ОТРИСОВКОЙ РЕЦЕПТОВ, КОГДА ИХ МНОГО!!!!!!!!!!!!
    public partial class MainForm : Form
    {
        public enum Buttons : int//Номера кнопок
        {
            My_Rec = 0,
            Fav_Rec = 1,
            General_Rec = 2,
            Add_Rec = 3,
            Settings = 4,
            Help = 5,
            Start_Page = 6,
            SearchResultPage = 7
        }

        public enum Star_Marks : int//Оценки
        {
            NoMark = 0,
            Mark1 = 1,
            Mark2 = 2,
            Mark3 = 3,
            Mark4 = 4,
            Mark5 = 5
        }

        public int whatClicked = (int)Star_Marks.NoMark;//Какая оценка рецепта выбрана

        bool isPhoto = false;//Загружено ли фото для рецепта

        public int whatButtonClicked = -1;//Какой раздел выбран

        public string ImageFileNameOpacity = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\opacity_star.png";//Пустая звезда

        public string ImageFileNameFull = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\full_star.png";//Заполненная звезда

        public string HeartFileNameOpacity = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\opacity_heart.png";

        public string HeartFileNameFull = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\full_heart.png";
        
        public string ImageAddRec = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\add.png";//Добавление рецепта

        public string StandartPhotoImage = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\standart_photo.jpg";

        public Instruments Instruments;

        public Thread thread;

        Recipe main_recipe;//Для показа инф-ии о выбранном рецепте

        bool isCollapsed = true;//Переменная отрисовки панели

        bool isRecipe;

        int i = 0;//Считает интервалы для добавления рецептов

        int counter = 0;//Считает количество отображенных рецептов

        int partsForPanel = 18;

        Label l;

        public MainForm()
        {
            InitializeComponent();

            ControllerForBD.Сonnect("Server = localhost; Port = 5432;UserId = postgres; Password =01dr10kv; Database = MyDatabase; "); //Подключение БД

            formChanges(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 50);

            setColors();

            languageChanges();

            LangCB.SelectedIndex = 0;//Начальный язык - русский

            markDif.SelectedIndex = 0;//Начальная оценка сложности  - 1

            tabContr.SelectedIndex = (int)Buttons.Start_Page;//Стартовая страница

        }

        private void closeB_Click(object sender, EventArgs e)//Кнопка закрытия
        {
            Close();
        }

        //Обработка нажатия кнопок меню

        private void myRecB_Click(object sender, EventArgs e)//Раздел "Мои рецепты"
        {
            checkButtonsColors((int)Buttons.My_Rec);
            
            if (whatButtonClicked != (int)Buttons.My_Rec)
            {
                ControllerForBD.StartSelectAllMyRecipes();

                thread = new Thread(showAllMyRecipes);

                thread.Start();
            }

            whatButtonClicked = (int)Buttons.My_Rec;

            tabContr.SelectedIndex = (int)Buttons.My_Rec;
        }

        public void showAllMyRecipes()//Вывести все "Мои рецепты"
        {
            Action action = () => my_recipes_list.Controls.Clear();

            if (InvokeRequired) { Invoke(action); }

            else { my_recipes_list.Controls.Clear(); }

            i = counter = 0;

            bool isAll = false;

            isRecipe = false;

            my_recipes_list.Invoke((MethodInvoker)delegate {

                my_recipes_list.Enabled = false;
            });
           
            
            while (!isAll)
            {
                if (ControllerForBD.isStartMy)
                {
                    if (ControllerForBD.myRecipes.Count != 0)
                    {
                        isRecipe = true;

                        Recipe r = ControllerForBD.myRecipes.ElementAt(0);

                        var t = createTableForRecipes(r);

                        my_recipes_list.BeginInvoke((MethodInvoker)(() => my_recipes_list.Controls.Add(t)));

                        ControllerForBD.myRecipes.Remove(r);

                    }
                    if ((ControllerForBD.myRecipes.Count == 0) && (ControllerForBD.isDoneMy))
                    {
                        isAll = true;

                        
                        if (!isRecipe)
                        {
                            my_recipes_list.BeginInvoke((MethodInvoker)(() => my_recipes_list.Controls.Add(pbForNoRec())));

                            my_recipes_list.BeginInvoke((MethodInvoker)(() => my_recipes_list.Controls.Add(labelForNoRec())));
                        }
                    }
                }
                else
                {
                    if ((ControllerForBD.isDoneMy))
                    {
                        isAll = true;
                    }
                }
            }

            my_recipes_list.Invoke((MethodInvoker)delegate {

                my_recipes_list.Enabled = true;
            });

        }

        private void favB_Click(object sender, EventArgs e)//Раздел "Избранное"
        {
            checkButtonsColors((int)Buttons.Fav_Rec);

            tabContr.SelectedIndex = (int)Buttons.Fav_Rec;

            if (whatButtonClicked != (int)Buttons.Fav_Rec)
            {
                ControllerForBD.StartSelectAllStarRecipes();

                thread = new Thread(showAllFavRecipes);

                thread.Start();
            }

            whatButtonClicked = (int)Buttons.Fav_Rec;
        }

        public void showAllFavRecipes()//Вывести "Избранные"
        {
            Action action = () => fav_recipes_list.Controls.Clear();

            if (InvokeRequired) { Invoke(action); }

            else { fav_recipes_list.Controls.Clear(); }

            i = counter = 0;

            bool isAll = false;

            isRecipe = false;

            fav_recipes_list.Invoke((MethodInvoker)delegate {

                fav_recipes_list.Enabled = false;
            });

            while (!isAll)
            {
                if (ControllerForBD.isStartStar)
                {
                    if (ControllerForBD.starRecipes.Count != 0)
                    {
                        isRecipe = true;

                        Recipe r = ControllerForBD.starRecipes.ElementAt(0);

                        var t = createTableForRecipes(r);

                        fav_recipes_list.BeginInvoke((MethodInvoker)(() => fav_recipes_list.Controls.Add(t)));

                        ControllerForBD.starRecipes.Remove(r);

                    }
                    if ((ControllerForBD.starRecipes.Count == 0) && (ControllerForBD.isDoneStar))
                    {
                        isAll = true;

                        if (!isRecipe)
                        {
                            fav_recipes_list.BeginInvoke((MethodInvoker)(() => fav_recipes_list.Controls.Add(pbForNoRec())));

                            fav_recipes_list.BeginInvoke((MethodInvoker)(() => fav_recipes_list.Controls.Add(labelForNoRec())));
                        }
                    }
                }
                else
                {
                    if ((ControllerForBD.isDoneStar))
                    {
                        isAll = true;
                    }
                }
            }
            fav_recipes_list.Invoke((MethodInvoker)delegate {

                fav_recipes_list.Enabled = true;
            });
        }

        private void generalB_Click(object sender, EventArgs e)//Раздел "Общие рецепты"
        {
            checkButtonsColors((int)Buttons.General_Rec);

            tabContr.SelectedIndex = (int)Buttons.General_Rec;

            if (whatButtonClicked != (int)Buttons.General_Rec)
            {
                ControllerForBD.StartSelectAllInetRecipes();

                thread = new Thread(showAllInetRecipes);

                thread.Start();
            }

            whatButtonClicked = (int)Buttons.General_Rec;
        }

        public void showAllInetRecipes()//Вывести все "Общие рецепты"
        {
            Action action = () => general_recipes_list.Controls.Clear();

            if (InvokeRequired) { Invoke(action); }

            else { general_recipes_list.Controls.Clear(); }

            i = counter = 0;

            bool isAll = false;

            isRecipe = false;

            general_recipes_list.Invoke((MethodInvoker)delegate {

                general_recipes_list.Enabled = false;
            });

            while (!isAll)
            {
                if (ControllerForBD.isStartInet)
                {
                    if (ControllerForBD.inetRecipes.Count != 0)
                    {
                        isRecipe = true;

                        Recipe r = ControllerForBD.inetRecipes.ElementAt(0);

                        var t = createTableForRecipes(r);

                        general_recipes_list.BeginInvoke((MethodInvoker)(() => general_recipes_list.Controls.Add(t)));

                        ControllerForBD.inetRecipes.Remove(r);
                    }
                    if ((ControllerForBD.inetRecipes.Count == 0) && (ControllerForBD.isDoneInet))
                    {
                        isAll = true;

                        if (!isRecipe)
                        {
                            general_recipes_list.BeginInvoke((MethodInvoker)(() => general_recipes_list.Controls.Add(pbForNoRec())));

                            general_recipes_list.BeginInvoke((MethodInvoker)(() => general_recipes_list.Controls.Add(labelForNoRec())));
                        }
                    }
                }
                else
                {
                    if ((ControllerForBD.isDoneInet))
                    {
                        isAll = true;
                    }
                }
            }
            general_recipes_list.Invoke((MethodInvoker)delegate {
                general_recipes_list.Enabled = true;
            });
        }

        private void addRecB_Click(object sender, EventArgs e)//Раздел "Добавление рецепта"
        {
            isPhoto = false;

            cleanAddRecForm();

            if (!RecReadyB.Visible)
            {
                RecReadyB.Show();
            }

            if (!CancelB.Visible)
            {
                CancelB.Show();
            }

            if (updateRecB.Visible)
            {
                updateRecB.Hide();
            }

            if (deleteRecB.Visible)
            {
                deleteRecB.Hide();
            }

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
            checkRecForm();

            if (ControllerForBD.InsertToMyRecipes(rec_name.Text, CategoryCB.Text, Ingr_rec.Text, Instr_rec.Text, whatClicked.ToString(), markDif.Text, time_rec.Text, isPhoto ? Instruments.convertImageIntoB(this.RecPhoto.Image) : null))
            {
                MessageBox.Show("Рецепт успешно добавлен.", "Добавление рецепта", MessageBoxButtons.OK, MessageBoxIcon.Information);

               // cleanAddRecForm();
            }
            else
            {
                MessageBox.Show("Что-то пошло не так.", "Добавление рецепта");
            }
        }

        public void checkRecForm()
        {
            if (rec_name.Text == String.Empty)
            {
                MessageBox.Show(LanguagesForAddingRecipe.isRu ? "Вы не ввели название рецепта." : "You have not entered a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (Instr_rec.Text == String.Empty)
            {
                MessageBox.Show(LanguagesForAddingRecipe.isRu ? "Вы не ввели инструкцию к рецепту." : "You have not entered an instruction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (Ingr_rec.Text == String.Empty)
            {
                MessageBox.Show(LanguagesForAddingRecipe.isRu ? "Вы не ввели ингредиенты для рецепта." : "You have not entered ingredients.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            time_rec.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (String.IsNullOrEmpty(time_rec.Text) || String.IsNullOrWhiteSpace(time_rec.Text) || time_rec.Text.Length != 6)
            {
                MessageBox.Show(LanguagesForAddingRecipe.isRu ? "Вы не ввели время или ввели некорректно." : "You have not entered time or entered incorrectly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (int.Parse(time_rec.Text[2].ToString() + time_rec.Text[3].ToString()) >= 60 || int.Parse(time_rec.Text[4].ToString() + time_rec.Text[5].ToString()) >= 60 || int.Parse(time_rec.Text[0].ToString() + time_rec.Text[1].ToString()) >= 24)
            {
                MessageBox.Show(LanguagesForAddingRecipe.isRu ? "Вы ввели время некорректно." : "You have  entered time incorrectly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (whatClicked == 0)
            {
                MessageBox.Show(LanguagesForAddingRecipe.isRu ? "Оценка рецепта не задана." : "Recipe's rating is not defined.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

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

        public void languageChanges()//Смена языка в приложении
        {
            CategoryAndFilterInit();

            AddLabel.Text = LanguagesForAddingRecipe.isRu ? "Добавить рецепт" : "Add a recipe";
            
            startLabel.Text = LanguagesForAddingRecipe.isRu ? "Храните все рецепты в одном месте" : "Store all recipes in one place";

            myRecB.Text = LanguagesForAddingRecipe.isRu ? "Мои рецепты" : "My recipes";

            favB.Text = LanguagesForAddingRecipe.isRu ? "Избранные" : "Favourite";

            generalB.Text = LanguagesForAddingRecipe.isRu ? "Общие рецепты" : "General recipes";

            addRecB.Text = LanguagesForAddingRecipe.isRu ? "Добавить рецепт" : "Add a recipe";

            settingsB.Text = LanguagesForAddingRecipe.isRu ? "Настройки" : "Settings";

            helpB.Text = LanguagesForAddingRecipe.isRu ? "Помощь" : "Help";

            TitleL.Text = LanguagesForAddingRecipe.isRu ? "Название" : "Title";

            RateLable.Text = ratel.Text = LanguagesForAddingRecipe.isRu ? "Оценка рецепта" : "Prescription evaluation";

            PhotoLab.Text = LanguagesForAddingRecipe.isRu ? "Фото блюда" : "Dish photo";

            CategoryL.Text = catl.Text = LanguagesForAddingRecipe.isRu ? "Категория" : "Category";

            IngredL.Text = LanguagesForAddingRecipe.isRu ? "Ингредиенты" : "Ingredients";

            TimeL.Text = LanguagesForAddingRecipe.isRu ? "Время приготовления(ч:м:с)" : "Cooking time(h:m:s)";

            genL.Text = LanguagesForAddingRecipe.isRu ? "Общие рецепты" : "General recipes";

            myL.Text = LanguagesForAddingRecipe.isRu ? "Мои рецепты" : "My recipes";

            favL.Text = LanguagesForAddingRecipe.isRu ? "Избранные" : "Favourite";

            helpL.Text = LanguagesForAddingRecipe.isRu ? "Помощь" : "Help";

            ChangeLLabel.Text = LanguagesForAddingRecipe.isRu ? "Язык" : "Language";

            SettingsL.Text = LanguagesForAddingRecipe.isRu ? "Настройки" : "Settings";

            CancelB.Text = LanguagesForAddingRecipe.isRu ? "Очистить" : "Clean";

            RecReadyB.Text = LanguagesForAddingRecipe.isRu ? "Добавить" : "Add";

            searchB.Text = LanguagesForAddingRecipe.isRu ? "Поиск" : "Search";

            deleteRecB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.delBRu : LanguagesForAddingRecipe.delBEn;

            updateRecB.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.updBRu : LanguagesForAddingRecipe.updBEn;

            InstrL.Text = LanguagesForAddingRecipe.isRu ? "Инструкция" : "Instruction";

            DiffL.Text = difl.Text = LanguagesForAddingRecipe.isRu ? "Оценка сложности рецепта" : "Recipe Difficulty Score";

            searchL.Text = LanguagesForAddingRecipe.isRu ? "Результат поиска" : "Result of search";
        }

        private void CancelB_Click(object sender, EventArgs e)//Очистка формы рецепта
        {
            cleanAddRecForm();
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

            RecPhoto.Image = Image.FromFile(ImageAddRec);//SizeMode??????
        }

        private void allStarsOpacityNull()//Сделать все звёзды прозрачными
        {
            if (whatClicked == (int)Star_Marks.NoMark)
            {
                pictureBox1.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox2.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox3.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox4.Image = Image.FromFile(ImageFileNameOpacity);
                pictureBox5.Image = Image.FromFile(ImageFileNameOpacity);
            }
        }

        private void RecPhoto_Click(object sender, EventArgs e)//Добавление фото в рецепт
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)//Фото не выбрано
            {
                return;
            }

            RecPhoto.Image = Image.FromFile(openFileDialog.FileName);

            isPhoto = true;

        }

        private void MainForm_SizeChanged(object sender, EventArgs e)//Изменение размеров элементов при изменении размеров формы
        {
            if (Size.Width <= 1560 || Size.Height <= 746)
            {
                myRecB.Font = favB.Font = generalB.Font = settingsB.Font = helpB.Font = addRecB.Font = new Font(myRecB.Font.FontFamily, 14.5f, myRecB.Font.Style);

                startLabel.Font = new Font(startLabel.Font.FontFamily, 40f, startLabel.Font.Style);
            }
            else
            {
                myRecB.Font = favB.Font = generalB.Font = settingsB.Font = helpB.Font = addRecB.Font = new Font(myRecB.Font.FontFamily, 16.5f, myRecB.Font.Style);

                startLabel.Font = new Font(startLabel.Font.FontFamily, 46f, startLabel.Font.Style);
            }

            formChanges(Size.Width, Size.Height);
        }


        public void formChanges(int x, int y)//Изменения размеров элементов формы
        {
            Instruments = new Instruments(x, y);

            Width = x;

            Height = y;

            //ButtonPanel changes
            {
                buttonPanel.Size = new Size(Instruments.buttonPanelWidth, Instruments.formHeight);

                Instruments.SetRoundedShape(myRecB, Instruments.radius);

                Instruments.SetRoundedShape(favB, Instruments.radius);

                Instruments.SetRoundedShape(generalB, Instruments.radius);

                Instruments.SetRoundedShape(addRecB, Instruments.radius);

                Instruments.SetRoundedShape(settingsB, Instruments.radius);

                Instruments.SetRoundedShape(helpB, Instruments.radius);

                Instruments.SetRoundedShape(startBox, Instruments.radius);
            }

            //Начальная инициализация
            {
                lab.Size = new Size(Instruments.formWidth, Instruments.heightOfLabels + 5);

                tabContr.SetBounds(buttonPanel.Size.Width - 1, Instruments.heightOfLabels + 5 - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth + 3, Instruments.formHeight - lab.Height + Instruments.tabControlOffset);

                closeB.SetBounds(Instruments.formWidth - Instruments.heightOfLabels - 20, 0, Instruments.heightOfLabels + 5, Instruments.heightOfLabels + 5);
            }

            //StartPage changes
            {
                //"Фото"
                {
                    startBox.SetBounds(Instruments.intervalX + Instruments.intervalX / 6, Instruments.intervalHeight / 4, (int)((Instruments.formWidth - Instruments.buttonPanelWidth) / 1.5), 7 * Instruments.intervalHeight);
                }
                //"Надпись"
                {
                    startLabel.SetBounds(startBox.Bounds.X, startBox.Bounds.Y + startBox.Height, startBox.Width, Instruments.intervalHeight);
                }
            }

            //AddRecPage changes 
            {
                //"Заголовок"
                {
                    AddLabel.SetBounds(addRecPage.Bounds.X, addRecPage.Bounds.Y - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.intervalHeight);

                    searchL.SetBounds(addRecPage.Bounds.X, addRecPage.Bounds.Y - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.intervalHeight);
                }

                //"Название"
                {
                    Instruments.SetRoundedShape(TitlePanel, Instruments.radius);

                    TitlePanel.SetBounds(addRecPage.Bounds.X + Instruments.intervalX / 4, AddLabel.Height + Instruments.intervalHeight / 4, (int)(3.25 * Instruments.intervalX), Instruments.intervalHeight);
                }

                //"Фото"
                {
                    Instruments.SetRoundedShape(PhotoPanel, Instruments.radius);

                    PhotoPanel.SetBounds(TitlePanel.Bounds.X, TitlePanel.Bounds.Y + TitlePanel.Height + Instruments.intervalHeight / 2, 2 * Instruments.intervalX, 5 * Instruments.intervalHeight);
                }

                //"Оценка рецепта"
                {
                    Instruments.SetRoundedShape(RatingPanel, Instruments.radius);

                    RatingPanel.SetBounds(PhotoPanel.Bounds.X + PhotoPanel.Width + Instruments.intervalX / 8, TitlePanel.Bounds.Y + TitlePanel.Height + Instruments.intervalHeight / 2, Instruments.intervalX + Instruments.intervalX / 8, Instruments.intervalHeight);
                }

                //"Категория"
                {
                    Instruments.SetRoundedShape(CategoryPanel, Instruments.radius);

                    CategoryPanel.SetBounds(RatingPanel.Bounds.X, RatingPanel.Bounds.Y + RatingPanel.Height + Instruments.intervalHeight / 3, Instruments.intervalX + Instruments.intervalX / 8, Instruments.intervalHeight);
                }

                //"Время приготовления"
                {
                    Instruments.SetRoundedShape(TimePanel, Instruments.radius);

                    TimePanel.SetBounds(RatingPanel.Bounds.X, CategoryPanel.Bounds.Y + CategoryPanel.Height + Instruments.intervalHeight / 3, Instruments.intervalX + Instruments.intervalX / 8, Instruments.intervalHeight);
                }

                //"Сложность"
                {
                    Instruments.SetRoundedShape(DifficultyPanel, Instruments.radius);

                    DifficultyPanel.SetBounds(RatingPanel.Bounds.X, TimePanel.Bounds.Y + TimePanel.Height + Instruments.intervalHeight / 3, Instruments.intervalX + Instruments.intervalX / 8, Instruments.intervalHeight);
                }

                //"Ингредиенты"
                {
                    Instruments.SetRoundedShape(IngrPanel, Instruments.radius);

                    IngrPanel.SetBounds(TitlePanel.Bounds.X + TitlePanel.Width + Instruments.intervalX / 4, AddLabel.Height + Instruments.intervalHeight / 4, (int)(3.07 * Instruments.intervalX), 3 * Instruments.intervalHeight);
                }

                //"Инструкция"
                {
                    Instruments.SetRoundedShape(InstrPanel, Instruments.radius);

                    InstrPanel.SetBounds(IngrPanel.Bounds.X, IngrPanel.Bounds.Y + IngrPanel.Height + Instruments.intervalHeight / 2, (int)(3.07 * Instruments.intervalX), 3 * Instruments.intervalHeight);
                }

                //Кнопка "добавить"
                {
                    RecReadyB.SetBounds((int)(2 * Instruments.intervalX), InstrPanel.Bounds.Y + InstrPanel.Height + Instruments.intervalHeight / 2, Instruments.intervalX, (int)(0.75 * Instruments.intervalHeight));
                }

                //Кнопка "удалить"
                {
                    deleteRecB.SetBounds((int)(3.5 * Instruments.intervalX), RecReadyB.Bounds.Y, Instruments.intervalX, (int)(0.75 * Instruments.intervalHeight));
                }

                //Кнопка "редактировать"
                {
                    updateRecB.SetBounds((int)(2 * Instruments.intervalX), InstrPanel.Bounds.Y + InstrPanel.Height + Instruments.intervalHeight / 2, Instruments.intervalX, (int)(0.75 * Instruments.intervalHeight));
                }

                //Кнопка "очистить"
                {
                    CancelB.SetBounds((int)(3.5 * Instruments.intervalX), RecReadyB.Bounds.Y, Instruments.intervalX, (int)(0.75 * Instruments.intervalHeight));
                }
            }

            //SettingsPage changes
            {
                //"Заголовок"
                {
                    SettingsL.SetBounds(settingsPage.Bounds.X, settingsPage.Bounds.Y - Instruments.tabControlOffset, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.intervalHeight);
                }

                //"Смена языка"
                {
                    Instruments.SetRoundedShape(LanguagePanel, Instruments.radius);

                    LanguagePanel.SetBounds(settingsPage.Bounds.X + Instruments.intervalX / 2, SettingsL.Bounds.X + SettingsL.Height + Instruments.intervalY, 3 * Instruments.intervalX, Instruments.intervalHeight);
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
                    fav_recipes_list.SetBounds(MyRecPage.Bounds.X + Instruments.intervalX / 6, myL.Bounds.Y + myL.Height, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.heightOfTabControlWithoutLabels - (int)(1.5 * Instruments.intervalHeight));
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
                    my_recipes_list.SetBounds(MyRecPage.Bounds.X + Instruments.intervalX / 6, myL.Bounds.Y + myL.Height, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.heightOfTabControlWithoutLabels - (int)(1.5 * Instruments.intervalHeight));
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
                    general_recipes_list.SetBounds(MyRecPage.Bounds.X + Instruments.intervalX / 6, myL.Bounds.Y + myL.Height, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.heightOfTabControlWithoutLabels - (int)(1.5 * Instruments.intervalHeight));
                }
            }

            //SearchPage changes
            {
                //ТБ  "Поиск"
                {
                    searchTB.SetBounds(buttonPanel.Width + 760, 6, 400, 40);

                    Instruments.SetRoundedShape(searchTB, 10);
                }
                //Кнопка "Поиск"
                {
                    searchB.SetBounds(searchTB.Size.Width + searchTB.Bounds.X + 40, 6, 100, 40);
                }
                //Кнопка "Фильтр"
                {
                    FilterB.SetBounds(searchTB.Size.Width + searchTB.Bounds.X - 10, 6, 40, 40);

                    Instruments.SetRoundedShape(FilterB, 10);
                }
                //Панель для фильтра
                {
                    filterPanel.SetBounds(searchTB.Bounds.X + 70, 46, filterPanel.MinimumSize.Width, filterPanel.MinimumSize.Height);
                }
                //Панель для поиска
                {
                    search_list.SetBounds(MyRecPage.Bounds.X + Instruments.intervalX / 6, myL.Bounds.Y + myL.Height, Instruments.formWidth - Instruments.buttonPanelWidth, Instruments.heightOfTabControlWithoutLabels - (int)(1.5 * Instruments.intervalHeight));
                }
            }
        }

        public void setColors()
        {
            LanguagePanel.BackColor = Instruments.myPurpleColor;

            CancelB.BackColor = Instruments.myPurpleColor;

            RecReadyB.BackColor = Instruments.myPurpleColor;

            searchB.BackColor = Color.White;

            FilterB.BackColor = Color.White;

            deleteRecB.BackColor = Instruments.myPurpleColor;

            updateRecB.BackColor = Instruments.myPurpleColor;

            InstrPanel.BackColor = Instruments.myPurpleColor;

            IngrPanel.BackColor = Instruments.myPurpleColor;

            DifficultyPanel.BackColor = Instruments.myPurpleColor;

            TimePanel.BackColor = Instruments.myPurpleColor;

            CategoryPanel.BackColor = Instruments.myPurpleColor;

            RatingPanel.BackColor = Instruments.myPurpleColor;

            PhotoPanel.BackColor = Instruments.myPurpleColor;

            TitlePanel.BackColor = Instruments.myPurpleColor;

            closeB.BackColor = Instruments.myPurpleColor;

            myRecB.FlatAppearance.MouseOverBackColor = favB.FlatAppearance.MouseOverBackColor = generalB.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 248, 248);

            addRecB.FlatAppearance.MouseOverBackColor = settingsB.FlatAppearance.MouseOverBackColor = helpB.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 248, 248);

            buttonPanel.BackColor = Instruments.buttonPanelColor;

            lab.BackColor = Instruments.myPurpleColor;

        }

        public void CategoryAndFilterInit()//Инициализация категорий и панели фильтра в соответствии с языком
        {
            if (CategoryCB.Items.Count != 0)
            {
                CategoryCB.Items.Clear();
            }

            if (rateCheckB.Items.Count != 0)
            {
                rateCheckB.Items.Clear();
            }

            if (diffCheckB.Items.Count != 0)
            {
                diffCheckB.Items.Clear();
            }

            if (categoryCheckB.Items.Count != 0)
            {
                categoryCheckB.Items.Clear();
            }

            if (LanguagesForAddingRecipe.isRu)
            {
                foreach (var item in LanguagesForAddingRecipe.categoriesRu)
                {
                    CategoryCB.Items.Add(item);

                    categoryCheckB.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in LanguagesForAddingRecipe.categoriesEn)
                {
                    CategoryCB.Items.Add(item);

                    categoryCheckB.Items.Add(item);
                }
            }
            for (int i = 1; i < 6; i++)
            {
                diffCheckB.Items.Add(i);

                if (i == 1)
                {
                    rateCheckB.Items.Add(i + (LanguagesForAddingRecipe.isRu ? " звезда" : " star"));

                    continue;
                }

                if (i == 5)
                {
                    rateCheckB.Items.Add(i + (LanguagesForAddingRecipe.isRu ? " звезда" : " stars"));

                    continue;
                }

                rateCheckB.Items.Add(i + (LanguagesForAddingRecipe.isRu ? " звезда" : " stars"));
            }
        }

        public void checkButtonsColors(int num)//Функция для проверки активности кнопок
        {
            if (num == (int)Buttons.My_Rec)
            {
                if (myRecB.BackColor != Instruments.myButtonHighlightColor) { myRecB.BackColor = Instruments.myButtonHighlightColor; }
            }
            else
            {
                myRecB.BackColor = Color.Transparent;
            }

            if (num == (int)Buttons.Fav_Rec)
            {
                if (favB.BackColor != Instruments.myButtonHighlightColor) { favB.BackColor = Instruments.myButtonHighlightColor; }
            }
            else
            {
                favB.BackColor = Color.Transparent;
            }

            if (num == (int)Buttons.General_Rec)
            {
                if (generalB.BackColor != Instruments.myButtonHighlightColor) { generalB.BackColor = Instruments.myButtonHighlightColor; }
            }
            else
            {
                generalB.BackColor = Color.Transparent;
            }

            if (num == (int)Buttons.Add_Rec)
            {
                if (addRecB.BackColor != Instruments.myButtonHighlightColor) { addRecB.BackColor = Instruments.myButtonHighlightColor; }
            }
            else
            {
                addRecB.BackColor = Color.Transparent;
            }

            if (num == (int)Buttons.Settings)
            {
                if (settingsB.BackColor != Instruments.myButtonHighlightColor) { settingsB.BackColor = Instruments.myButtonHighlightColor; }
            }
            else
            {
                settingsB.BackColor = Color.Transparent;
            }

            if (num == (int)(int)Buttons.Help)
            {
                if (helpB.BackColor != Instruments.myButtonHighlightColor) { helpB.BackColor = Instruments.myButtonHighlightColor; }
            }
            else
            {
                helpB.BackColor = Color.Transparent;
            }
        }

        Label labelForNoRec()
        {
            Label l = new Label();

            l.Font = new Font(startLabel.Font.FontFamily, 30, startLabel.Font.Style);

            l.Text = LanguagesForAddingRecipe.isRu ? LanguagesForAddingRecipe.haveSomeRecRu : LanguagesForAddingRecipe.haveSomeRecEn;

            l.TextAlign = ContentAlignment.MiddleCenter;

            l.SetBounds(0, general_recipes_list.Height - 400, general_recipes_list.Width - 50, 300);

            return l;
        }

        PictureBox pbForNoRec()
        {
            PictureBox pb = new PictureBox();

            pb.SizeMode = PictureBoxSizeMode.Zoom;//??????????????????

            pb.SetBounds(general_recipes_list.Width / 2 - 160, 100, 256, 256);

            pb.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\em.png");

            return pb;
        }

        public TableLayoutPanel createTableForRecipes(Recipe r)//Создание рецепта для отображения
        {
            int intervalX = my_recipes_list.Width / 20;

            int intervalY = Instruments.intervalY;

            TableLayoutPanel t = new TableLayoutPanel();

            counter++;

            if (counter % 2 == 0)
            {
                t.SetBounds(intervalX + (int)(partsForPanel / 2) * intervalX, i, (int)(partsForPanel / 2) * intervalX - 40, InstrPanel.Height);//НЕ ЗАБУДЬ КНОПКУ ИЗБРАННОЕ

                i += t.Height + intervalY;
            }
            else
            {
                t.SetBounds(0, (i), (int)(partsForPanel / 2) * intervalX - 40, InstrPanel.Height);//НЕ ЗАБУДЬ КНОПКУ ИЗБРАННОЕ
            }

            t.BackColor = Instruments.buttonPanelColor;

            Instruments.SetRoundedShape(t, 80);

            PictureBox pb = new PictureBox();

            pb.SizeMode = PictureBoxSizeMode.Zoom;

            if (r.Pic != null)
            {
                using (MemoryStream productImageStream = new System.IO.MemoryStream(r.Pic))
                {
                    ImageConverter imageConverter = new System.Drawing.ImageConverter();

                    pb.BackgroundImage = imageConverter.ConvertFrom(r.Pic) as System.Drawing.Image;

                    pb.SizeMode = PictureBoxSizeMode.CenterImage;

                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            else
            {
                pb.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\standart_photo.jpg");

                pb.SizeMode = PictureBoxSizeMode.CenterImage;

                pb.BackgroundImageLayout = ImageLayout.Stretch;
            }

            t.Controls.Add(pb, 0, 0);

            t.Controls[0].SetBounds(50, 0, t.Size.Height + 60, t.Size.Height);

            Instruments.SetRoundedShape(t.Controls[0], 80);

            TableLayoutPanel panel = new TableLayoutPanel();

            panel.Dock = DockStyle.Fill;

            panel.ColumnCount = 1;

            panel.RowCount = 3;

            TableLayoutPanel pan = new TableLayoutPanel();
            
            pan.ColumnCount = 2;

            pan.RowCount=1;

            Label l = new Label();

            PictureBox fav = new PictureBox();

            Label l1 = new Label();

            TableLayoutPanel stars = new TableLayoutPanel();

            //Событие заполнения рецепта
            EventHandler handler =
                delegate
                {
                    fullRecipe(r.Id, whatButtonClicked);
                };

            //Наведение на рецепт
            EventHandler handler1 =
                delegate
                {
                    l.Font = new Font(l.Font.FontFamily, l.Font.Size +2.5f, l.Font.Style);

                    l.ForeColor = Instruments.myPurpleColor;
                };

            //Отведение с рецепта
            EventHandler handler2 =
                delegate
                {
                    l.Font = new Font(l.Font.FontFamily, l.Font.Size - 2.5f, l.Font.Style);

                    l.ForeColor = Color.Black;
                };

            EventHandler handler3 =
                delegate
                {
                    if (r.Star)
                    {
                        fav.Image = Image.FromFile(HeartFileNameOpacity);
                    }
                    else
                    {
                        fav.Image = Image.FromFile(HeartFileNameFull);
                    }
                    
                    changeFavourite(r);
                };

            Parallel.Invoke(
                () =>
                    {
                    l.Click += handler;

                    l.MouseEnter += handler1;

                    l.MouseLeave += handler2;

                    l.AutoSize = false;

                    l.TextAlign = ContentAlignment.TopLeft;

                    l.Font = new Font(myRecB.Font.FontFamily, 23.5f, myRecB.Font.Style);

                    l.Text = r.Name;
                    },
                ()=>
                    {
                    fav.Click += handler3;

                        fav.Image = r.Star? Image.FromFile(HeartFileNameFull): Image.FromFile(HeartFileNameOpacity);//ПРОВЕРКА НА ИЗБРАННОЕ
                    
                    },
                ()=>
                    {
                    l1.AutoSize = false;

                    l1.TextAlign = ContentAlignment.TopLeft;

                    l1.Font = new Font(myRecB.Font.FontFamily, 15.5f, myRecB.Font.Style);

                    },
                ()=>
                    {
                    stars.ColumnCount = 5;

                    stars.RowCount = 1;

                    int mark = int.Parse(r.Marklike);

                    for (int j = 0; j < 5; j++)
                    {
                        PictureBox p = new PictureBox();

                        p.SizeMode = PictureBoxSizeMode.Zoom;

                        if (mark > 0)
                        {
                            p.BackgroundImage = Image.FromFile(ImageFileNameFull);
                        }
                        else
                        {
                            p.BackgroundImage = Image.FromFile(ImageFileNameOpacity);
                        }

                        p.Size = new Size(32, 32);

                        stars.Controls.Add(p, j, 0);

                        mark--;
                        }
                    }
                
                );
            pan.Controls.Add(l);

            pan.Controls[0].SetBounds(0, 0, t.Size.Width - t.Controls[0].Size.Width - 80, t.Height / 2);

            pan.Controls.Add(fav);

            pan.Controls[1].SetBounds(pan.Controls[0].Width, 0, 32, 32);

            panel.Controls.Add(pan);

            panel.Controls[0].SetBounds(0, 0, t.Size.Width - t.Controls[0].Size.Width - 3,(int)( t.Height / 2.7));
            
            panel.Controls.Add(l1, 1, 0);

            panel.Controls[1].SetBounds(0, 0, t.Size.Width - t.Controls[0].Size.Width - 3, t.Height / 3);

            panel.Controls[1].Text = DiffL.Text + ": " + r.Markdif + " / 5" + Environment.NewLine + TimeL.Text + ": " + r.Time + Environment.NewLine + CategoryL.Text + ": " + r.Category;
            
            panel.Controls.Add(stars, 0, 2);

            panel.Controls[2].SetBounds(0, 6, t.Size.Width - t.Controls[0].Size.Width - 3, t.Height / 4);

            t.Controls.Add(panel, 1, 0);

            return t;
        }
        
        public void changeFavourite(Recipe r)
        {
            if (r.Star)
            {
                ControllerForBD.setStar(r.Id, false);
            }
            else
            {
                ControllerForBD.setStar(r.Id, true);
            }
        }

        public void fullRecipe(int id, int whatBu)//Заполнение рецепта при нажатии
        {
            if (whatBu == (int)Buttons.My_Rec)
            {
                main_recipe = ControllerForBD.SelectById(id, "myrecipes");
            }
            if (whatBu == (int)Buttons.Fav_Rec)
            {
                main_recipe = ControllerForBD.SelectById(id, "starrecipes");
            }
            if (whatBu == (int)Buttons.General_Rec)
            {
                main_recipe = ControllerForBD.SelectById(id, "inetrecipes");
            }

            RecReadyB.Hide();
            //НЕ ЗАБУДЬ СДЕЛАТЬ ОТРИСОВКУ ЗВЕЗДОЧЕК И КАРТИНКИ РЕЦЕПТА
            CancelB.Hide();

            updateRecB.Show();

            deleteRecB.Show();

            tabContr.SelectedIndex = (int)Buttons.Add_Rec;//НЕ ЗАБУДЬ ДОДЕЛАТЬ ИЗБРАННЫЕ

            AddLabel.Text = "";
            
            //МБ ИНВОУК СДЕЛАТЬ
            cleanAddRecForm();

            rec_name.Text = main_recipe.Name;

            CategoryCB.Text = main_recipe.Category;

            time_rec.Text = main_recipe.Time;

            markDif.Text = main_recipe.Markdif;

            if (main_recipe.Ingredients != null)
            {
                Ingr_rec.Text = main_recipe.Ingredients;
            }
            else
            {
                Ingr_rec.Text = "-";
            }

            if (main_recipe.Guide != null)
            {
                Instr_rec.Text = main_recipe.Guide;
            }
            else
            {
                Instr_rec.Text = "-";
            }

            if (main_recipe.Pic == null)
            {
                RecPhoto.Image = Image.FromFile(StandartPhotoImage);
            }
            else
            {
                RecPhoto.Image = Instruments.convertBIntoImage(main_recipe.Pic);
                
            }

            if (int.Parse(main_recipe.Marklike)>=1){pictureBox1.Image = Image.FromFile(ImageFileNameFull);}
            else{pictureBox1.Image = Image.FromFile(ImageFileNameOpacity);}

            if (int.Parse(main_recipe.Marklike) >= 2) { pictureBox2.Image = Image.FromFile(ImageFileNameFull); }
            else { pictureBox2.Image = Image.FromFile(ImageFileNameOpacity); }

            if (int.Parse(main_recipe.Marklike) >= 3) { pictureBox3.Image = Image.FromFile(ImageFileNameFull); }
            else { pictureBox3.Image = Image.FromFile(ImageFileNameOpacity); }

            if (int.Parse(main_recipe.Marklike) >= 4) { pictureBox4.Image = Image.FromFile(ImageFileNameFull); }
            else { pictureBox4.Image = Image.FromFile(ImageFileNameOpacity); }

            if (int.Parse(main_recipe.Marklike) ==5) { pictureBox5.Image = Image.FromFile(ImageFileNameFull); }
            else { pictureBox5.Image = Image.FromFile(ImageFileNameOpacity); }
        }

        /* public static void SetDoubleBuffered(Control c)//Устранение мерцания
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
         }*/

        private void deleteRecB_Click(object sender, EventArgs e)
        {
            if (main_recipe != null)
            {
                ControllerForBD.deleteById(main_recipe.Id);//ДЛЯ РЕЦЕПТОВ ИЗ ИНТЕРНЕТА ТАКОЕ НЕ ДЕЛАЕМ
                tabContr.SelectedIndex = (int)Buttons.Start_Page;
                whatButtonClicked = -1;
                checkButtonsColors(-1);
            }
        }

        private void updateRecB_Click(object sender, EventArgs e)//Редактировать рецепт
        {
            whatClicked = int.Parse(main_recipe.Marklike);
            checkRecForm();
            //ControllerForBD.editRecipe(main_recipe.Name.Equals(rec_name)?, main_recipe.Category, main_recipe.Ingredients, main_recipe.Guide, main_recipe.Marklike, main_recipe.Markdif, main_recipe.Time, main_recipe.Pic);
        }

        private void searchB_Click(object sender, EventArgs e)
        {

            if (whatButtonClicked != (int)Buttons.Fav_Rec && whatButtonClicked != (int)Buttons.My_Rec && whatButtonClicked != (int)Buttons.General_Rec)
            {
                MessageBox.Show(LanguagesForAddingRecipe.isRu ? "Для поиска Вам необходимо зайти в какой-либо раздел" : "To use search you have to choose a page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            /*if (searchTB.Text == String.Empty)
            {
                MessageBox.Show(LanguagesForAddingRecipe.isRu ? "Строка поиска пуста" : "Search text box is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }*/
            tabContr.SelectedIndex = (int)Buttons.SearchResultPage;

            string filter = "";

            List<string> checkedCategory = new List<string>();

            List<string> checkedDiff = new List<string>();

            List<string> checkedMarkLike = new List<string>();

            if (categoryCheckB.CheckedItems.Count != 0)
            {
                foreach (var item in categoryCheckB.CheckedItems)
                {
                    checkedCategory.Add(item.ToString());
                }
            }
            if (diffCheckB.CheckedItems.Count != 0)
            {
                foreach (var item in diffCheckB.CheckedItems)
                {
                    checkedDiff.Add(item.ToString());
                }
            }
            if (rateCheckB.CheckedItems.Count != 0)
            {
                foreach (var item in rateCheckB.CheckedItems)
                {
                    checkedMarkLike.Add(item.ToString()[0].ToString());
                }
            }//ДОДЕЛАТЬ, ЕСЛИ ФИЛЬТР ПУСТОЙ, ТО В PairSearch pair = new PairSearch(filter, searchTB.Text); В ФИЛЬТР ПЕРЕДАВАТЬ ""
            if (whatButtonClicked == (int)Buttons.My_Rec)//2 для всех рецептов
            {
                filter = ControllerForBD.createFilter(0, checkedCategory, checkedMarkLike, checkedDiff, false);
            }
            if (whatButtonClicked == (int)Buttons.Fav_Rec)
            {
                filter = ControllerForBD.createFilter(0, checkedCategory, checkedMarkLike, checkedDiff, true);
            }
            if (whatButtonClicked == (int)Buttons.General_Rec)
            {
                filter = ControllerForBD.createFilter(1, checkedCategory, checkedMarkLike, checkedDiff, false);
            }

            PairSearch pair = new PairSearch(filter, searchTB.Text);

            ControllerForBD.alterSearch(pair);

            showAllSearchRecipe();

        }

        public void showAllSearchRecipe()
        {
            Action action = () => search_list.Controls.Clear();

            if (InvokeRequired) { Invoke(action); }

            else { search_list.Controls.Clear(); }

            i = counter = 0;

            if (ControllerForBD.searchRecipes.Count != 0)
            {
                while (ControllerForBD.searchRecipes.Count != 0)
                {
                    Recipe r = ControllerForBD.searchRecipes.ElementAt(0);

                    var t = createTableForRecipes(r);

                    search_list.BeginInvoke((MethodInvoker)(() => search_list.Controls.Add(t)));

                    ControllerForBD.searchRecipes.Remove(r);
                }
            }
            else
            {
                search_list.BeginInvoke((MethodInvoker)(() => search_list.Controls.Add(pbForNoRec())));

                search_list.BeginInvoke((MethodInvoker)(() => search_list.Controls.Add(labelForNoRec())));
            }

        }

        private void FilterB_Click(object sender, EventArgs e)//Повторное нажатие?
        {
            filterPanel.Width = filterPanel.MaximumSize.Width;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                FilterB.Image = Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\collapse.png");
                filterPanel.Height += 30;
                if (filterPanel.Size == filterPanel.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                FilterB.Image = Image.FromFile(Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 27) + "images\\expand.png");
                filterPanel.Height -= 30;
                if (filterPanel.Size == filterPanel.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        
    }
}
