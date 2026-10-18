using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();

            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Customers;
        }
    }
}
