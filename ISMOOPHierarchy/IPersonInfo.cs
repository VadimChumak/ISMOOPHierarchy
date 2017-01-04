using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    interface IPersonInfo
    {
        string Name
        {
            set;
            get;
        }
        string Lastname
        {
            set;
            get;
        }
        void ShowInfo();
    }
}
