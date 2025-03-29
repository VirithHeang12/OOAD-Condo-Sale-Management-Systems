using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.CondoType
{
    public interface ICondoTypeDataService
    {
        void LoadData();
        void SaveData();
        void RefreshData();
        void CancelChanges();
        void AddNew();
        void ApplyFilter(string searchText);
        BindingSource GetBindingSource();
        bool ContainsNewRow();
    }
}
