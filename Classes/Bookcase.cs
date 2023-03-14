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

        public Bookcase(char letter, int num)
        {
            _books = new List<Book>();
            this._letter = letter;
            this._specNumber = num;

        }

        ~Bookcase()
        {
            // for future для неуправляемых
        }

        //свойства
        public int SpecNumber
        {
            get { return _specNumber; }
        }

        public char Letter
        {
            get { return _letter; }
        }

        //методы 
    }
}
