using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.Insurance
{
    public interface IInsuranceOperations
    {
        void LoadInsurances(DataSet dataSet, string tableName);
        void RefreshInsurances(DataSet dataSet, string tableName);
        void InsertOrUpdateInsurance(DataSet dataSet, string tableName);
        void AddNewInsurance(BindingSource bindingSource);
        void CancelChanges(DataSet dataSet, BindingSource bindingSource);
        void FilterInsurances(BindingSource bindingSource, string searchText);
        SqlDataAdapter CreateDataAdapter();
    }
}
