using HomeSaleManagementSystemsHelper;


namespace Home_Sale_Management_Systems
{

    public partial class FrmHomeDesign : FrmLanding
    {
        public FrmHomeDesign()
        {

            InitializeComponent();


            #region Get All Counts 
            GetSoldHomes();
            GetAllHomes();
            GetAllStaffs();
            GetAllCustomers();
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

        #region GetSoldHomes
        private void GetSoldHomes()
        {
            string rentedStoreCount = HomeDesignHelper.GetSoldHomeCount(Program.Connection);
            lblStoreRentedCount.Text = rentedStoreCount;
        }

        #endregion

        #region GetAllHomes
        private void GetAllHomes()
        {
            string allStoresCount = HomeDesignHelper.GetAllHomes(Program.Connection);
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

    }
}
