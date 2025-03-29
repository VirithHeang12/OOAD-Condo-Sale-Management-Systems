using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.CondoType
{
    public class CondoTypeDataAdapter : SqlDataAdaptee, ICondoTypeDataService
    {
        public CondoTypeDataAdapter(string tableName) : base(tableName) { }

        // ICondoTypeDataService implementation
        public void LoadData()
        {
            // Call the Adaptee's specific method
            Fill();
        }

        public void SaveData()
        {
            // Call the Adaptee's specific method
            Update();
        }

        public void RefreshData()
        {
            Clear();
            Fill();
        }

        public void CancelChanges()
        {
            RejectChanges();
            RefreshData();
        }

        public void AddNew()
        {
            AddNewRow();
        }

        public void ApplyFilter(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                SetFilter(string.Empty);
            }
            else
            {
                SetFilter("CondoTypeDescription LIKE '%" + searchText + "%'");
            }
        }

        // We're inheriting GetBindingSource() and ContainsNewRow() from the Adaptee
    }

}
