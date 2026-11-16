namespace ObjectOrientedPractics.View
{
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Выбранная категория (после закрытия формы с результатом OK).
        /// </summary>
        public Category SelectedCategory
        {
            get
            {
                return (Category)comboBoxCategory.SelectedItem;
            }
        }

        public AddDiscountForm()
        {
            InitializeComponent();

            comboBoxCategory.DataSource = Enum.GetValues(typeof(Category));
        }
    }
}
