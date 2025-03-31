using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.Insurance
{
    public abstract class InsuranceFormAbstraction
    {
        protected readonly IInsuranceOperations operations;
        protected const string TABLE_NAME = "tblInsurance";
        protected DataSet _dataSet = new();
        protected BindingSource _bindingSource = new();
        protected ErrorProvider _errorProvider = new();
        protected List<Control> _validatingControls = new();

        protected InsuranceFormAbstraction(IInsuranceOperations operations)
        {
            this.operations = operations;
        }

        public virtual void LoadAllInsurances()
        {
            operations.LoadInsurances(_dataSet, TABLE_NAME);
        }

        public virtual void RefreshDataGridView()
        {
            operations.RefreshInsurances(_dataSet, TABLE_NAME);
        }

        public virtual void HandleInsertOrUpdate()
        {
            _bindingSource.EndEdit();
            operations.InsertOrUpdateInsurance(_dataSet, TABLE_NAME);
            _bindingSource.ResetBindings(false);
            RefreshDataGridView();
        }

        public virtual void HandleNewRecord()
        {
            operations.AddNewInsurance(_bindingSource);
        }

        public virtual void HandleCancel()
        {
            _errorProvider.Clear();
            operations.CancelChanges(_dataSet, _bindingSource);
            RefreshDataGridView();
        }

        public virtual void HandleSearch(string searchText)
        {
            operations.FilterInsurances(_bindingSource, searchText);
        }

        public abstract void BindWithControls();
        public abstract void SetupValidation();
        public abstract void RegisterEvents();
        public abstract void Initialize();  
    }
}
