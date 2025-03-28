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
        private FrmHomeDesign _form;

        public CondoStatsDecorator(IDashboardComponent component, FrmHomeDesign form) : base(component)
        {
            _form = form;
        }

        public override void UpdateDashboard()
        {
            base.UpdateDashboard();
            AddCondoStats();
        }

        private void AddCondoStats()
        {
            string soldCondoCount = HomeDesignHelper.GetSoldCondoCount(Program.Connection);
            _form.LblCondoSoldCount.Text = soldCondoCount;

            string allCondosCount = HomeDesignHelper.GetAllCondos(Program.Connection);
            _form.LblCondoCount.Text = allCondosCount;
        }
    }
}
