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
            this.recommendB = new System.Windows.Forms.Button();
            this.favB = new System.Windows.Forms.Button();
            this.myRecB = new System.Windows.Forms.Button();
            this.helpB = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.tabContr = new System.Windows.Forms.TabControl();
            this.MyRecPage = new System.Windows.Forms.TabPage();
            this.FavPage = new System.Windows.Forms.TabPage();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.addRecPage = new System.Windows.Forms.TabPage();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.helpPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPanel.SuspendLayout();
            this.tabContr.SuspendLayout();
            this.FavPage.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            this.addRecPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
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
            this.buttonPanel.Controls.Add(this.recommendB, 0, 3);
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
            this.buttonPanel.Size = new System.Drawing.Size(423, 733);
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
            this.settingsB.Size = new System.Drawing.Size(423, 86);
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
            this.addRecB.Size = new System.Drawing.Size(423, 86);
            this.addRecB.TabIndex = 4;
            this.addRecB.Text = "Добавить рецепт";
            this.addRecB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addRecB.UseVisualStyleBackColor = false;
            this.addRecB.Click += new System.EventHandler(this.addRecB_Click);
            // 
            // recommendB
            // 
            this.recommendB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recommendB.FlatAppearance.BorderSize = 0;
            this.recommendB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recommendB.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recommendB.Image = ((System.Drawing.Image)(resources.GetObject("recommendB.Image")));
            this.recommendB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.recommendB.Location = new System.Drawing.Point(0, 219);
            this.recommendB.Margin = new System.Windows.Forms.Padding(0);
            this.recommendB.Name = "recommendB";
            this.recommendB.Size = new System.Drawing.Size(423, 86);
            this.recommendB.TabIndex = 3;
            this.recommendB.Text = "Общие рецепты";
            this.recommendB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.recommendB.UseVisualStyleBackColor = true;
            this.recommendB.Click += new System.EventHandler(this.recommendB_Click);
            // 
            // favB
            // 
            this.favB.BackColor = System.Drawing.Color.White;
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
            this.favB.Size = new System.Drawing.Size(423, 86);
            this.favB.TabIndex = 2;
            this.favB.Text = "Избранные рецепты";
            this.favB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.favB.UseVisualStyleBackColor = false;
            this.favB.Click += new System.EventHandler(this.favB_Click);
            // 
            // myRecB
            // 
            this.myRecB.BackColor = System.Drawing.Color.White;
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
            this.myRecB.Size = new System.Drawing.Size(423, 86);
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
            this.helpB.Size = new System.Drawing.Size(423, 86);
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
            // addRecPage
            // 
            this.addRecPage.Controls.Add(this.label3);
            this.addRecPage.Location = new System.Drawing.Point(4, 30);
            this.addRecPage.Name = "addRecPage";
            this.addRecPage.Size = new System.Drawing.Size(1021, 652);
            this.addRecPage.TabIndex = 3;
            this.addRecPage.Text = "Добавить";
            this.addRecPage.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
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
            this.buttonPanel.ResumeLayout(false);
            this.tabContr.ResumeLayout(false);
            this.FavPage.ResumeLayout(false);
            this.FavPage.PerformLayout();
            this.GeneralPage.ResumeLayout(false);
            this.GeneralPage.PerformLayout();
            this.addRecPage.ResumeLayout(false);
            this.addRecPage.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.helpPage.ResumeLayout(false);
            this.helpPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.Button settingsB;
        private System.Windows.Forms.Button addRecB;
        private System.Windows.Forms.Button recommendB;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

