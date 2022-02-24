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
            this.FavPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.addRecPage = new System.Windows.Forms.TabPage();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.AddLabel = new System.Windows.Forms.Label();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.helpPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.TableLayoutPanel();
            this.TitleL = new System.Windows.Forms.Label();
            this.rec_name = new System.Windows.Forms.TextBox();
            this.PhotoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PhotoLab = new System.Windows.Forms.Label();
            this.RecPhoto = new System.Windows.Forms.PictureBox();
            this.CategoryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryL = new System.Windows.Forms.Label();
            this.TimePanel = new System.Windows.Forms.TableLayoutPanel();
            this.TimeL = new System.Windows.Forms.Label();
            this.time_rec = new System.Windows.Forms.TextBox();
            this.buttonPanel.SuspendLayout();
            this.tabContr.SuspendLayout();
            this.FavPage.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            this.addRecPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.helpPage.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.PhotoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecPhoto)).BeginInit();
            this.CategoryPanel.SuspendLayout();
            this.TimePanel.SuspendLayout();
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
            this.buttonPanel.Location = new System.Drawing.Point(-5, -2);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(5);
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
            this.lab.Size = new System.Drawing.Size(1333, 26);
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
            this.tabContr.Location = new System.Drawing.Point(304, 45);
            this.tabContr.Name = "tabContr";
            this.tabContr.SelectedIndex = 0;
            this.tabContr.Size = new System.Drawing.Size(1029, 686);
            this.tabContr.TabIndex = 2;
            // 
            // MyRecPage
            // 
            this.MyRecPage.Location = new System.Drawing.Point(4, 30);
            this.MyRecPage.Name = "MyRecPage";
            this.MyRecPage.Padding = new System.Windows.Forms.Padding(3);
            this.MyRecPage.Size = new System.Drawing.Size(1021, 652);
            this.MyRecPage.TabIndex = 0;
            this.MyRecPage.Text = "tabPage1";
            this.MyRecPage.UseVisualStyleBackColor = true;
            // 
            // FavPage
            // 
            this.FavPage.Controls.Add(this.label1);
            this.FavPage.Location = new System.Drawing.Point(4, 30);
            this.FavPage.Name = "FavPage";
            this.FavPage.Padding = new System.Windows.Forms.Padding(3);
            this.FavPage.Size = new System.Drawing.Size(1021, 652);
            this.FavPage.TabIndex = 1;
            this.FavPage.Text = "tabPage2";
            this.FavPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // GeneralPage
            // 
            this.GeneralPage.Controls.Add(this.label2);
            this.GeneralPage.Location = new System.Drawing.Point(4, 30);
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.Size = new System.Drawing.Size(1021, 652);
            this.GeneralPage.TabIndex = 2;
            this.GeneralPage.Text = "tabPage1";
            this.GeneralPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // addRecPage
            // 
            this.addRecPage.BackColor = System.Drawing.Color.White;
            this.addRecPage.Controls.Add(this.TimePanel);
            this.addRecPage.Controls.Add(this.CategoryPanel);
            this.addRecPage.Controls.Add(this.PhotoPanel);
            this.addRecPage.Controls.Add(this.TitlePanel);
            this.addRecPage.Controls.Add(this.AddLabel);
            this.addRecPage.Location = new System.Drawing.Point(4, 30);
            this.addRecPage.Name = "addRecPage";
            this.addRecPage.Size = new System.Drawing.Size(1021, 652);
            this.addRecPage.TabIndex = 3;
            this.addRecPage.Text = "Добавить";
            // 
            // CategoryCB
            // 
            this.CategoryCB.BackColor = System.Drawing.Color.White;
            this.CategoryCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryCB.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(6, 35);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(121, 37);
            this.CategoryCB.TabIndex = 2;
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
            this.settingsPage.Controls.Add(this.label4);
            this.settingsPage.Location = new System.Drawing.Point(4, 30);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(1021, 652);
            this.settingsPage.TabIndex = 4;
            this.settingsPage.Text = "tabPage1";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // helpPage
            // 
            this.helpPage.Controls.Add(this.label5);
            this.helpPage.Location = new System.Drawing.Point(4, 30);
            this.helpPage.Name = "helpPage";
            this.helpPage.Size = new System.Drawing.Size(1021, 652);
            this.helpPage.TabIndex = 5;
            this.helpPage.Text = "tabPage1";
            this.helpPage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.White;
            this.TitlePanel.ColumnCount = 1;
            this.TitlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TitlePanel.Controls.Add(this.rec_name, 0, 1);
            this.TitlePanel.Controls.Add(this.TitleL, 0, 0);
            this.TitlePanel.Location = new System.Drawing.Point(37, 56);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.RowCount = 2;
            this.TitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TitlePanel.Size = new System.Drawing.Size(618, 36);
            this.TitlePanel.TabIndex = 3;
            // 
            // TitleL
            // 
            this.TitleL.AutoSize = true;
            this.TitleL.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleL.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleL.Location = new System.Drawing.Point(0, 0);
            this.TitleL.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.TitleL.Name = "TitleL";
            this.TitleL.Size = new System.Drawing.Size(0, 24);
            this.TitleL.TabIndex = 0;
            // 
            // rec_name
            // 
            this.rec_name.BackColor = System.Drawing.Color.White;
            this.rec_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rec_name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rec_name.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rec_name.Location = new System.Drawing.Point(3, 27);
            this.rec_name.Name = "rec_name";
            this.rec_name.Size = new System.Drawing.Size(616, 33);
            this.rec_name.TabIndex = 2;
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
            this.PhotoPanel.Size = new System.Drawing.Size(262, 138);
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
            this.PhotoLab.Size = new System.Drawing.Size(262, 13);
            this.PhotoLab.TabIndex = 0;
            this.PhotoLab.Text = "l";
            // 
            // RecPhoto
            // 
            this.RecPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecPhoto.Location = new System.Drawing.Point(3, 16);
            this.RecPhoto.Name = "RecPhoto";
            this.RecPhoto.Size = new System.Drawing.Size(256, 119);
            this.RecPhoto.TabIndex = 1;
            this.RecPhoto.TabStop = false;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.ColumnCount = 1;
            this.CategoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CategoryPanel.Controls.Add(this.CategoryL, 0, 0);
            this.CategoryPanel.Controls.Add(this.CategoryCB, 0, 1);
            this.CategoryPanel.Location = new System.Drawing.Point(338, 122);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.RowCount = 2;
            this.CategoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.CategoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.CategoryPanel.Size = new System.Drawing.Size(318, 70);
            this.CategoryPanel.TabIndex = 5;
            // 
            // CategoryL
            // 
            this.CategoryL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryL.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryL.Location = new System.Drawing.Point(30, 7);
            this.CategoryL.Margin = new System.Windows.Forms.Padding(0);
            this.CategoryL.Name = "CategoryL";
            this.CategoryL.Size = new System.Drawing.Size(35, 13);
            this.CategoryL.TabIndex = 0;
            this.CategoryL.Text = "CategoryL";
            // 
            // TimePanel
            // 
            this.TimePanel.ColumnCount = 1;
            this.TimePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TimePanel.Controls.Add(this.TimeL, 0, 0);
            this.TimePanel.Controls.Add(this.time_rec, 0, 1);
            this.TimePanel.Location = new System.Drawing.Point(338, 214);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.RowCount = 2;
            this.TimePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TimePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TimePanel.Size = new System.Drawing.Size(200, 89);
            this.TimePanel.TabIndex = 6;
            // 
            // TimeL
            // 
            this.TimeL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeL.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeL.Location = new System.Drawing.Point(40, 11);
            this.TimeL.Margin = new System.Windows.Forms.Padding(0);
            this.TimeL.Name = "TimeL";
            this.TimeL.Size = new System.Drawing.Size(35, 13);
            this.TimeL.TabIndex = 0;
            this.TimeL.Text = "label3";
            // 
            // time_rec
            // 
            this.time_rec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time_rec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.time_rec.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_rec.Location = new System.Drawing.Point(0, 55);
            this.time_rec.Name = "time_rec";
            this.time_rec.Size = new System.Drawing.Size(200, 33);
            this.time_rec.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.tabContr);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "My cookbook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.buttonPanel.ResumeLayout(false);
            this.tabContr.ResumeLayout(false);
            this.FavPage.ResumeLayout(false);
            this.FavPage.PerformLayout();
            this.GeneralPage.ResumeLayout(false);
            this.GeneralPage.PerformLayout();
            this.addRecPage.ResumeLayout(false);
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.helpPage.ResumeLayout(false);
            this.helpPage.PerformLayout();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.PhotoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecPhoto)).EndInit();
            this.CategoryPanel.ResumeLayout(false);
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.Button settingsB;
        private System.Windows.Forms.Button addRecB;
        private System.Windows.Forms.Button generalB;
        private System.Windows.Forms.Button favB;
        private System.Windows.Forms.Button myRecB;
        private System.Windows.Forms.Button helpB;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TabControl tabContr;
        private System.Windows.Forms.TabPage MyRecPage;
        private System.Windows.Forms.TabPage FavPage;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TabPage addRecPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.TabPage helpPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.TableLayoutPanel TitlePanel;
        private System.Windows.Forms.TextBox rec_name;
        private System.Windows.Forms.Label TitleL;
        private System.Windows.Forms.TableLayoutPanel PhotoPanel;
        private System.Windows.Forms.Label PhotoLab;
        private System.Windows.Forms.PictureBox RecPhoto;
        private System.Windows.Forms.TableLayoutPanel CategoryPanel;
        private System.Windows.Forms.Label CategoryL;
        private System.Windows.Forms.TableLayoutPanel TimePanel;
        private System.Windows.Forms.Label TimeL;
        private System.Windows.Forms.TextBox time_rec;
    }
}

