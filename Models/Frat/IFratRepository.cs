using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public interface IFratRepository
    {
        IEnumerable<Frat> Frats { get; }
        IEnumerable<StaticFrat> StaticFrats {get;}
        Frat GetFratById(int Id);
        StaticFrat GetStaticFratById(int Id);

        void Add(Frat frat);
        void Update(Frat frat);
        void Delete(Frat frat);

        void Add(StaticFrat staticFrat);
        void Update(StaticFrat staticFrat);
        void Delete(StaticFrat staticFrat);
    }
}
