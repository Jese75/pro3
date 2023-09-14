

using System;

namespace tarea_1_estructura_de_datos.Class
{
    public class Admin : Docent
    {
       public int  HomePhone { get; set; }

        public int bills { get; set; }

        public int budget {  get; set; }

        public override void Save()
        {
            Console.WriteLine("Saving Admin...");
        }

        public override void Update()
        {
            Console.WriteLine("Updating Admin...");
        }
    }
}
