using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace DungeonEar {
   public class Location {


        public string Name { get; set; }


        public string  Description { get; set; }

       
        public Dictionary<Direction, int>  Exits { get; set; }




        public int Id { get; set; }

        public Location() {
            Exits = new Dictionary<Direction, int>();

        }
        public Location(int newId) {

            Exits = new Dictionary<Direction, int>();

           

            this.Id = newId;

        }

        
        public void SetExit(Direction theDirectionOfTheExit, int theIdentityOfTheRoom) {
            Exits.Add(theDirectionOfTheExit, theIdentityOfTheRoom);
        }



       

        public int GetExit(Direction theInput) {


            if (Exits.ContainsKey(theInput)) {
                return Exits[theInput];
            }
            return -1;
        }

        public override string ToString() {
            return $"{Name} {Id}";
        }




    }



}
