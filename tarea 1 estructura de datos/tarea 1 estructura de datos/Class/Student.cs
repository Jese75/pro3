

using System;

namespace tarea_1_estructura_de_datos.Class
{
    public class Student : CommunityMembers
    {
        public string Grade { get; set; }

        public string Classroom { get; set; }

        public override void Save()
        {
            Console.WriteLine("Saving Student...");
        }

        public override void Update()
        {
          Console.WriteLine("Updating Student...");
        }
        
        
    }
    
}