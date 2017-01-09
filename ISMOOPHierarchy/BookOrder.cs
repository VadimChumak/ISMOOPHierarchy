using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class BookOrder:ICloneable , IComparable<BookOrder>
    {
        private Book book;
        public BookOrder()
        {
            book=new Book();
        }
        public int CompareTo(BookOrder b)
        {
            return this.book.CompareTo(b.book);
        }
        public object Clone()
        {
            BookOrder b = new BookOrder();
            b.book = (Book)book.Clone();
            return b;
        }

        public void Confirm(Reader r)
        {
            
            book=r.GetBook();
        }
    }
}
