

using System;

namespace tarea_1_estructura_de_datos.Class
{
    public class Administrative : Employer
    {
        public string Documents { get; set; }

        public int QuantityEmployer { get; set; }

        public override void Save()
        {
            Console.WriteLine("Saving Administratives...");
        }

        public override void Update()
        {
            Console.WriteLine("Updating Administrative...");
        }
    }
}
