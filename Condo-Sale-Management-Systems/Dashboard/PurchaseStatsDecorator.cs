﻿using CondoSaleManagementSystemsHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.Dashboard
{
    public class PurchaseStatsDecorator : DashboardDecorator
    {
        public PurchaseStatsDecorator(IDashboardComponent component, FrmHomeDesign form) : base(component, form) { }

        public override void UpdateDashboard()
        {
            base.UpdateDashboard();
            AddPurchaseStats();
        }

        private void AddPurchaseStats()
        {
            string contractCount = HomeDesignHelper.GetAllPurchases(Program.Connection);
            homeForm.LblContractCount.Text = contractCount;
        }
    }
}
