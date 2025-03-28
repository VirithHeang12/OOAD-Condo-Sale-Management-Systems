using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.Dashboard
{
    public abstract class DashboardDecorator : IDashboardComponent
    {
        protected IDashboardComponent _component;

        public DashboardDecorator(IDashboardComponent component)
        {
            _component = component;
        }

        public virtual void UpdateDashboard()
        {
            _component.UpdateDashboard();
        }
    }
}
