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
        public MainForm()
        {
            InitializeComponent();

            //Получение информации о разрешении экрана пользователя
            Width = (int)System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            //ИЗМЕНЕНИЕ ФОРМЫ-ИЗМЕНЕНИЕ РАЗМЕРОВ ДОДЕЛАЙ!
            Height = (int)System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            buttonPanel.Size = new Size((int)(Width / 4), Height);





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
