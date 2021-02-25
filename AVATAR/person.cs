using System;
using System.Collections.Generic;
using System.Text;

namespace AVATAR
{
  abstract class person
    {
        public abstract bool Canfight { get; set; }
        public abstract  int Power{ get; set; }
        public abstract string Name { get; set; }
        protected Gender gender { get; set; }
        public  abstract Age Personage { get; set; }  
        public  enum Age {baby,teen,middleage,aged }; 
        protected enum Gender { man, woman}
        public int Money { get; set; }
        public abstract   bool Isalive { get; set; }  

    } 
}
