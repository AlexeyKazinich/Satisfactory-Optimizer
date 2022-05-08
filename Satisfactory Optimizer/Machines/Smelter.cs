using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Optimizer.Machines
{
    internal class Smelter : Machine
    {
        private IDictionary<String, dynamic> recipeDictionary;
        private Miner miner = new Miner();
        
        public Smelter()
        {
            recipeDictionary = new Dictionary<string, dynamic>();
            Tuple<string, float> makes = new Tuple<string, float>("Iron Ingot", 30);
            Tuple<string, float> takes = new Tuple<string, float>("Iron Ore", 30);
            string tempMachine = "Miner";
            recipeDictionary.Add("Iron Ingot", new { tempMachine, makes, takes });

            makes = new Tuple<string, float>("Copper Ingot", 30);
            takes = new Tuple<string, float>("Copper Ore", 30);
            tempMachine = "Miner";
            recipeDictionary.Add("Copper Ingot", new { tempMachine, makes, takes });

            makes = new Tuple<string, float>("Caterium Ingot", 30);
            takes = new Tuple<string, float>("Caterium Ore", 30);
            tempMachine = "Miner";
            recipeDictionary.Add("Caterium Ingot", new { tempMachine, makes, takes });
        }

        public override string GetMachineName()
        {
            return "Smelter";
        }

        public override string GetProducedItemName(string item)
        {
            return item;
        }

        public override float GetProducedItemQuantity(string item)
        {
            return recipeDictionary[item].makes.Item2;
        }

        public override string CallMachines(string text, string item, float quantity, float efficiency)
        {
            string tempString = "";
            
            if (recipeDictionary[item].tempMachine == "Miner")
            {
                tempString = miner.ToString(text, recipeDictionary[item].takes.Item1, recipeDictionary[item].takes.Item2 * efficiency);
            }

            return tempString;
        }
    }
}
