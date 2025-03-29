using CondoSaleManagementSystemsHelper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.CondoType
{
    public class SqlDataAdaptee
    {
        protected SqlDataAdapter Adapter { get; private set; }
        protected DataSet DataSet { get; private set; }
        protected string TableName { get; private set; }
        protected BindingSource BindingSource { get; private set; }

        public SqlDataAdaptee(string tableName)
        {
            TableName = tableName;
            DataSet = new DataSet();
            Adapter = new SqlDataAdapter();
            BindingSource = new BindingSource();

            // Set up the adapter commands
            Adapter.SelectCommand = CondoTypeHelper.CreateGetAllCondoTypesCommand();
            Adapter.InsertCommand = CondoTypeHelper.CreateInsertCondoTypeCommand();
            Adapter.UpdateCommand = CondoTypeHelper.CreateUpdateCondoTypeCommand();
        }

        public void Fill()
        {
            Adapter.TableMappings.Add("Table", TableName);
            try
            {
                Adapter.Fill(DataSet, TableName);
                BindingSource.DataSource = DataSet.Tables[TableName];
            }
            catch (Exception)
            {
                MessageBox.Show("ការទាញទិន្នន័យមិនបានសម្រេច", "ទាញទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update()
        {
            try
            {
                BindingSource.EndEdit();
                Adapter.Update(DataSet, TableName);
            }
            catch (Exception)
            {
                MessageBox.Show("ការបញ្ខូលឬកែប្រែមិនបានសម្រេច", "បញ្ខូលឬកែប្រែ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear()
        {
            DataSet.Tables[TableName]?.Clear();
        }

        public void RejectChanges()
        {
            DataSet.RejectChanges();
        }

        public bool ContainsNewRow()
        {
            DataTable? table = DataSet.Tables[TableName];
            if (table == null) return false;

            DataTable? changes = table.GetChanges(DataRowState.Added);
            return changes != null && changes.Rows.Count > 0;
        }

        public void AddNewRow()
        {
            try
            {
                BindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("ការថែមទិន្នន័យមិនបានសម្រេច", "ថែមទិន្នន័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetFilter(string filterExpression)
        {
            BindingSource.Filter = filterExpression;
        }

        public BindingSource GetBindingSource()
        {
            return BindingSource;
        }
    }

}
