using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems.CondoType
{
    public interface IValidationService
    {
        void ValidateAll();
        bool HasErrors();
        void ClearErrors();
        void RegisterValidatingHandler(Control control);
    }
}
