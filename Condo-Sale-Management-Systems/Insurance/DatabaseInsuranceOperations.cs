using CondoSaleManagementSystemsHelper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.Insurance
{
    public class DatabaseInsuranceOperations : IInsuranceOperations
    {
        public void LoadInsurances(DataSet dataSet, string tableName)
        {
            SqlDataAdapter adapter = CreateDataAdapter();
            adapter.TableMappings.Add("Table", tableName);
            try
            {
                adapter.Fill(dataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshInsurances(DataSet dataSet, string tableName)
        {
            dataSet.Tables[tableName]?.Clear();
            try
            {
                CreateDataAdapter().Fill(dataSet, tableName);
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertOrUpdateInsurance(DataSet dataSet, string tableName)
        {
            try
            {
                CreateDataAdapter().Update(dataSet, tableName);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddNewInsurance(BindingSource bindingSource)
        {
            try
            {
                bindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CancelChanges(DataSet dataSet, BindingSource bindingSource)
        {
            dataSet.RejectChanges();
        }

        public void FilterInsurances(BindingSource bindingSource, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                bindingSource.Filter = string.Empty;
            }
            else
            {
                bindingSource.Filter = "InsuranceName LIKE '%" + searchText + "%'";
            }
        }

        public SqlDataAdapter CreateDataAdapter()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = InsuranceHelper.CreateGetAllInsurancesCommand();
            adapter.InsertCommand = InsuranceHelper.CreateInsertInsuranceCommand();
            adapter.UpdateCommand = InsuranceHelper.CreateUpdateInsuranceCommand();
            return adapter;
        }
    }
}
