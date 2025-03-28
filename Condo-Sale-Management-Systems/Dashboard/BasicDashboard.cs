using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.Dashboard
{
    public class BasicDashboard : IDashboardComponent
    {
        protected FrmHomeDesign homeForm;

        public BasicDashboard(FrmHomeDesign form)
        {
            homeForm = form;
        }

        public virtual void UpdateDashboard()
        {
            // Basic dashboard without any stats
        }
    }
}
