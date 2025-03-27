using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo_Sale_Management_Systems
{
    public interface IForm
    {
        Form UnderlyingForm { get; }
        void Initialize();
        void Show();
        void Hide();
    }
}
