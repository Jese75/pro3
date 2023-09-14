using System;

namespace tarea_1_estructura_de_datos.Class
{
    public class Teacher : Docent
    {
        public string Subject { get; set; }

        public int StudentQuantity { get; set; }

        public override void Save()
        {
            Console.WriteLine("Saving Teacher...");
        }

        public override void Update()
        {
            Console.WriteLine("Updating Teacher...");
        }
    }
}