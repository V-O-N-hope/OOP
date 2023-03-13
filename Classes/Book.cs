

namespace WinFormsApp1.Classes
{
    internal class Book
    {
        //поля
        protected DateTime _dateOfPublishing;
        protected string _name;
        protected string _author;
        protected string _ganre;
        protected ushort _rating;

        //конструторы и деструкторы + доп при инициализации

        private void SetRate(ushort rate)
        {
            this._rating = (ushort)(rate > 100 ? 100 : rate);
            this._rating = (ushort)(rate < 0 ? 0 : rate);
        }

        public Book(DateTime date = default(DateTime), string name = "unknown name",
                    string author = "unknow author", string ganr = "unknown ganre",ushort rating = 0)
        {
            this._dateOfPublishing = date;
            this._name = name;
            this._author = author;
            this._rating = rating;
            this._ganre = ganr;
        }

        ~Book()
        {
            using (StreamWriter sw = new StreamWriter("logs.txt", append: true))
            {
                sw.WriteLine(DateTime.Now + $"{this.ToString()}");
                sw.WriteLine("We deleted book");
            }
        }

        //свойства

        public DateTime Date
        {
            get { return this._dateOfPublishing; }
            set { this._dateOfPublishing = value;}
        }

        public ushort Rate
        {
            get { return this._rating; }
            set { this._rating = value; }
        }

        public string Name
        {
            get { return this._ganre; }
            set { this._ganre = value; }
        }

        public string Author
        {
            get { return this._ganre; }
            set { this._ganre = value; }
        }

        public string Ganr
        {
            get { return this._ganre; }
            set { this._ganre = value; }
        }



        //методы

        public bool myEquality(object? obj)
        {
            if (obj == null || !(obj is Book))
            {
                return false;
            }

            Book book = (Book)obj;
            return this._name == book._name &&
                   this._name == book._name &&
                   this._name == book._name;
        }

        public override string ToString()
        {
            return "Name: " + this._name +
                "\nAuthor: " + this._author +
                "\nGanre: " + this._ganre +
                "\nDate of publishing: " + this._dateOfPublishing.ToString() +
                "\nRate: " + ((double)this._rating / 10) + " " +
                " from 10";

        }
    }
}
