



using System;

namespace tarea_1_estructura_de_datos.Class
{
    public abstract class CommunityMembers
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int CellphoneNumber { get; set; }

        public int ID { get; set; }

        public abstract void Save();

        public abstract void Update();

  


       
    }
   
}

