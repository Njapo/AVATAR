using System;
using System.Collections.Generic;
using System.Text;

namespace AVATAR
{
    class Battle : WAR<person>
    {
        public bool onearmybattleend { get; set; }
        public bool secondarmybattleend { get; set; }
        public int totaldead { get; set; } 
        public string winner { get; set; }
        public int onearmydeads { get; set; }
        public int secondarmydeads { get; set; }
        public void Fighting() 
        {
          while(onearmybattleend || secondarmybattleend || onearmydeads==onearmy.Count || secondarmydeads==secondarmy.Count)
            {
                
                for (int i = 0; i < onearmy.Count; i++)
                {
                    for (int j = 0; j < secondarmy.Count; j++)
                    {
                        if(secondarmy[j].Isalive==false)
                        {
                            continue;
                        }
                      else if(onearmy[i].Power>secondarmy[j].Power)
                        {
                            secondarmy.RemoveAt(j);
                            secondarmy[j].Isalive = false;
                            onearmy[i].Power = -secondarmy[j].Power;
                            secondarmydeads++;
                        }
                      else if(onearmy[i].Power<secondarmy[j].Power)
                        {
                            secondarmy[j].Power -= onearmy[i].Power;
                            onearmy[i].Isalive = false;
                            onearmy.RemoveAt(i);
                            onearmydeads++;
                        }
                        else
                        {
                            secondarmy[j].Power=0;
                            onearmy[i].Power = 0;
                            onearmy[i].Isalive = false;
                            onearmydeads++;
                            secondarmy[j].Isalive = false;
                            secondarmydeads++;
                            onearmy.RemoveAt(i);
                            secondarmy.RemoveAt(j);
                        }
                    }
                }
            }
          if(onearmybattleend==true)
            {
                winner = "secondarmy";
            }
          if(secondarmybattleend==true)
            {
                winner = "firstarmy";
            }
          if(secondarmy.Count==0 && onearmy.Count>0)
            {
                winner = "oneondarmy";
            }
          if(onearmy.Count==0 && secondarmy.Count>0)
            {
                winner = "secondarmy";
            }
          else
            {
                winner = "tie";
            }
        }
    }
}
