using System;
using System.Collections.Generic;
using System.Text;

namespace AVATAR
{
    class Human : person
    {
        public enum Job { Warriorfireman, Baker, Colonel, Emperor, Teacher, Doctor, Merchant, Femmer, Sailor, Miner, Lieutenant,  }
         
        public override string Name { get; set; }
        public override int Power { get ; set; }
        public  override Age Personage { get; set; }
        public override bool Isalive { get; set; } = true;
        public override bool Canfight { get  ; set  ; }

        public Human()
        {
            if (Canfight == false)
            {
                switch (Personage)
                {
                    case Age.baby:
                        Power = 0;
                        break;
                    case Age.teen:
                        Power = 5;
                        break;
                    case Age.middleage:
                        Power = 40;
                        break;
                    case Age.aged:
                        Power = 10;
                        break;
                }
            }
            else
            {
                switch (Personage)
                {
                    case Age.baby:
                        Power = 0;
                        break;
                    case Age.teen:
                        Power = 10;
                        break;
                    case Age.middleage:
                        Power = 60;
                        break;
                    case Age.aged:
                        Power = 30; 
                        break;
                }
            }
        }

           
    }
}
