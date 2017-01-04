using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class BookOrder
    {
        private Book book;
        public BookOrder()
        {
            book=new Book();
        }
        public void Confirm(Reader r)
        {
            
            book=r.GetBook();
        }
    }
}
