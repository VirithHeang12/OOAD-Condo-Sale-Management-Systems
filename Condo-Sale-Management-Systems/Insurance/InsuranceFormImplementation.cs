using CondoSaleManagementSystemsHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.Insurance
{
    public class InsuranceFormImplementation : InsuranceFormAbstraction
    {
        private readonly FrmInsurance _form;

        public InsuranceFormImplementation(
            IInsuranceOperations operations,
            FrmInsurance form,
            List<Control> validatingControls) : base(operations)
        {
            _form = form;
            _validatingControls = validatingControls;
            _errorProvider.ContainerControl = _form;
        }

        public void Initialize()
        {
            LoadAllInsurances();
            BindWithControls();
            SetupValidation();
            RegisterEvents();
        }

        public override void BindWithControls()
        {
            _bindingSource.DataSource = _dataSet.Tables[TABLE_NAME];
            _form.DgvInsurances.DataSource = _bindingSource;

            _form.TxtInsuranceID.DataBindings.Add(new Binding("Text", _bindingSource, "InsuranceID"));
            _form.TxtInsuranceName.DataBindings.Add(new Binding("Text", _bindingSource, "InsuranceName"));
            _form.TxtInsuranceWebsite.DataBindings.Add(new Binding("Text", _bindingSource, "InsuranceWebsite"));
        }

        public override void SetupValidation()
        {
            // Validation setup is handled in RegisterEvents
        }

        public override void RegisterEvents()
        {
            _form.BtnNewInsurance.Click += (s, e) => HandleNewRecord();
            _form.BtnInsertInsurance.Click += (s, e) => HandleInsertClicked();
            _form.BtnUpdateInsurance.Click += (s, e) => HandleInsertClicked();
            _form.BtnCancelInsurance.Click += (s, e) => HandleCancel();

            _form.TxtInsuranceName.Validating += ValidateTextBox;
            _form.TxtInsuranceWebsite.Validating += ValidateTextBox;

            _form.DgvInsurances.SelectionChanged += HandleSelectionChanged;
            _form.TxtSearchInsurance.TextChanged += (s, e) =>
                HandleSearch(_form.TxtSearchInsurance.Text.Trim().ToLower());

            // Keyboard layout handlers
            _form.TxtInsuranceName.GotFocus += (s, e) => KeyboardLayoutHelper.SwitchToEnglishKeyboard();
            _form.TxtInsuranceWebsite.GotFocus += (s, e) => KeyboardLayoutHelper.SwitchToEnglishKeyboard();
            _form.TxtSearchInsurance.GotFocus += (s, e) => KeyboardLayoutHelper.SwitchToEnglishKeyboard();
        }

        private void HandleInsertClicked()
        {
            CauseValidation();
            if (HasErrors()) return;
            HandleInsertOrUpdate();
        }

        private void CauseValidation()
        {
            foreach (var control in _validatingControls)
            {
                ErrorHelper.ValidateTextBox((control as TextBox)!, _errorProvider);
            }
        }

        private bool HasErrors()
        {
            return ErrorHelper.HasErrors(_validatingControls, _errorProvider);
        }

        private void ValidateTextBox(object? sender, CancelEventArgs e)
        {
            ErrorHelper.ValidateTextBox((sender as TextBox)!, _errorProvider);
        }

        private void HandleSelectionChanged(object? sender, EventArgs e)
        {
            if (ContainsNewRow(_dataSet.Tables[TABLE_NAME]!))
            {
                _form.BtnCancelInsurance.PerformClick();
            }
        }

        private bool ContainsNewRow(DataTable table)
        {
            DataTable? changes = table.GetChanges(DataRowState.Added);
            return changes != null && changes.Rows.Count > 0;
        }
    }
}
