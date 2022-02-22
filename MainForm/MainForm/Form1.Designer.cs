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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.mainB = new System.Windows.Forms.Button();
            this.favB = new System.Windows.Forms.Button();
            this.addRecB = new System.Windows.Forms.Button();
            this.settingsB = new System.Windows.Forms.Button();
            this.helpB = new System.Windows.Forms.Button();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 1;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonPanel.Controls.Add(this.helpB, 0, 5);
            this.buttonPanel.Controls.Add(this.settingsB, 0, 4);
            this.buttonPanel.Controls.Add(this.addRecB, 0, 3);
            this.buttonPanel.Controls.Add(this.favB, 0, 2);
            this.buttonPanel.Controls.Add(this.Logo, 0, 0);
            this.buttonPanel.Controls.Add(this.mainB, 0, 1);
            this.buttonPanel.Location = new System.Drawing.Point(-5, -2);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 7;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.buttonPanel.Size = new System.Drawing.Size(468, 733);
            this.buttonPanel.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo.Location = new System.Drawing.Point(5, 5);
            this.Logo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(458, 152);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // mainB
            // 
            this.mainB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainB.Location = new System.Drawing.Point(0, 162);
            this.mainB.Margin = new System.Windows.Forms.Padding(0);
            this.mainB.Name = "mainB";
            this.mainB.Size = new System.Drawing.Size(468, 81);
            this.mainB.TabIndex = 1;
            this.mainB.Text = "Главная";
            this.mainB.UseVisualStyleBackColor = true;
            // 
            // favB
            // 
            this.favB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favB.Location = new System.Drawing.Point(0, 243);
            this.favB.Margin = new System.Windows.Forms.Padding(0);
            this.favB.Name = "favB";
            this.favB.Size = new System.Drawing.Size(468, 81);
            this.favB.TabIndex = 2;
            this.favB.Text = "Избранное";
            this.favB.UseVisualStyleBackColor = true;
            // 
            // addRecB
            // 
            this.addRecB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRecB.Location = new System.Drawing.Point(0, 324);
            this.addRecB.Margin = new System.Windows.Forms.Padding(0);
            this.addRecB.Name = "addRecB";
            this.addRecB.Size = new System.Drawing.Size(468, 81);
            this.addRecB.TabIndex = 3;
            this.addRecB.Text = "Добавить рецепт";
            this.addRecB.UseVisualStyleBackColor = true;
            // 
            // settingsB
            // 
            this.settingsB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsB.Location = new System.Drawing.Point(0, 405);
            this.settingsB.Margin = new System.Windows.Forms.Padding(0);
            this.settingsB.Name = "settingsB";
            this.settingsB.Size = new System.Drawing.Size(468, 81);
            this.settingsB.TabIndex = 4;
            this.settingsB.Text = "Настройки";
            this.settingsB.UseVisualStyleBackColor = true;
            // 
            // helpB
            // 
            this.helpB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpB.Location = new System.Drawing.Point(0, 486);
            this.helpB.Margin = new System.Windows.Forms.Padding(0);
            this.helpB.Name = "helpB";
            this.helpB.Size = new System.Drawing.Size(468, 81);
            this.helpB.TabIndex = 5;
            this.helpB.Text = "Помощь";
            this.helpB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.buttonPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainForm";
            this.Text = "My cookbook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.Button helpB;
        private System.Windows.Forms.Button settingsB;
        private System.Windows.Forms.Button addRecB;
        private System.Windows.Forms.Button favB;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button mainB;
    }
}

