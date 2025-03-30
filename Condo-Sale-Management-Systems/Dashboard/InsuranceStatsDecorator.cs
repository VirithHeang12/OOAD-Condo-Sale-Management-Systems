using CondoSaleManagementSystemsHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.Dashboard
{
    public class InsuranceStatsDecorator : DashboardDecorator
    {
        public InsuranceStatsDecorator(IDashboardComponent component, FrmHomeDesign form) : base(component, form) { }

        public override void UpdateDashboard()
        {
            base.UpdateDashboard();
            AddInsuranceStats();
        }

        private void AddInsuranceStats()
        {
            string allInsurancesCount = HomeDesignHelper.GetAllInsurances(Program.Connection);
            homeForm.LblInsuranceCount.Text = allInsurancesCount;
        }
    }
}
