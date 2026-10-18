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

            cartsTab.Items = _store.Items;
            cartsTab.Customers = _store.Customers;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartsTab.UpdateItemsListBox();
            cartsTab.UpdateCustomersListBox();
        }
    }
}
