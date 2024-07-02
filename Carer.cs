using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerreraPOO
{
    class Carer : Employee //Cuidador
    {
        public Carer(string idEmployee, string name) : base(idEmployee, name)
        {

        }
        /*FeedDog: Método que se encarga de darle de comer al perro según su peso y edad.
          Esto hará que le demos más energia y peso según lo necesite.*/
        public void FeedDog(Dog dog)
        {
            if (dog.Weight < 5 && dog.Year < 3)
            {
                Console.WriteLine($"Su perro necesita comer, tiene muy poco peso.Esto aumenta su peso y energia");
                dog.Energy = dog.Energy + 2;
                dog.Weight = dog.Weight + 2;
            }
            else if (dog.Weight >= 5 && dog.Weight < 10 && dog.Year >=5)
            {
                Console.WriteLine($"Le daremos un poco de comida a su perro");
                dog.Energy++; dog.Weight++;
            }
            else
            {
                Console.WriteLine($"Alimentaremos muy poco a su mascota ya que, se encuentra en el peso ideal");
            }
        }
        /*WalkDog: Este método da un paseo con el perro y nos informa de que la energia decrece.*/
        public void WalkDog(Dog dog)
        {
            Console.WriteLine($"Dar un paseo tan largo cansa mucho al animal, y su energia va decreciendo");
            dog.Energy -= 3;
        }
        public override string GetInfoEmployee()
        {
            return base.GetInfoEmployee() + $"\nCuidador de mascotas";
        }
    }
}
