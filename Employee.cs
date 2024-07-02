using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerreraPOO
{
    class Employee
    {
        public string Name { get; set; }
        public string IdEmployee { get; set; }
        public Employee(string idEmployee, string name)
        {
            Name = name;
            IdEmployee = idEmployee;
        }
        public virtual string Work()
        {
            return $"El empleado {Name}, se encuentra trabajando en nuestras instalaciones";
        }
        public virtual string GetInfoEmployee()
        {
            return $"Información sobre el empleado: \n" +
                $"Id: {IdEmployee}\n" +
                $"Nombre: {Name}";
        }
    }
}
