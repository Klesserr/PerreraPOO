using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerreraPOO
{
    class AdoptAnimal
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Mobile { get; set; }

        public List<Dog> AdoptDogsList { get; set; }

        public AdoptAnimal(string name, string adress, int mobile,List<Dog> list)
        {
            Name = name;
            Adress = adress;
            Mobile = mobile;
            AdoptDogsList = list;
        }

        public string GetInfoAdopt()
        {
            return $"Información sobre la persona que adopta a un animal: \n" +
                $"Nombre: {Name} \n" +
                $"Dirección: {Adress}\n" +
                $"Móvil: {Mobile}";
        }
        /*AdoptDog: Si el estado es Adoptado, nos muestra un mensaje como que ese perro no puede ser añadido.
          En caso de que no este adoptado, lo agregamos a NUESTRA LISTA DE PERROS DE LA CLASE ADOPTANIMAL.
          Y le cambiamos su estado.*/
        public void AdoptDog(Dog dog)
        {
            if(dog.IsAdopted== StatusAnimal.Adoptado)
            {
                Console.WriteLine($"El animal no se puede añadir a tu lista.Ya esta adoptado");
            }

            if (dog.IsAdopted == StatusAnimal.NoAdoptado)
            {
                AdoptDogsList.Add(dog);
                var result = AdoptDogsList.FirstOrDefault(d => d.IdDog == dog.IdDog);
                if (result != null)
                {
                    dog.IsAdopted = StatusAnimal.Adoptado;
                }
                Console.WriteLine($"Perro adoptado!");
            }
        }
        
        public void RemoveTheDog(Dog dog)
        {
            dog.IsAdopted = StatusAnimal.NoAdoptado;
            AdoptDogsList.Remove(dog);
        }
    }
}
