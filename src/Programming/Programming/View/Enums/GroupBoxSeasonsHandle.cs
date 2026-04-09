using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Enums
{
    public partial class GroupBoxSeasonsHandle : UserControl
    {
        public GroupBoxSeasonsHandle()
        {
            InitializeComponent();

            SeasonComboBox.SelectedIndex = 0;  // Изначально выбран 1-ый элемент в SeasonComboBox.
        }

        /// <summary>
        /// Кастомизация окна программы в зависимости от выбраного времени года.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.Text)
            {
                case "Default":
                this.BackColor = ColorTranslator.FromHtml("#f0f0f0");
                SeasonComboBox.BackColor = ColorTranslator.FromHtml("#fff");
                SeasonButton.BackColor = ColorTranslator.FromHtml("#e1e1e1");
                break;

                case "Spring":
                this.BackColor = ColorTranslator.FromHtml("#559c45");
                SeasonComboBox.BackColor = ColorTranslator.FromHtml("#b1e3a6");
                SeasonButton.BackColor = ColorTranslator.FromHtml("#dce87d");
                break;

                case "Autumn":
                this.BackColor = ColorTranslator.FromHtml("#e29c45");
                SeasonComboBox.BackColor = ColorTranslator.FromHtml("#e3b781");
                SeasonButton.BackColor = ColorTranslator.FromHtml("#d68594");
                break;

                case "Summer":
                MessageBox.Show("Ура! Лето!", "Summer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;

                case "Winter":
                MessageBox.Show("Зима! Скоро Новый Год!", "Winter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;
            }
        }
    }
}
