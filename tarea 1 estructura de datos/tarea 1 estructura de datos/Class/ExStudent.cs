
using System;

namespace tarea_1_estructura_de_datos.Class
{
    internal class ExStudent : CommunityMembers
    {
        public string ExCourse { get; set; }

        public string GraduationNumber { get; set; }

        public override void Save()
        {
            Console.WriteLine("Saving Exstudent...");
        }

        public override void Update()
        {
            Console.WriteLine("Updating Exstudent...");
        }
    }
    
}

   
  
