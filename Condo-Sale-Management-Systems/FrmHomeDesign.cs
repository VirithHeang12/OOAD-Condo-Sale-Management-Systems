using StoreRentalHelper;


namespace Condo_Sale_Management_Systems
{

    public partial class FrmHomeDesign : FrmHome
    {
        public FrmHomeDesign()
        {

            InitializeComponent();


            #region Get All Counts 
            GetRentedStores();
            GetAllStores();
            GetAllStaffs();
            GetAllCustomers();
            GetAllInsurances();
            GetAllContracts();
            #endregion

        }

        #region GetAllContracts
        private void GetAllContracts()
        {
            string contractCount = HomeDesignHelper.GetAllContracts(Program.Connection);
            lblCountContract.Text = contractCount;
        }

        #endregion

        #region GetRentedStores
        private void GetRentedStores()
        {
            string rentedStoreCount = HomeDesignHelper.GetRentedStoreCount(Program.Connection);
            lblStoreRentedCount.Text = rentedStoreCount;
        }

        #endregion

        #region GetAllStores
        private void GetAllStores()
        {
            string allStoresCount = HomeDesignHelper.GetAllStores(Program.Connection);
            lblStoreCount.Text = allStoresCount;
        }
        #endregion

        #region GetAllStaffs
        private void GetAllStaffs()
        {
            string allStaffsCount = HomeDesignHelper.GetAllStaffs(Program.Connection);
            label7.Text = allStaffsCount;
        }
        #endregion

        #region GetAllCustomers
        private void GetAllCustomers()
        {
            string allCustomersCount = HomeDesignHelper.GetAllCustomers(Program.Connection);
            label9.Text = allCustomersCount;
        }
        #endregion

        #region GetAllInsurances
        private void GetAllInsurances()
        {
            string allCustomersCount = HomeDesignHelper.GetAllInsurances(Program.Connection);
            label11.Text = allCustomersCount;
        }
        #endregion
    }
}
