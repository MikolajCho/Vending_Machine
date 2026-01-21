using System;

namespace Automaty_z_napojami
{
    public class ObiektSystemowy
    {
        public DateTime DataUtworzeniaObiektu { get; set; } = DateTime.Now;
    }

    public class Produkt : ObiektSystemowy
    {
        public int Id;
        public string Nazwa = "";
        public decimal Cena;
    }

    public class Napoj : Produkt
    {
        public int Pojemnosc;
        public string Kategoria = "";
    }

    public class NapojGazowany : Napoj
    {

    }

    public class NapojNiegazowany : Napoj
    {

    }
}
