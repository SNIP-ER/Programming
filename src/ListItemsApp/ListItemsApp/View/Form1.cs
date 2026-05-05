using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListItemsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TranslateComboBox.SelectedIndex = 0;
        }



        private void TranslateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Изменяем фокус на саму форму, чтобы убрать выделение текста
            this.ActiveControl = null;
        }
    }
}
