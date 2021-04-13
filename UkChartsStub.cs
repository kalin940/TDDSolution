using System;
using System.Collections.Generic;
using System.Text;

namespace TDDSolution
{
    public class UkChartsStub : IChartsService
    {
        public IEnumerable<CD> Top100 { get; set; }

        public void Notify(CD cd)
        {
          
        }
    }
}
