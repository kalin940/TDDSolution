using System.Collections.Generic;

namespace TDDSolution
{
    public interface IChartsService
    {
        void Notify(CD cd);

        IEnumerable<CD> Top100 { get; set; } 
    }
}