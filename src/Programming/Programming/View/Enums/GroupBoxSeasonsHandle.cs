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
                case "Spring":
                MessageBox.Show("О! Весна!", "Spring", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;

                case "Autumn":
                MessageBox.Show("Эх! Пора на учебу!", "Autumn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;

                case "Summer":
                MessageBox.Show("Ура! Каникулы!", "Summer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;

                case "Winter":
                MessageBox.Show("Зима! Скоро Новый Год!", "Winter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;
            }
        }
    }
}
