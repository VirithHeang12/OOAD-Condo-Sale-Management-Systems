using CondoSaleManagementSystemsHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.Dashboard
{
    public class CondoStatsDecorator : DashboardDecorator
    {
        public CondoStatsDecorator(IDashboardComponent component, FrmHomeDesign form) : base(component, form) { }

        public override void UpdateDashboard()
        {
            base.UpdateDashboard();
            AddCondoStats();
        }

        private void AddCondoStats()
        {
            string soldCondoCount = HomeDesignHelper.GetSoldCondoCount(Program.Connection);
            homeForm.LblCondoSoldCount.Text = soldCondoCount;

            string allCondosCount = HomeDesignHelper.GetAllCondos(Program.Connection);
            homeForm.LblCondoCount.Text = allCondosCount;
        }
    }
}
