using System;

namespace lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Ulamek
    {
        private int licznik;
        public int Licznik
        {
            get
            {
                return licznik;
            }
            set { }
        }

        private int mianownik;
        public int Mianownik
        {
            get
            {
                return mianownik;
            }
            set { }
        }

        //private strin;
        public Ulamek()
        {
            //  this.domyslny = "";

            this.licznik = 0;
            this.mianownik = 1;
        }

        public Ulamek (int a, int b)
        {
            this.Licznik = a;
            this.Mianownik = b;
        }

        public Ulamek (Ulamek c)
        {
            this.licznik = c.licznik;
            this.mianownik = c.mianownik;
        }

    }

}
