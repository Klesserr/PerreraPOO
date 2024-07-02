using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerreraPOO
{
    class Dog : Animal
    {
        public int Energy { get; set; }
        public StatusAnimal IsAdopted { get; set; }
        public string IdDog { get; set; }
        public Dog(string name, string race, int year, string behaviour, int energy,double weight, StatusAnimal isAdopted, string idDog) : base(name, race, year, behaviour, weight)
        {
            if (energy >= 5)
            {
                Energy = 5;
            }
            else
            {
                Energy = energy;
            }
            IsAdopted = isAdopted;
            IdDog = idDog;
        }


        /*Sleep: Genera 2 puntos de energia a nuestro perro.*/
        public void Sleep()
        {
            Energy += 2;
        }
        /*Play: Quitamos 2 puntos de energia a nuestro perro*/
        public void Play()
        {
            Energy -= 2;
        }
        /*Bark: Quitamos 1 punto de energia por ladrar.*/
        public void Bark()
        {
            Energy--;
            Console.WriteLine($"El perro está agitado y está ladrando, esto consume su energia");
        }

        public override string GetInformation()
        {
            return $"Animal Perro: "+base.GetInformation() +
                $"Energia: {Energy} \n" +
                $"Adoptado? {IsAdopted}";   
        }
    }
}
