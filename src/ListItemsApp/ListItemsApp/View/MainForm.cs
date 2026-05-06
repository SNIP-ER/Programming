using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ListItemsApp
{
    public partial class MainForm : Form
    {
        private List<Items> _items = new List<Items>();
        private Items _currentItem;

        public MainForm()
        {
            InitializeComponent();

            // Изначально выбран английский язык интерфейса
            TranslateComboBox.SelectedIndex = 0;
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            Items items = new Items("Name", "Manufacturer", 10);

            _items.Add(items);
            
            NameItemsListBox.Items.Add($"{items.Name}");
        }


        private void RemButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Заполнение текстовых полей данных по выбранному товару.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NameItemsListBox.SelectedIndex != -1)
            {
                _currentItem = _items[NameItemsListBox.SelectedIndex];

                NameTextBox.Text = _currentItem.Name;
                UpdateItemsInfo(_currentItem);
            }
            else
            {
                ClearRectangleInfo();
            }
        }

        /// <summary>
        /// Обновления данных в текстовых полях по выделенному товару.ы
        /// </summary>
        /// <param name="item">Выделенный товар.</param>
        private void UpdateItemsInfo(Items item)
        {
            NameTextBox.Text = item.Name;
            ManufacturerTextBox.Text = item.Manufacturer;
            CountTextBox.Text = item.Count.ToString();
        }

        /// <summary>
        /// Очищает все текстовые поля со занчениями данных товара.
        /// </summary>
        private void ClearRectangleInfo()
        {
            NameTextBox.Text = "";
            ManufacturerTextBox.Text = "";
            CountTextBox.Text = "";
        }


        /// <summary>
        /// Выбор языка интерфейса, в зависимости от выбранного варианта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TranslateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Изменяем фокус на саму форму, чтобы убрать выделение текста
            this.ActiveControl = null;
        }

        
    }
}
