using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_AED_SO
{
    interface IDados : IEquatable<IDados> //usando interface para que qualquer objeto do tipo IDados seja comparável
    {
        bool Equals(IDados other);
        int CompareTo(IDados other);
    }
}
