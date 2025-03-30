using Condo_Sale_Management_Systems.Dashboard;
using CondoSaleManagementSystemsHelper;


namespace Condo_Sale_Management_Systems
{

    public partial class FrmHomeDesign : FrmHome
    {
        private IDashboardComponent _dashboard;

        public Label LblContractCount 
        {
            get
            { 
                return lblContractCount; 
            }
        }

        public Label LblStaffCount
        {
            get
            {
                return lblStaffCount;
            }
        }

        public Label LblCustomerCount
        {
            get
            {
                return lblCustomerCount;
            }
        }

        public Label LblCondoSoldCount
        {
            get
            {
                return lblCondoSoldCount;
            }
        }

        public Label LblInsuranceCount
        {
            get
            {
                return lblInsuranceCount;
            }
        }

        public Label LblCondoCount
        {
            get
            {
                return lblCondoCount;
            }
        }


        public FrmHomeDesign()
        {
            InitializeComponent();

            // Create base component
            _dashboard = new BasicDashboard(this);

            // Decorate with various statistics components
            _dashboard = new CondoStatsDecorator(_dashboard, this);
            _dashboard = new StaffStatsDecorator(_dashboard, this);
            _dashboard = new CustomerStatsDecorator(_dashboard, this);
            _dashboard = new InsuranceStatsDecorator(_dashboard, this);
            _dashboard = new PurchaseStatsDecorator(_dashboard, this);

            // Update dashboard with all decorators
            _dashboard.UpdateDashboard();
        }
    }
}
