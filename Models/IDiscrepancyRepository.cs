using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public interface IDiscrepancyRepository
    {
        IEnumerable<Discrepancy> Discrepancies { get; }
        Discrepancy GetDiscrepancy(int Id);
        void Add(Discrepancy discrepancy);
        void Update(Discrepancy discrepancy);
        void Delete(Discrepancy discrepancy);

    }
}
