using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public interface IRbfRepository
    {
        IEnumerable<ReadBeforeFlight> Rbfs { get; }
        ReadBeforeFlight GetRbf(int rbfId);
        void Add(ReadBeforeFlight rbf);
        void Update(ReadBeforeFlight rbf);
        void Delete(ReadBeforeFlight rbf);
    }
}
