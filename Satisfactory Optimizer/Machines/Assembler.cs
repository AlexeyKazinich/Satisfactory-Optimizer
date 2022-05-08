using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Optimizer.Machines
{
    public class Assembler : Machine
    {
        private IDictionary<string, dynamic> recipeDictionary;
        private Constructor constructor = new Constructor();
        public Assembler()
        {
            recipeDictionary = new Dictionary<string, dynamic>();
            Tuple<string, float> makes = new Tuple<string, float>("Modular Frame", 4);
            Tuple<string, float> takes1 = new Tuple<string, float>("Reinforced Iron Plate", 3);
            Tuple<string, float> takes2 = new Tuple<string, float>("Iron Rod", 12);
            string tempMachine1 = "Assembler";
            string tempMachine2 = "Constructor";
            recipeDictionary.Add("Modular Frame", new { tempMachine1, tempMachine2, makes, takes1,takes2 });

            makes = new Tuple<string, float>("Reinforced Iron Plate", 5);
            takes1 = new Tuple<string, float>("Iron Plate", 30);
            takes2 = new Tuple<string, float>("Screws", 60);
            tempMachine1 = "Constructor";
            tempMachine2 = "Constructor";
            recipeDictionary.Add("Reinforced Iron Plate", new { tempMachine1, tempMachine2, makes, takes1, takes2 });

            makes = new Tuple<string, float>("Encased Industrial Beam", 6);
            takes1 = new Tuple<string, float>("Steel Beam", 24);
            takes2 = new Tuple<string, float>("Concrete", 30);
            tempMachine1 = "Constructor";
            tempMachine2 = "Constructor";
            recipeDictionary.Add(makes.Item1, new { tempMachine1, tempMachine2, makes, takes1, takes2 });

            makes = new Tuple<string, float>("Rotor", 4);
            takes1 = new Tuple<string, float>("Iron Rod", 20);
            takes2 = new Tuple<string, float>("Screws", 100);
            tempMachine1 = "Constructor";
            tempMachine2 = "Constructor";
            recipeDictionary.Add(makes.Item1, new { tempMachine1, tempMachine2, makes, takes1, takes2 });

            makes = new Tuple<string, float>("Stator", 5);
            takes1 = new Tuple<string, float>("Steel Pipe", 15);
            takes2 = new Tuple<string, float>("Wire", 40);
            tempMachine1 = "Constructor";
            tempMachine2 = "Constructor";
            recipeDictionary.Add(makes.Item1, new { tempMachine1, tempMachine2, makes, takes1, takes2 });
            
            makes = new Tuple<string, float>("Motor", 5);
            takes1 = new Tuple<string, float>("Rotor", 10);
            takes2 = new Tuple<string, float>("Stator", 10);
            tempMachine1 = "Assembler";
            tempMachine2 = "Assembler";
            recipeDictionary.Add(makes.Item1, new { tempMachine1, tempMachine2, makes, takes1, takes2 });

            makes = new Tuple<string, float>("Smart Plating", 2);
            takes1 = new Tuple<string, float>("Reinforced Iron Plate", 2);
            takes2 = new Tuple<string, float>("Rotor", 2);
            tempMachine1 = "Assembler";
            tempMachine2 = "Assembler";
            recipeDictionary.Add(makes.Item1, new { tempMachine1, tempMachine2, makes, takes1, takes2 });

            makes = new Tuple<string, float>("AI Limiter", 5);
            takes1 = new Tuple<string, float>("Copper Sheet", 25);
            takes2 = new Tuple<string, float>("Quickwire", 100);
            tempMachine1 = "Constructor";
            tempMachine2 = "Constructor";
            recipeDictionary.Add(makes.Item1, new { tempMachine1, tempMachine2, makes, takes1, takes2 });

            
        }

        public override string GetMachineName()
        {
            return "Assembler";
        }

        public override string GetProducedItemName(string item)
        {
            return recipeDictionary[item].makes.Item1;
        }

        public override float GetProducedItemQuantity(string item)
        {
            return recipeDictionary[item].makes.Item2;
        }

        public override string CallMachines(string text, string item, float quantity, float efficiency)
        {
            string tempString = "";
            if (recipeDictionary[item].tempMachine1 == "Constructor")
            {
                tempString = constructor.ToString(text, recipeDictionary[item].takes1.Item1, recipeDictionary[item].takes1.Item2 * efficiency);   
            }
            else if(recipeDictionary[item].tempMachine1 == "Assembler")
            {
                tempString = ToString(text, recipeDictionary[item].takes1.Item1, recipeDictionary[item].takes1.Item2 * efficiency);
            }

            if(recipeDictionary[item].tempMachine2 == "Constructor")
            {
                tempString = constructor.ToString(tempString, recipeDictionary[item].takes2.Item1, recipeDictionary[item].takes2.Item2 * efficiency);
            }
            else if (recipeDictionary[item].tempMachine2 == "Assembler")
            {
                tempString = ToString(tempString, recipeDictionary[item].takes2.Item1, recipeDictionary[item].takes2.Item2 * efficiency);
            }


            return tempString;
        }
    }
}
