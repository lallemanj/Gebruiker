using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStapelOef1
{
    internal class KleineKlasse
    {
        public static int Id { get; set; }

        public string Name { get; set; }

        public static int teller = 0;

        public KleineKlasse(int id, string name)
        {
            Id = id;
            Id = teller;
            teller++;
            Name = name;
            
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Name: " + Name;
        }

    }
}
