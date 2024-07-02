using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerreraPOO
{
    class Veterinary : Employee
    {
        public string Speciality { get; set; }
        public Veterinary(string idEmployee, string name, string speciality) : base(idEmployee, name)
        {
            Speciality = speciality;
        }
        public override string Work()
        {
            return $"El veterinario {Name}, tiene la especilidad de animales {Speciality}";
        }
        public override string GetInfoEmployee()
        {
            return base.GetInfoEmployee()+$"\nEspecialidad {Speciality}";
        }
        /*InspectAnimal:Revisa el estado del animal pasado por parámetro.
          Primero de todo muestra la información como valoración general del animal y después comprobamos si el animal que pasamos se trata de un perro.
          Si se trata de un perro comprobaremos su estado. En caso de que este alegre subiremos su energia +2, en cambio si esta agresivo le bajaremos
          su energia con una inyección.
          En caso de que la inyección haya bajado mucho su energia(sea <=1), llamamos al método AttendEmergency de la clase Emergency, que realiza una operación
          para restaurar su energia a 5.
          
          Por ultimo nos indica si es un animal adoptado o no.
          */
        public void InspectAnimal(Animal animal)
        {
            Console.WriteLine($"MOSTRAMOS LA INFORMACION DEL ANIMAL QUE ESTAMOS TRATANDO:");
            Console.WriteLine(animal.GetInformation());
            if(animal is Dog dog)
            {
                if (animal.Behaviour == "alegre")
                {
                    dog.Energy = dog.Energy + 2;
                    Console.WriteLine($"La energia actual del perro es de : {dog.Energy}.Es recomendable" +
                        $"que su mascota siga de la misma forma.");
                }
                else if (animal.Behaviour == "agresivo")
                {
                    Console.WriteLine($"El perro ha entrado a la consulta con una energia de {dog.Energy}.Necesita una inyección para tranquilizarse");
                    dog.Energy -= 3;
                    if (dog.Energy <= 1)
                    {
                        EmergencyVeterinaryEmployee.AttendEmergency(dog);
                    }
                }
                else
                {
                    Console.WriteLine($"No hemos encontrado ninguna anomalia.");
                }

                if (dog.IsAdopted == StatusAnimal.Adoptado)
                {
                    Console.WriteLine($"Se trata de un animal adoptado");
                }
                else
                {
                    Console.WriteLine($"Este animal todavía no ha conseguido ninguna familia.");
                }
            }
        }
    }
}
