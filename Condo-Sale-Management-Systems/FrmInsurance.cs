using Microsoft.Data.SqlClient;
using CondoSaleManagementSystemsHelper;
using System.ComponentModel;
using System.Data;
using Condo_Sale_Management_Systems.Insurance;



namespace Condo_Sale_Management_Systems
{
    public partial class FrmInsurance : FrmHome
    {
        private InsuranceFormAbstraction _formImplementation;

        public DataGridView DgvInsurances => dgvInsurances;
        public TextBox TxtInsuranceID => txtInsuranceID;
        public TextBox TxtInsuranceName => txtInsuranceName;
        public TextBox TxtInsuranceWebsite => txtInsuranceWebsite;
        public Button BtnNewInsurance => btnNewInsurance;
        public Button BtnInsertInsurance => btnInsertInsurance;
        public Button BtnUpdateInsurance => btnUpdateInsurance;
        public Button BtnCancelInsurance => btnCancelInsurance;
        public TextBox TxtSearchInsurance => txtSearchInsurance;


        public FrmInsurance() : base()
        {
            InitializeComponent();

            // Create the bridge
            IInsuranceOperations operations = new DatabaseInsuranceOperations();
            _formImplementation = new InsuranceFormImplementation(
                operations,
                this,
                new List<Control> { txtInsuranceName, txtInsuranceWebsite });

            _formImplementation.Initialize();
        }
    }
}
