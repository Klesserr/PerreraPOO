using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerreraPOO
{
    class Animal
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public int Year {  get; set; }
        public string Behaviour { get; set; } //Comportamiento

        public double Weight { get; set; }
        public Animal (string name,string race,int year,string behaviour,double weight)
        {
            Name = name;
            Race = race;
            Year = year;
            Behaviour = behaviour;
            Weight = weight;
        }

        public virtual string GetInformation()
        {
            return $"Información \n" +
                $"Nombre: {Name}\n" +
                $"Edad: {Year}\n" +
                $"Raza: {Race}\n" +
                $"Peso: {Weight}\n" +
                $"Comportamiento: {Behaviour}\n";
        }

    }
    public enum StatusAnimal { Adoptado, NoAdoptado};
}
