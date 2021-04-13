using System;
using System.Collections.Generic;
using System.Text;

namespace TDDSolution
{
    public interface IPaymentProvider
    {
        bool ApprovePayment();
    }
}
