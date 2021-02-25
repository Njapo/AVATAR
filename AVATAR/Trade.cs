using System;
using System.Collections.Generic;
using System.Text;

namespace AVATAR
{
      class Trade
      {
         
        readonly   Dictionary<Acceptablematerial, int> Returnmoney;
        public Trade()
        {
            Returnmoney = new Dictionary<Acceptablematerial, int>
            {
                { Acceptablematerial.tree, 10 },
                {Acceptablematerial.stone,20 },
                {Acceptablematerial.silver,200 },
                {Acceptablematerial.ice,20 },
                {Acceptablematerial.gold,500 },
                {Acceptablematerial.fur,100 },
                {Acceptablematerial.coal,10 },
                
            };

        }
        public int Money { get; set; } 
        public enum Acceptablematerial {tree, ice, stone, coal, silver, gold, fur, }
        public  void Wantexchaaange( Acceptablematerial acceptablematerial, int number, person Person)
        {
            
            foreach (var item in Returnmoney)
            {
                if(item.Key ==acceptablematerial)
                {
                    Money = item.Value * number;
                }
                
            }
            Person.Money += Money;
        }

     }
    
}
