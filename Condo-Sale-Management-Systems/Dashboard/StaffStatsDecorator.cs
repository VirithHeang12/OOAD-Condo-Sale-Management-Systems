using CondoSaleManagementSystemsHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.Dashboard
{
    public class StaffStatsDecorator : DashboardDecorator
    {
        public StaffStatsDecorator(IDashboardComponent component, FrmHomeDesign form) : base(component, form) { }

        public override void UpdateDashboard()
        {
            base.UpdateDashboard();
            AddStaffStats();
        }

        private void AddStaffStats()
        {
            string allStaffsCount = HomeDesignHelper.GetAllStaffs(Program.Connection);
            homeForm.LblStaffCount.Text = allStaffsCount;
        }
    }
}
