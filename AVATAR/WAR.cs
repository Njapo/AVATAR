using System;
using System.Collections.Generic;
using  System.Text;

namespace AVATAR
{
      class WAR<T>
      {
        public List<person> addforces{ get; set; }
        public List<Battle> battles;
        public List<person> oneside_people;
        public List<person> otherside_people;
       public  List<person> onearmy; 
       public  List<person> secondarmy;
        public void collectarmy(List<person> oneside_people, List<person> otherside_people)
        {
            foreach (var item in oneside_people)
            {
               if(item.Canfight==true && item.Personage.Equals(person.Age.middleage))
                {
                    onearmy.Add(item);
                }
            }
            foreach (var item in secondarmy)
            {
                if(item.Canfight==true && item.Personage.Equals(person.Age.middleage))
                {
                    secondarmy.Add(item);
                }
            }
        }
        public void addpeople(List<person> people, List<person> addforcesto)
        { 
            if(addforcesto==oneside_people)
            {
                foreach (var item in addforcesto)
                {
                    oneside_people.Add(item);
                }
            }
            if(addforcesto==otherside_people)
            {
                foreach (var item in otherside_people)
                {
                    otherside_people.Add(item);
                }
            }
        }

      }
}
