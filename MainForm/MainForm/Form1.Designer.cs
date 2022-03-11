namespace MainForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.settingsB = new System.Windows.Forms.Button();
            this.addRecB = new System.Windows.Forms.Button();
            this.generalB = new System.Windows.Forms.Button();
            this.favB = new System.Windows.Forms.Button();
            this.myRecB = new System.Windows.Forms.Button();
            this.helpB = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.tabContr = new System.Windows.Forms.TabControl();
            this.MyRecPage = new System.Windows.Forms.TabPage();
            this.my_recipes_list = new System.Windows.Forms.TableLayoutPanel();
            this.myL = new System.Windows.Forms.Label();
            this.FavPage = new System.Windows.Forms.TabPage();
            this.favL = new System.Windows.Forms.Label();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.genL = new System.Windows.Forms.Label();
            this.addRecPage = new System.Windows.Forms.TabPage();
            this.CancelB = new System.Windows.Forms.Button();
            this.RecReadyB = new System.Windows.Forms.Button();
            this.RatingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RateLable = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InstrPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InstrL = new System.Windows.Forms.Label();
            this.Instr_rec = new System.Windows.Forms.TextBox();
            this.IngrPanel = new System.Windows.Forms.TableLayoutPanel();
            this.IngredL = new System.Windows.Forms.Label();
            this.Ingr_rec = new System.Windows.Forms.TextBox();
            this.TitlePanel = new System.Windows.Forms.TableLayoutPanel();
            this.TitleL = new System.Windows.Forms.Label();
            this.rec_name = new System.Windows.Forms.TextBox();
            this.DifficultyPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DiffL = new System.Windows.Forms.Label();
            this.markDif = new System.Windows.Forms.ComboBox();
            this.TimePanel = new System.Windows.Forms.TableLayoutPanel();
            this.TimeL = new System.Windows.Forms.Label();
            this.time_rec = new System.Windows.Forms.MaskedTextBox();
            this.CategoryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryL = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.PhotoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PhotoLab = new System.Windows.Forms.Label();
            this.RecPhoto = new System.Windows.Forms.PictureBox();
            this.AddLabel = new System.Windows.Forms.Label();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.LanguagePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ChangeLLabel = new System.Windows.Forms.Label();
            this.LangCB = new System.Windows.Forms.ComboBox();
            this.SettingsL = new System.Windows.Forms.Label();
            this.helpPage = new System.Windows.Forms.TabPage();
            this.helpL = new System.Windows.Forms.Label();
            this.buttonPanel.SuspendLayout();
            this.tabContr.SuspendLayout();
            this.MyRecPage.SuspendLayout();
            this.FavPage.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            this.addRecPage.SuspendLayout();
            this.RatingPanel.SuspendLayout();
            this.Rate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InstrPanel.SuspendLayout();
            this.IngrPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.DifficultyPanel.SuspendLayout();
            this.TimePanel.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            this.PhotoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecPhoto)).BeginInit();
            this.settingsPage.SuspendLayout();
            this.LanguagePanel.SuspendLayout();
            this.helpPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.Transparent;
            this.buttonPanel.ColumnCount = 1;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonPanel.Controls.Add(this.settingsB, 0, 5);
            this.buttonPanel.Controls.Add(this.addRecB, 0, 4);
            this.buttonPanel.Controls.Add(this.generalB, 0, 3);
            this.buttonPanel.Controls.Add(this.favB, 0, 2);
            this.buttonPanel.Controls.Add(this.myRecB, 0, 1);
            this.buttonPanel.Controls.Add(this.helpB, 0, 6);
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 8;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.469037F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8348F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8348F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8348F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8348F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8348F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8348F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.52213F));
            this.buttonPanel.Size = new System.Drawing.Size(301, 733);
            this.buttonPanel.TabIndex = 0;
            // 
            // settingsB
            // 
            this.settingsB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsB.FlatAppearance.BorderSize = 0;
            this.settingsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsB.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsB.Image = ((System.Drawing.Image)(resources.GetObject("settingsB.Image")));
            this.settingsB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settingsB.Location = new System.Drawing.Point(0, 391);
            this.settingsB.Margin = new System.Windows.Forms.Padding(0);
            this.settingsB.Name = "settingsB";
            this.settingsB.Size = new System.Drawing.Size(301, 86);
            this.settingsB.TabIndex = 5;
            this.settingsB.Text = "Настройки";
            this.settingsB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.settingsB.UseVisualStyleBackColor = true;
            this.settingsB.Click += new System.EventHandler(this.settingsB_Click);
            // 
            // addRecB
            // 
            this.addRecB.BackColor = System.Drawing.Color.Transparent;
            this.addRecB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRecB.FlatAppearance.BorderSize = 0;
            this.addRecB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecB.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRecB.Image = ((System.Drawing.Image)(resources.GetObject("addRecB.Image")));
            this.addRecB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addRecB.Location = new System.Drawing.Point(0, 305);
            this.addRecB.Margin = new System.Windows.Forms.Padding(0);
            this.addRecB.Name = "addRecB";
            this.addRecB.Size = new System.Drawing.Size(301, 86);
            this.addRecB.TabIndex = 4;
            this.addRecB.Text = "Добавить рецепт";
            this.addRecB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addRecB.UseVisualStyleBackColor = false;
            this.addRecB.Click += new System.EventHandler(this.addRecB_Click);
            // 
            // generalB
            // 
            this.generalB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalB.FlatAppearance.BorderSize = 0;
            this.generalB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalB.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalB.Image = ((System.Drawing.Image)(resources.GetObject("generalB.Image")));
            this.generalB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.generalB.Location = new System.Drawing.Point(0, 219);
            this.generalB.Margin = new System.Windows.Forms.Padding(0);
            this.generalB.Name = "generalB";
            this.generalB.Size = new System.Drawing.Size(301, 86);
            this.generalB.TabIndex = 3;
            this.generalB.Text = "Общие рецепты";
            this.generalB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.generalB.UseVisualStyleBackColor = true;
            this.generalB.Click += new System.EventHandler(this.generalB_Click);
            // 
            // favB
            // 
            this.favB.BackColor = System.Drawing.Color.Transparent;
            this.favB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favB.FlatAppearance.BorderSize = 0;
            this.favB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.favB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.favB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favB.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.favB.Image = ((System.Drawing.Image)(resources.GetObject("favB.Image")));
            this.favB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.favB.Location = new System.Drawing.Point(0, 133);
            this.favB.Margin = new System.Windows.Forms.Padding(0);
            this.favB.Name = "favB";
            this.favB.Size = new System.Drawing.Size(301, 86);
            this.favB.TabIndex = 2;
            this.favB.Text = "Избранные рецепты";
            this.favB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.favB.UseVisualStyleBackColor = false;
            this.favB.Click += new System.EventHandler(this.favB_Click);
            // 
            // myRecB
            // 
            this.myRecB.BackColor = System.Drawing.Color.Transparent;
            this.myRecB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myRecB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myRecB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.myRecB.FlatAppearance.BorderSize = 0;
            this.myRecB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.myRecB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.myRecB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myRecB.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myRecB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myRecB.Image = ((System.Drawing.Image)(resources.GetObject("myRecB.Image")));
            this.myRecB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.myRecB.Location = new System.Drawing.Point(0, 47);
            this.myRecB.Margin = new System.Windows.Forms.Padding(0);
            this.myRecB.Name = "myRecB";
            this.myRecB.Size = new System.Drawing.Size(301, 86);
            this.myRecB.TabIndex = 1;
            this.myRecB.Text = "Мои рецепты";
            this.myRecB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.myRecB.UseVisualStyleBackColor = false;
            this.myRecB.Click += new System.EventHandler(this.myRecB_Click);
            // 
            // helpB
            // 
            this.helpB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpB.FlatAppearance.BorderSize = 0;
            this.helpB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpB.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpB.Image = ((System.Drawing.Image)(resources.GetObject("helpB.Image")));
            this.helpB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.helpB.Location = new System.Drawing.Point(0, 477);
            this.helpB.Margin = new System.Windows.Forms.Padding(0);
            this.helpB.Name = "helpB";
            this.helpB.Size = new System.Drawing.Size(301, 86);
            this.helpB.TabIndex = 6;
            this.helpB.Text = "Помощь";
            this.helpB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpB.UseVisualStyleBackColor = true;
            this.helpB.Click += new System.EventHandler(this.helpB_Click);
            // 
            // lab
            // 
            this.lab.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab.Font = new System.Drawing.Font("Brush Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab.Location = new System.Drawing.Point(0, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(1404, 26);
            this.lab.TabIndex = 1;
            this.lab.Text = "My CookBook";
            // 
            // tabContr
            // 
            this.tabContr.Controls.Add(this.MyRecPage);
            this.tabContr.Controls.Add(this.FavPage);
            this.tabContr.Controls.Add(this.GeneralPage);
            this.tabContr.Controls.Add(this.addRecPage);
            this.tabContr.Controls.Add(this.settingsPage);
            this.tabContr.Controls.Add(this.helpPage);
            this.tabContr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabContr.Location = new System.Drawing.Point(304, 45);
            this.tabContr.Name = "tabContr";
            this.tabContr.SelectedIndex = 0;
            this.tabContr.Size = new System.Drawing.Size(1029, 686);
            this.tabContr.TabIndex = 2;
            // 
            // MyRecPage
            // 
            this.MyRecPage.Controls.Add(this.my_recipes_list);
            this.MyRecPage.Controls.Add(this.myL);
            this.MyRecPage.Location = new System.Drawing.Point(4, 30);
            this.MyRecPage.Name = "MyRecPage";
            this.MyRecPage.Padding = new System.Windows.Forms.Padding(3);
            this.MyRecPage.Size = new System.Drawing.Size(1021, 652);
            this.MyRecPage.TabIndex = 0;
            this.MyRecPage.Text = "tabPage1";
            this.MyRecPage.UseVisualStyleBackColor = true;
            // 
            // my_recipes_list
            // 
            this.my_recipes_list.AutoScroll = true;
            this.my_recipes_list.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.my_recipes_list.ColumnCount = 1;
            this.my_recipes_list.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.my_recipes_list.Location = new System.Drawing.Point(294, 179);
            this.my_recipes_list.Name = "my_recipes_list";
            this.my_recipes_list.RowCount = 1;
            this.my_recipes_list.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.my_recipes_list.Size = new System.Drawing.Size(200, 100);
            this.my_recipes_list.TabIndex = 4;
            // 
            // myL
            // 
            this.myL.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myL.Location = new System.Drawing.Point(277, 4);
            this.myL.Name = "myL";
            this.myL.Size = new System.Drawing.Size(357, 52);
            this.myL.TabIndex = 3;
            this.myL.Text = "Мои рецепты";
            this.myL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FavPage
            // 
            this.FavPage.Controls.Add(this.favL);
            this.FavPage.Location = new System.Drawing.Point(4, 22);
            this.FavPage.Name = "FavPage";
            this.FavPage.Padding = new System.Windows.Forms.Padding(3);
            this.FavPage.Size = new System.Drawing.Size(1021, 660);
            this.FavPage.TabIndex = 1;
            this.FavPage.Text = "tabPage2";
            this.FavPage.UseVisualStyleBackColor = true;
            // 
            // favL
            // 
            this.favL.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.favL.Location = new System.Drawing.Point(286, 0);
            this.favL.Name = "favL";
            this.favL.Size = new System.Drawing.Size(357, 52);
            this.favL.TabIndex = 2;
            this.favL.Text = "Избранные рецепты";
            this.favL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeneralPage
            // 
            this.GeneralPage.Controls.Add(this.genL);
            this.GeneralPage.Location = new System.Drawing.Point(4, 22);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Size = new System.Drawing.Size(1021, 660);
            this.GeneralPage.TabIndex = 2;
            this.GeneralPage.Text = "tabPage1";
            this.GeneralPage.UseVisualStyleBackColor = true;
            // 
            // genL
            // 
            this.genL.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genL.Location = new System.Drawing.Point(273, 2);
            this.genL.Name = "genL";
            this.genL.Size = new System.Drawing.Size(357, 52);
            this.genL.TabIndex = 1;
            this.genL.Text = "Общие рецепты";
            this.genL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addRecPage
            // 
            this.addRecPage.BackColor = System.Drawing.Color.White;
            this.addRecPage.Controls.Add(this.CancelB);
            this.addRecPage.Controls.Add(this.RecReadyB);
            this.addRecPage.Controls.Add(this.RatingPanel);
            this.addRecPage.Controls.Add(this.InstrPanel);
            this.addRecPage.Controls.Add(this.IngrPanel);
            this.addRecPage.Controls.Add(this.TitlePanel);
            this.addRecPage.Controls.Add(this.DifficultyPanel);
            this.addRecPage.Controls.Add(this.TimePanel);
            this.addRecPage.Controls.Add(this.CategoryPanel);
            this.addRecPage.Controls.Add(this.PhotoPanel);
            this.addRecPage.Controls.Add(this.AddLabel);
            this.addRecPage.Location = new System.Drawing.Point(4, 30);
            this.addRecPage.Name = "addRecPage";
            this.addRecPage.Size = new System.Drawing.Size(1021, 652);
            this.addRecPage.TabIndex = 3;
            this.addRecPage.Text = "Добавить";
            // 
            // CancelB
            // 
            this.CancelB.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelB.Location = new System.Drawing.Point(722, 562);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 16;
            this.CancelB.Text = "button1";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // RecReadyB
            // 
            this.RecReadyB.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecReadyB.Location = new System.Drawing.Point(369, 563);
            this.RecReadyB.Name = "RecReadyB";
            this.RecReadyB.Size = new System.Drawing.Size(75, 23);
            this.RecReadyB.TabIndex = 15;
            this.RecReadyB.Text = "button1";
            this.RecReadyB.UseVisualStyleBackColor = true;
            this.RecReadyB.Click += new System.EventHandler(this.RecReadyB_Click);
            // 
            // RatingPanel
            // 
            this.RatingPanel.ColumnCount = 1;
            this.RatingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RatingPanel.Controls.Add(this.RateLable, 0, 0);
            this.RatingPanel.Controls.Add(this.Rate, 0, 1);
            this.RatingPanel.Location = new System.Drawing.Point(344, 156);
            this.RatingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RatingPanel.Name = "RatingPanel";
            this.RatingPanel.RowCount = 2;
            this.RatingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.RatingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.RatingPanel.Size = new System.Drawing.Size(277, 100);
            this.RatingPanel.TabIndex = 14;
            // 
            // RateLable
            // 
            this.RateLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RateLable.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RateLable.Location = new System.Drawing.Point(3, 0);
            this.RateLable.Name = "RateLable";
            this.RateLable.Size = new System.Drawing.Size(271, 35);
            this.RateLable.TabIndex = 0;
            this.RateLable.Text = "label3";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.ColumnCount = 5;
            this.Rate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Rate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Rate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Rate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Rate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Rate.Controls.Add(this.pictureBox5, 4, 0);
            this.Rate.Controls.Add(this.pictureBox4, 3, 0);
            this.Rate.Controls.Add(this.pictureBox3, 2, 0);
            this.Rate.Controls.Add(this.pictureBox2, 1, 0);
            this.Rate.Controls.Add(this.pictureBox1, 0, 0);
            this.Rate.Location = new System.Drawing.Point(0, 35);
            this.Rate.Margin = new System.Windows.Forms.Padding(0);
            this.Rate.Name = "Rate";
            this.Rate.RowCount = 1;
            this.Rate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Rate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Rate.Size = new System.Drawing.Size(260, 40);
            this.Rate.TabIndex = 13;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(211, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 34);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(159, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 34);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(107, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 34);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(55, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 34);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave_1);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // InstrPanel
            // 
            this.InstrPanel.ColumnCount = 1;
            this.InstrPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InstrPanel.Controls.Add(this.InstrL, 0, 0);
            this.InstrPanel.Controls.Add(this.Instr_rec, 0, 1);
            this.InstrPanel.Location = new System.Drawing.Point(743, 279);
            this.InstrPanel.Name = "InstrPanel";
            this.InstrPanel.RowCount = 2;
            this.InstrPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.InstrPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.InstrPanel.Size = new System.Drawing.Size(194, 121);
            this.InstrPanel.TabIndex = 12;
            // 
            // InstrL
            // 
            this.InstrL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstrL.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstrL.Location = new System.Drawing.Point(0, 0);
            this.InstrL.Margin = new System.Windows.Forms.Padding(0);
            this.InstrL.Name = "InstrL";
            this.InstrL.Size = new System.Drawing.Size(194, 18);
            this.InstrL.TabIndex = 0;
            this.InstrL.Text = "label3";
            // 
            // Instr_rec
            // 
            this.Instr_rec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Instr_rec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Instr_rec.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr_rec.Location = new System.Drawing.Point(3, 21);
            this.Instr_rec.Multiline = true;
            this.Instr_rec.Name = "Instr_rec";
            this.Instr_rec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Instr_rec.Size = new System.Drawing.Size(188, 97);
            this.Instr_rec.TabIndex = 10;
            // 
            // IngrPanel
            // 
            this.IngrPanel.ColumnCount = 1;
            this.IngrPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IngrPanel.Controls.Add(this.IngredL, 0, 0);
            this.IngrPanel.Controls.Add(this.Ingr_rec, 0, 1);
            this.IngrPanel.Location = new System.Drawing.Point(734, 139);
            this.IngrPanel.Name = "IngrPanel";
            this.IngrPanel.RowCount = 2;
            this.IngrPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.IngrPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.IngrPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.IngrPanel.Size = new System.Drawing.Size(200, 100);
            this.IngrPanel.TabIndex = 11;
            // 
            // IngredL
            // 
            this.IngredL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IngredL.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IngredL.Location = new System.Drawing.Point(0, 0);
            this.IngredL.Margin = new System.Windows.Forms.Padding(0);
            this.IngredL.Name = "IngredL";
            this.IngredL.Size = new System.Drawing.Size(200, 15);
            this.IngredL.TabIndex = 0;
            this.IngredL.Text = "label3";
            // 
            // Ingr_rec
            // 
            this.Ingr_rec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ingr_rec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ingr_rec.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ingr_rec.Location = new System.Drawing.Point(3, 18);
            this.Ingr_rec.Multiline = true;
            this.Ingr_rec.Name = "Ingr_rec";
            this.Ingr_rec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ingr_rec.Size = new System.Drawing.Size(194, 79);
            this.Ingr_rec.TabIndex = 10;
            // 
            // TitlePanel
            // 
            this.TitlePanel.ColumnCount = 1;
            this.TitlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TitlePanel.Controls.Add(this.TitleL, 0, 0);
            this.TitlePanel.Controls.Add(this.rec_name, 0, 1);
            this.TitlePanel.Location = new System.Drawing.Point(37, 69);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.RowCount = 2;
            this.TitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.TitlePanel.Size = new System.Drawing.Size(619, 50);
            this.TitlePanel.TabIndex = 9;
            // 
            // TitleL
            // 
            this.TitleL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleL.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleL.Location = new System.Drawing.Point(0, 0);
            this.TitleL.Margin = new System.Windows.Forms.Padding(0);
            this.TitleL.Name = "TitleL";
            this.TitleL.Size = new System.Drawing.Size(619, 17);
            this.TitleL.TabIndex = 0;
            this.TitleL.Text = "label3";
            // 
            // rec_name
            // 
            this.rec_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rec_name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rec_name.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rec_name.Location = new System.Drawing.Point(3, 20);
            this.rec_name.Multiline = true;
            this.rec_name.Name = "rec_name";
            this.rec_name.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rec_name.Size = new System.Drawing.Size(613, 27);
            this.rec_name.TabIndex = 1;
            // 
            // DifficultyPanel
            // 
            this.DifficultyPanel.ColumnCount = 1;
            this.DifficultyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DifficultyPanel.Controls.Add(this.DiffL, 0, 0);
            this.DifficultyPanel.Controls.Add(this.markDif, 0, 1);
            this.DifficultyPanel.Location = new System.Drawing.Point(338, 383);
            this.DifficultyPanel.Name = "DifficultyPanel";
            this.DifficultyPanel.RowCount = 2;
            this.DifficultyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.DifficultyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.DifficultyPanel.Size = new System.Drawing.Size(311, 57);
            this.DifficultyPanel.TabIndex = 8;
            // 
            // DiffL
            // 
            this.DiffL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiffL.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiffL.Location = new System.Drawing.Point(0, 0);
            this.DiffL.Margin = new System.Windows.Forms.Padding(0);
            this.DiffL.Name = "DiffL";
            this.DiffL.Size = new System.Drawing.Size(311, 19);
            this.DiffL.TabIndex = 0;
            this.DiffL.Text = "label3";
            // 
            // markDif
            // 
            this.markDif.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.markDif.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markDif.FormattingEnabled = true;
            this.markDif.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.markDif.Location = new System.Drawing.Point(3, 22);
            this.markDif.Name = "markDif";
            this.markDif.Size = new System.Drawing.Size(305, 37);
            this.markDif.TabIndex = 1;
            // 
            // TimePanel
            // 
            this.TimePanel.ColumnCount = 1;
            this.TimePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TimePanel.Controls.Add(this.TimeL, 0, 0);
            this.TimePanel.Controls.Add(this.time_rec, 0, 1);
            this.TimePanel.Location = new System.Drawing.Point(339, 335);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.RowCount = 2;
            this.TimePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TimePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TimePanel.Size = new System.Drawing.Size(318, 45);
            this.TimePanel.TabIndex = 6;
            // 
            // TimeL
            // 
            this.TimeL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeL.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeL.Location = new System.Drawing.Point(0, 0);
            this.TimeL.Margin = new System.Windows.Forms.Padding(0);
            this.TimeL.Name = "TimeL";
            this.TimeL.Size = new System.Drawing.Size(318, 18);
            this.TimeL.TabIndex = 0;
            this.TimeL.Text = "label3";
            // 
            // time_rec
            // 
            this.time_rec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time_rec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.time_rec.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_rec.Location = new System.Drawing.Point(3, 21);
            this.time_rec.Mask = "00:00:00";
            this.time_rec.Name = "time_rec";
            this.time_rec.Size = new System.Drawing.Size(312, 29);
            this.time_rec.TabIndex = 1;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.ColumnCount = 1;
            this.CategoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CategoryPanel.Controls.Add(this.CategoryL, 0, 0);
            this.CategoryPanel.Controls.Add(this.CategoryCB, 0, 1);
            this.CategoryPanel.Location = new System.Drawing.Point(338, 259);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.RowCount = 2;
            this.CategoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.CategoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.CategoryPanel.Size = new System.Drawing.Size(318, 70);
            this.CategoryPanel.TabIndex = 5;
            // 
            // CategoryL
            // 
            this.CategoryL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryL.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryL.Location = new System.Drawing.Point(0, 0);
            this.CategoryL.Margin = new System.Windows.Forms.Padding(0);
            this.CategoryL.Name = "CategoryL";
            this.CategoryL.Size = new System.Drawing.Size(318, 24);
            this.CategoryL.TabIndex = 0;
            this.CategoryL.Text = "CategoryL";
            // 
            // CategoryCB
            // 
            this.CategoryCB.BackColor = System.Drawing.Color.White;
            this.CategoryCB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CategoryCB.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(3, 30);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(312, 37);
            this.CategoryCB.TabIndex = 2;
            // 
            // PhotoPanel
            // 
            this.PhotoPanel.ColumnCount = 1;
            this.PhotoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PhotoPanel.Controls.Add(this.PhotoLab, 0, 0);
            this.PhotoPanel.Controls.Add(this.RecPhoto, 0, 1);
            this.PhotoPanel.Location = new System.Drawing.Point(37, 122);
            this.PhotoPanel.Name = "PhotoPanel";
            this.PhotoPanel.RowCount = 2;
            this.PhotoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PhotoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.PhotoPanel.Size = new System.Drawing.Size(295, 318);
            this.PhotoPanel.TabIndex = 4;
            // 
            // PhotoLab
            // 
            this.PhotoLab.BackColor = System.Drawing.Color.Transparent;
            this.PhotoLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoLab.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhotoLab.Location = new System.Drawing.Point(0, 0);
            this.PhotoLab.Margin = new System.Windows.Forms.Padding(0);
            this.PhotoLab.Name = "PhotoLab";
            this.PhotoLab.Size = new System.Drawing.Size(295, 31);
            this.PhotoLab.TabIndex = 0;
            this.PhotoLab.Text = "l";
            // 
            // RecPhoto
            // 
            this.RecPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecPhoto.Image = ((System.Drawing.Image)(resources.GetObject("RecPhoto.Image")));
            this.RecPhoto.Location = new System.Drawing.Point(3, 34);
            this.RecPhoto.Name = "RecPhoto";
            this.RecPhoto.Size = new System.Drawing.Size(289, 281);
            this.RecPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RecPhoto.TabIndex = 1;
            this.RecPhoto.TabStop = false;
            this.RecPhoto.Click += new System.EventHandler(this.RecPhoto_Click);
            // 
            // AddLabel
            // 
            this.AddLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLabel.Location = new System.Drawing.Point(359, 4);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(357, 52);
            this.AddLabel.TabIndex = 0;
            this.AddLabel.Text = "Добавление рецепта";
            this.AddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.LanguagePanel);
            this.settingsPage.Controls.Add(this.SettingsL);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(1021, 660);
            this.settingsPage.TabIndex = 4;
            this.settingsPage.Text = "Настройки";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // LanguagePanel
            // 
            this.LanguagePanel.ColumnCount = 1;
            this.LanguagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LanguagePanel.Controls.Add(this.ChangeLLabel, 0, 0);
            this.LanguagePanel.Controls.Add(this.LangCB, 0, 1);
            this.LanguagePanel.Location = new System.Drawing.Point(53, 130);
            this.LanguagePanel.Name = "LanguagePanel";
            this.LanguagePanel.RowCount = 2;
            this.LanguagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.LanguagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.LanguagePanel.Size = new System.Drawing.Size(311, 57);
            this.LanguagePanel.TabIndex = 9;
            // 
            // ChangeLLabel
            // 
            this.ChangeLLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeLLabel.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLLabel.Location = new System.Drawing.Point(0, 0);
            this.ChangeLLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeLLabel.Name = "ChangeLLabel";
            this.ChangeLLabel.Size = new System.Drawing.Size(311, 19);
            this.ChangeLLabel.TabIndex = 0;
            this.ChangeLLabel.Text = "label3";
            // 
            // LangCB
            // 
            this.LangCB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LangCB.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LangCB.FormattingEnabled = true;
            this.LangCB.Items.AddRange(new object[] {
            "Русский",
            "English"});
            this.LangCB.Location = new System.Drawing.Point(3, 22);
            this.LangCB.Name = "LangCB";
            this.LangCB.Size = new System.Drawing.Size(305, 37);
            this.LangCB.TabIndex = 1;
            this.LangCB.SelectedIndexChanged += new System.EventHandler(this.LangCB_SelectedIndexChanged);
            // 
            // SettingsL
            // 
            this.SettingsL.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsL.Location = new System.Drawing.Point(282, 2);
            this.SettingsL.Name = "SettingsL";
            this.SettingsL.Size = new System.Drawing.Size(357, 52);
            this.SettingsL.TabIndex = 1;
            this.SettingsL.Text = "Настройки";
            this.SettingsL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpPage
            // 
            this.helpPage.Controls.Add(this.helpL);
            this.helpPage.Location = new System.Drawing.Point(4, 22);
            this.helpPage.Name = "helpPage";
            this.helpPage.Size = new System.Drawing.Size(1021, 660);
            this.helpPage.TabIndex = 5;
            this.helpPage.Text = "tabPage1";
            this.helpPage.UseVisualStyleBackColor = true;
            // 
            // helpL
            // 
            this.helpL.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpL.Location = new System.Drawing.Point(332, 300);
            this.helpL.Name = "helpL";
            this.helpL.Size = new System.Drawing.Size(357, 52);
            this.helpL.TabIndex = 2;
            this.helpL.Text = "Помощь";
            this.helpL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1404, 781);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.tabContr);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1290, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My cookbook";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.buttonPanel.ResumeLayout(false);
            this.tabContr.ResumeLayout(false);
            this.MyRecPage.ResumeLayout(false);
            this.FavPage.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            this.addRecPage.ResumeLayout(false);
            this.RatingPanel.ResumeLayout(false);
            this.RatingPanel.PerformLayout();
            this.Rate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InstrPanel.ResumeLayout(false);
            this.InstrPanel.PerformLayout();
            this.IngrPanel.ResumeLayout(false);
            this.IngrPanel.PerformLayout();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.DifficultyPanel.ResumeLayout(false);
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.CategoryPanel.ResumeLayout(false);
            this.PhotoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecPhoto)).EndInit();
            this.settingsPage.ResumeLayout(false);
            this.LanguagePanel.ResumeLayout(false);
            this.helpPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.Button settingsB;
        private System.Windows.Forms.Button addRecB;
        private System.Windows.Forms.Button generalB;
        private System.Windows.Forms.Button favB;
        private System.Windows.Forms.Button helpB;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TabPage MyRecPage;
        private System.Windows.Forms.TabPage FavPage;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TabPage addRecPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.TabPage helpPage;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.TableLayoutPanel PhotoPanel;
        private System.Windows.Forms.Label PhotoLab;
        private System.Windows.Forms.PictureBox RecPhoto;
        private System.Windows.Forms.TableLayoutPanel CategoryPanel;
        private System.Windows.Forms.Label CategoryL;
        private System.Windows.Forms.TableLayoutPanel TimePanel;
        private System.Windows.Forms.Label TimeL;
        private System.Windows.Forms.TableLayoutPanel DifficultyPanel;
        private System.Windows.Forms.Label DiffL;
        private System.Windows.Forms.TableLayoutPanel TitlePanel;
        private System.Windows.Forms.Label TitleL;
        private System.Windows.Forms.TextBox rec_name;
        private System.Windows.Forms.ComboBox markDif;
        private System.Windows.Forms.TableLayoutPanel IngrPanel;
        private System.Windows.Forms.Label IngredL;
        private System.Windows.Forms.TextBox Ingr_rec;
        private System.Windows.Forms.TableLayoutPanel InstrPanel;
        private System.Windows.Forms.Label InstrL;
        private System.Windows.Forms.TextBox Instr_rec;
        private System.Windows.Forms.TableLayoutPanel RatingPanel;
        private System.Windows.Forms.Label RateLable;
        private System.Windows.Forms.TableLayoutPanel Rate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button RecReadyB;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Label SettingsL;
        private System.Windows.Forms.Label helpL;
        private System.Windows.Forms.Label genL;
        private System.Windows.Forms.Label myL;
        private System.Windows.Forms.Label favL;
        private System.Windows.Forms.TableLayoutPanel LanguagePanel;
        private System.Windows.Forms.Label ChangeLLabel;
        private System.Windows.Forms.ComboBox LangCB;
        public System.Windows.Forms.TabControl tabContr;
        private System.Windows.Forms.MaskedTextBox time_rec;
        public System.Windows.Forms.Button myRecB;
        private System.Windows.Forms.TableLayoutPanel my_recipes_list;
    }
}

