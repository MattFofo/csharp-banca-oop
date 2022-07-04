using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public interface IInterest
    {
        public int InteressiSulTot { get; set; }
        public int CalculateInterest();

    }
}
