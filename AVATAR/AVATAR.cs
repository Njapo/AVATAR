using System;
using System.Collections.Generic;
using System.Text;

namespace AVATAR
{
    class AVATAR : person, Interfaces.ICanwaterbending, Interfaces.ICanfirebending, Interfaces.ICanairbending, Interfaces.ICanearthbending
    {
        public override string Name { get; set; }
        public  override Age Personage { get; set; }
        public bool Canwaterbending { get; set; }
        public bool Canfirebending { get; set; }
        public bool Canairbending { get; set; }
        public bool Canearthbending { get; set; }
        public override int Power { get  ; set  ; }
        public bool Avatarstate { get; set; }
        public override bool Isalive { get; set; } = true;
        public override bool Canfight { get  ; set ; }

        List<bool> Bendinglist;
        public AVATAR()
        {
            Bendinglist.Add(Canairbending);
            Bendinglist.Add(Canfirebending);
            Bendinglist.Add(Canearthbending);
            Bendinglist.Add(Canwaterbending);
            if(Personage.Equals(Age.baby))
            {
                Power = 0;
            }
            if(Personage.Equals(Age.teen))
            {
                foreach (var item in Bendinglist)
                {
                    if(item==true)
                    {
                        Power += 10;
                    }
                }
            }
            if (Personage.Equals(Age.middleage))
            {
                foreach (var item in Bendinglist)
                {
                    if (item == true)
                    {
                        Power += 50;
                    }
                }
            }
            if (Personage.Equals(Age.aged))
            {
                foreach (var item in Bendinglist)
                {
                    if (item == true)
                    {
                        Power += 40;
                    }
                }
            }
        }
        public void Activate_avatarstate()
        {
          if(Avatarstate==true)
            {
                switch (Personage)
                {
                    case Age.teen:
                    Power += 200;
                    break;
                    case Age.middleage:
                        Power += 500;
                        break;
                    case Age.aged:
                        Power += 500;
                        break;
                }

          }
        }

    }

}
