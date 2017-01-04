using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    interface IMoney
    {
        bool AddMoney(double sum);
        bool GetMoney(double sum);
        void ResetMoney();
    }
}
