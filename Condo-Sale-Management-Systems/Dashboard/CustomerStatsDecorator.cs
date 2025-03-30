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
        public CustomerStatsDecorator(IDashboardComponent component, FrmHomeDesign form) : base(component, form) { }

        public override void UpdateDashboard()
        {
            base.UpdateDashboard();
            AddCustomerStats();
        }

        private void AddCustomerStats()
        {
            string allCustomersCount = HomeDesignHelper.GetAllCustomers(Program.Connection);
            homeForm.LblCustomerCount.Text = allCustomersCount;
        }
    }
}
