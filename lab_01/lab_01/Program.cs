using System;

namespace lab_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Ulamek());
            Console.WriteLine();
        }
    }
    public class Ulamek
    {
        //private int licznik;
        // public int Licznik
        // {
        //     get
        //     {
        //         return licznik;
        //     }
        //     set { }
        // }

        private int licznik;
        public Licznik(int licznik)
        {
            this.licznik = licznik;
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

        public Ulamek()
        {
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
        public override string ToString()
        {
            return ;
                //Tuple.Create( , );
        }
    }




}
//https://dirask.com/posts/WSEI-2021-2022-lato-labN-1-ISN-Programowanie-obiektowe-lab-1-pa3ek1
