using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerreraPOO
{
    class ProcessKennel
    {
        public List<Dog> ListDogs { get; set; }
        public List<Employee> ListEmployee { get; set; }
        public List<AdoptAnimal> ListAdoptAnimal { get; set; }
        /*Clase Perrera con 3 listas.*/
        public ProcessKennel(List<Dog> listDogs, List<Employee> listEmployee, List<AdoptAnimal> adoptAnimal)
        {
            ListDogs = listDogs;
            ListEmployee = listEmployee;
            ListAdoptAnimal = adoptAnimal;
        }

        /*ReturnTheDog:Método que devuelve un perro adoptado a la perrera. 
         *Comprobamos si el estado del perro es adoptado, en ese caso llamamos al método RemoveTheDog que le cambia el estado
          a NoAdoptado DE LA LISTA DE PERROS DE LA CLASE ADOPTANIMAL. Después nos muestra la información del perro que nos devuelven
          Y por último hacemos una query donde buscaremos el identificador del Perro, en este caso de LA LISTA DE PERROS DE LA PERRERA.
          En caso de que no sea NULL, le cambiaremos también su estado a NoAdoptado.*/
        public void ReturnTheDog(AdoptAnimal adopt, Dog dog)
        {
            if(dog.IsAdopted == StatusAnimal.Adoptado)
            {
                adopt.RemoveTheDog(dog);
                Console.WriteLine($"PERRO DEVUELTO A LA PERRERA: ");
                Console.WriteLine(dog.GetInformation());
                var result = ListDogs.FirstOrDefault(d => d.IdDog == dog.IdDog); //ListDogs CLAVE.
                if (result != null)
                {
                    dog.IsAdopted = StatusAnimal.NoAdoptado;
                }
            }
        }
        public void AddDog(Dog dog)
        {
            ListDogs.Add(dog);
        }
        public void RemoveDog(Dog dog)
        {
            if (dog.IsAdopted == StatusAnimal.Adoptado)
            {
                ListDogs.Remove(dog);
            }
        }
        public void SeeDogs(List<Dog> listDogs)
        {
            Console.WriteLine($"LISTADO DE TODOS LOS PERROS NO ADOPTADOS");
            for (int i = 0; i < listDogs.Count; i++)
            {
                Console.WriteLine(listDogs[i].GetInformation());
                Console.WriteLine("-");
            }
        }

        public void SeeEmployees(List<Employee> listEmployees)
        {
            Console.WriteLine($"LISTA DE TODOS LOS USUARIOS");
            for (int i = 0; i < listEmployees.Count; i++)
            {
                Console.WriteLine(listEmployees[i].GetInfoEmployee());
                Console.WriteLine("-");
            }
        }
        public void SeeAdopts(List<AdoptAnimal> listAdopt)
        {
            Console.WriteLine($"LISTA DE LAS PERSONAS QUE QUIEREN ADOPTAR");
            for (int i = 0; i < listAdopt.Count; i++)
            {
                Console.WriteLine(listAdopt[i].GetInfoAdopt());
                Console.WriteLine("-");
            }
        }
        /*RegisterAdopt: llamamos al método AdoptDog de y le pasamos el perro que queremos agregar.*/
        public void RegisterAdopt(AdoptAnimal adoptAnimal, Dog dog)
        {
            adoptAnimal.AdoptDog(dog);
        }
        /*AvaiableDogs:Muestra los perros que se encuentran como NoAdoptado en LA LISTA DE PERROS DE LA PERRERA*/
        public List<Dog> AvaiableDogs()
        {
            return ListDogs.Where(d => d.IsAdopted == StatusAnimal.NoAdoptado).ToList();
        }
    }
}
