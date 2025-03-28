using CondoSaleManagementSystemsHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.Dashboard
{
    public class CustomerStatsDecorator : DashboardDecorator
    {
        private FrmHomeDesign _form;

        public CustomerStatsDecorator(IDashboardComponent component, FrmHomeDesign form) : base(component)
        {
            _form = form;
        }

        public override void UpdateDashboard()
        {
            base.UpdateDashboard();
            AddCustomerStats();
        }

        private void AddCustomerStats()
        {
            string allCustomersCount = HomeDesignHelper.GetAllCustomers(Program.Connection);
            _form.LblCustomerCount.Text = allCustomersCount;
        }
    }
}
