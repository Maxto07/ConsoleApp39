using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochód auto1 = new Samochód("Mazda", 5000);
            Samochód auto2 = new Samochód("audi", 6000, "czarny", new DateTime(2000, 05, 12));

            auto2.kolorh("czerwony");
            auto1.predkosc(70);
            Console.WriteLine(auto1.Prędkość + " samochud przyspieszył o 70km/h");
            auto1.predkosc(70);
            Console.WriteLine(auto1.Prędkość + " samochud przyspieszył o 70km/h");
            auto1.predkosc(70);
            Console.WriteLine(auto1.Prędkość + " samochud przyspieszył o 70km/h");
            auto1.predkosc(70);
            Console.WriteLine(auto1.Prędkość + " samochud przyspieszył o 70km/h");
            if (auto1.Prędkość >= 250)
            {
                Console.WriteLine(auto1.Prędkość + " Jedziesz za szybko");
            }

            Samochód auto3 = new Samochód("Audi", "niebieski", new DateTime(2010, 05, 12));
            auto3.kolorh("biały");
            auto3.predkosc(100);
            Console.WriteLine(auto3.Prędkość + " samochud przyspieszył o 100km/h");
            auto3.predkosc(100);
            Console.WriteLine(auto3.Prędkość + " samochud przyspieszył o 100km/h");
            auto3.predkosc(100);
            Console.WriteLine(auto3.Prędkość + " samochud przyspieszył o 100km/h");
            if (auto3.Prędkość >= 300)
            {
                Console.WriteLine(auto3.Prędkość + " Jedziesz za szybko");
            }
            
        }
    }
    class Samochód
    {
        public string Marka;
        public string kolor;
        public int cena;
        public int Prędkość;
        public DateTime datapr;

        public Samochód(string Marka, int cena)
        {
            Marka = Marka1;

        }
        public Samochód(string Marka, int cena, string kolor, DateTime datapr)
        {
            

        }
        public Samochód(string Marka,  string kolor, DateTime datapr)
        {

        }
        public void markah(string Marka1)
        public void kolorh(String klor)
        {
            kolor = klor;
        }
        public void predkosc(int prędkość)
        {

            Prędkość = prędkość + Prędkość;
                

        }
        

    }
}
