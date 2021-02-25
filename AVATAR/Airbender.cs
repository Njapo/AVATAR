using System;
using System.Collections.Generic;
using System.Text;
using static AVATAR.Interfaces;
namespace AVATAR
{
    class Airbender : person,  Interfaces.ICanairbending
    { 
        public override string Name { get; set; }
        public  override Age Personage { get; set; }
        public bool Canairbending { get; set; }
        public override int Power { get  ; set ; }
        public override bool Isalive { get; set; } = true;
        public override bool Canfight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Airbender()
        {
            if (Canairbending == true)
            {
                switch (Personage)
                {
                    case Age.baby:
                        Power = 0;
                        break;
                    case Age.teen:
                        Power = 20;
                        break;
                    case Age.middleage:
                        Power = 100;
                        break;
                    case Age.aged:
                        Power = 50;
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
        }
        public enum Job { Warriorfireman, Baker, Colonel, Emperor, Teacher, Doctor, Merchant, Femmer, Sailor, Miner, Lieutenant, }
         
    }
}
