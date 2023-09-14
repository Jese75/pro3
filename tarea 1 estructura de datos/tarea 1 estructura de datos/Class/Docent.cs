using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_1_estructura_de_datos.Class
{
    public class Docent : Employer
    {
        public string Status { get; set; }

        public int ID_card { get; set; }

        public override void Save()
        {
            Console.WriteLine("Saving Docent...");
        }

        public override void Update()
        {
            Console.WriteLine("Updating Docent...");
        }
       
       
    }

}

