using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private BindingList<Item> _items = new BindingList<Item>();
        private Item _currentItem;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value ?? new BindingList<Item>();
                listBoxItems.DataSource = _items;
            }
        }


        public ItemsTab()
        {
            InitializeComponent();

            comboBoxSelectedItemCategory.Items.AddRange(Enum.GetNames(typeof(Category)));
            listBoxItems.DataSource = _items;
        }


        /// <summary>
        /// Добавление новой карточки товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemsAdd_Click(object sender, EventArgs e)
        {
            _items.Add(new Item("Name", "Info", 0, Category.none));
        }

        /// <summary>
        /// Удаление выбраной карточки товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemsRemove_Click(object sender, EventArgs e)
        {
            Item item = listBoxItems.SelectedItem as Item;

            if (item != null)
            {
                _items.Remove(item);
            }
        }

        /// <summary>
        /// Добвление случайного товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemsRandom_Click(object sender, EventArgs e)
        {
            _items.Add(ItemFactory.Randomize());
        }

        /// <summary>
        /// Заполнение полей выбранной карточки товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentItem = listBoxItems.SelectedItem as Item;

            if (_currentItem != null)
            {
                UpdateItemInfo(_currentItem);
            }
            else
            {
                ClearItemInfo();
            }
        }

        /// <summary>
        /// Обновить текст о товаре.
        /// </summary>
        /// <param name="item">Выбранный товар.</param>
        private void UpdateItemInfo(Item item)
        {
            textBoxSelectedItemId.Text = item.Id.ToString();
            textBoxSelectedItemCost.Text = item.Cost.ToString();
            textBoxSelectedItemName.Text = item.Name;
            textBoxSelectedItemDescription.Text = item.Info;
            comboBoxSelectedItemCategory.SelectedIndex = (int)item.Category;
        }

        /// <summary>
        /// Очистить поля с информацией о товаре.
        /// </summary>
        private void ClearItemInfo()
        {
            textBoxSelectedItemId.Text = "";
            textBoxSelectedItemCost.Text = "";
            textBoxSelectedItemName.Text = "";
            textBoxSelectedItemDescription.Text = "";
            comboBoxSelectedItemCategory.SelectedIndex = -1;
        }

        /// <summary>
        /// Сохранение изменений в строке с ценой.
        /// </summary>
        private void textBoxSelectedItemCost_Leave(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите товар!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!float.TryParse(textBoxSelectedItemCost.Text, out float newCost))
            {
                textBoxSelectedItemCost.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Можно вводить только цифры и , !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValueValidator.AssertFloatOnSize(newCost, 100000, "bool"))
            {
                _currentItem.Cost = newCost;
                _items.ResetItem(listBoxItems.SelectedIndex);
                textBoxSelectedItemCost.BackColor = Color.White;
            }
            else
            {
                textBoxSelectedItemCost.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Число не должно быть отрицательным и больше 100000 !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение названия.
        /// </summary>
        private void textBoxSelectedItemName_Leave(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите товар!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValueValidator.AssertStringOnLength(textBoxSelectedItemName.Text, 200, "bool"))
            {
                _currentItem.Name = textBoxSelectedItemName.Text;
                _items.ResetItem(listBoxItems.SelectedIndex);
                textBoxSelectedItemName.BackColor = Color.White;
            }
            else
            {
                textBoxSelectedItemName.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Поле не должно быть пустым и больше 200 символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение описания.
        /// </summary>
        private void textBoxSelectedItemDescription_Leave(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите товар!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValueValidator.AssertStringOnLength(textBoxSelectedItemDescription.Text, 1000, "bool"))
            {
                _currentItem.Info = textBoxSelectedItemDescription.Text;
                _items.ResetItem(listBoxItems.SelectedIndex);
                textBoxSelectedItemDescription.BackColor = Color.White;
            }
            else
            {
                textBoxSelectedItemDescription.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Поле не должно быть пустым и больше 1000 символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение выбранной категории.
        /// </summary>
        private void comboBoxSelectedItemCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите товар!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _currentItem.Category = (Category)comboBoxSelectedItemCategory.SelectedIndex;
            }
        }
    }
}
