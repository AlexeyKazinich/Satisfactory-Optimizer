using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Optimizer.Machines
{
    
    public class Constructor : Machine
    {
        private IDictionary<String, dynamic> recipeDictionary;
        private Smelter smelter = new Smelter();
        private Foundry foundry = new Foundry();
        private Miner miner = new Miner();



        public Constructor()
        {
            recipeDictionary = new Dictionary<string, dynamic>();
            Tuple<string, float> makes = new Tuple<string, float>("Iron Rod",15);
            Tuple< string, float> takes = new Tuple< string, float>("Iron Ingot", 15);
            string tempMachine = "Smelter";
            recipeDictionary.Add("Iron Rod", new {tempMachine,makes,takes});

            makes = new Tuple<string, float>("Iron Plate", 20);
            takes = new Tuple<string, float>("Iron Ingot", 30);
            tempMachine = "Smelter";
            recipeDictionary.Add("Iron Plate", new {tempMachine,makes, takes });

            makes = new Tuple<string, float>("Screws", 40);
            takes = new Tuple<string, float>("Iron Rod", 10);
            tempMachine = "Constructor";
            recipeDictionary.Add("Screws", new { tempMachine, makes, takes });

            makes = new Tuple<string, float>("Copper Sheet", 10);
            takes = new Tuple<string, float>("Copper Ingot", 20);
            tempMachine = "Smelter";
            recipeDictionary.Add("Copper Sheet", new { tempMachine, makes, takes });

            makes = new Tuple<string, float>("Steel Beam", 15);
            takes = new Tuple<string, float>("Steel Ingot", 60);
            tempMachine = "Foundry";
            recipeDictionary.Add("Steel Beam", new { tempMachine, makes, takes });

            makes = new Tuple<string, float>("Steel Pipe", 20);
            takes = new Tuple<string, float>("Steel Ingot", 30);
            tempMachine = "Foundry";
            recipeDictionary.Add("Steel Pipe", new { tempMachine, makes, takes });

            makes = new Tuple<string, float>("Wire", 30);
            takes = new Tuple<string, float>("Copper Ingot", 15);
            tempMachine = "Smelter";
            recipeDictionary.Add("Wire", new { tempMachine, makes, takes });

            makes = new Tuple<string, float>("Cable", 30);
            takes = new Tuple<string, float>("Wire", 60);
            tempMachine = "Constructor";
            recipeDictionary.Add("Cable", new { tempMachine, makes, takes });

            makes = new Tuple<string, float>("Concrete", 15);
            takes = new Tuple<string, float>("Limestone", 45);
            tempMachine = "Miner";
            recipeDictionary.Add("Concrete", new { tempMachine, makes, takes });

            makes = new Tuple<string, float>("Quartz Crystal", 22.5f);
            takes = new Tuple<string, float>("Quartz", 37.5f);
            tempMachine = "Miner";
            recipeDictionary.Add("Quartz Crystal", new { tempMachine, makes, takes });

            makes = new Tuple<string, float>("Silica", 37.5f);
            takes = new Tuple<string, float>("Quartz", 22.5f);
            tempMachine = "Miner";
            recipeDictionary.Add("Silica", new { tempMachine, makes, takes });

            makes = new Tuple<string, float>("Quickwire", 60);
            takes = new Tuple<string, float>("Caterium Ingot", 12);
            tempMachine = "Smelter";
            recipeDictionary.Add("Quickwire", new { tempMachine, makes, takes });

        }

        public string CallConstructor(string text, string item, float quantity)
        {
            return ToString(text, item, quantity);
        }

        public override string GetMachineName()
        {
            return "Constructor";
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
            if(recipeDictionary[item].tempMachine == "Smelter")
            {
                tempString = smelter.ToString(text, recipeDictionary[item].takes.Item1, recipeDictionary[item].takes.Item2 * efficiency);
            }
            else if (recipeDictionary[item].tempMachine == "Foundry")
            {
                tempString = foundry.ToString(text, recipeDictionary[item].takes.Item1, recipeDictionary[item].takes.Item2 * efficiency);
            }
            else if (recipeDictionary[item].tempMachine == "Miner")
            {
                tempString = miner.ToString(text, recipeDictionary[item].takes.Item1, recipeDictionary[item].takes.Item2 * efficiency);
            }
            else if (recipeDictionary[item].tempMachine == "Constructor")
            {
                tempString = CallConstructor(text, recipeDictionary[item].takes.Item1, recipeDictionary[item].takes.Item2 * efficiency);
            }

            return tempString;
        }


    }
}
