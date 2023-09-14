using System;
using System.Collections.Generic;
using System.Text;

namespace tarea_1_estructura_de_datos.Class
{
    public class Employer : CommunityMembers
    {
        public string Code { get; set; }

        public string Department { get; set; }

        public int Salary { get; set; }

        public string Occupation { get; set; }

        public override void Save()
        {
            Console.WriteLine("Saving Employer...");
        }

        public override void Update()
        {
            Console.WriteLine("Updating Employer...");
        }
    }
      
}

