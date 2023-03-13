using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Classes
{
    internal class Bookcase
    {
        public List<Book> _books;
        private char _letter;
        private int _specNumber;


        //конструктор + декструтор 

        public Bookcase()
        {
            
        }

        ~Bookcase ()
        {
            using (StreamWriter sw = new StreamWriter("logs.txt", append: true))
            {
                
            }
        }

        //свойства
        public int SpecNumber
        {
            get { return _specNumber; }
            set { _specNumber = value; }
        }

        public char Letter
        {
            get { return _letter; }
        }

        //методы 
    }
}
