using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_practic
{
    interface IXob
    {
        double X { get; set; }
        double Y { get; set; }
        double CompareTo(object obj);
    }
}
