using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerreraPOO
{
    class EmergencyVeterinaryEmployee : Veterinary, IEmergencia
    {
        /*EmergencyVeterinaryEmployee se trata de una clase de veterinario de tipo emergencia.*/
        public EmergencyVeterinaryEmployee(string idEmployee, string name, string speciality) : base(idEmployee, name, speciality)
        {
        }
        /*AttendEmergency:Realiza intervenciones tan solo si la energia o el peso esta muy deteriorado.*/
        public static void AttendEmergency(Animal animal)
        {
            if (animal is Dog dog)
            {
                if (dog.Energy <= 1)
                {
                    Console.WriteLine($"Se encuentra muy débil, debemos realizar una operación.");
                    dog.Energy = 5;
                }
            }

            if (animal.Weight <= 2)
            {
                Console.WriteLine($"El animal se encuentra con muy poco peso, debemos de ingresarlo");
            }
        }
        public override string GetInfoEmployee()
        {
            return base.GetInfoEmployee() + $"\nVeterinario de Emergencias";
        }
    }
}
