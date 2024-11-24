using CondoSaleManagementSystemsHelper;


namespace Condo_Sale_Management_Systems
{

    public partial class FrmHomeDesign : FrmHome
    {
        public FrmHomeDesign()
        {

            InitializeComponent();


            #region Get All Counts 
            GetSoldCondos();
            GetAllCondos();
            GetAllStaffs();
            GetAllCustomers();
            GetAllInsurances();
            GetAllPurchases();
            #endregion

        }

        #region GetAllPurchases
        private void GetAllPurchases()
        {
            string contractCount = HomeDesignHelper.GetAllPurchases(Program.Connection);
            lblCountContract.Text = contractCount;
        }

        #endregion

        #region GetSoldCondos
        private void GetSoldCondos()
        {
            string rentedStoreCount = HomeDesignHelper.GetSoldCondoCount(Program.Connection);
            lblStoreRentedCount.Text = rentedStoreCount;
        }

        #endregion

        #region GetAllCondos
        private void GetAllCondos()
        {
            string allStoresCount = HomeDesignHelper.GetAllCondos(Program.Connection);
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
