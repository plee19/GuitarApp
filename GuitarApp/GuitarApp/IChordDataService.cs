using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp
{
    public interface IChordDataService
    {
        Task<RootObject> GetChord(string chord);
    }
}
