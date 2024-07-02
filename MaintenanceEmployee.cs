using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerreraPOO
{
    class MaintenanceEmployee : Employee, IMantenimiento
    {
        public MaintenanceEmployee(string idEmployee, string name) : base(idEmployee, name)
        {
        }

        public void CleanInstallation()
        {
            Console.WriteLine($"El empleado {Name} se encuentra limpiando las instalaciones");
        }

        public void RepairInstallation()
        {
            Console.WriteLine($"Reparando la jaula.");
        }
        public override string GetInfoEmployee()
        {
            return base.GetInfoEmployee()+$"\nEmpleado de mantenimiento";  
        }
    }
}
