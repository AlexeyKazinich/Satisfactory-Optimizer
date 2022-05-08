using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Optimizer.Machines
{
    public class Foundry : Machine
    {
        private IDictionary<string, dynamic> recipeDictionary;
        private Miner miner = new Miner();

        public Foundry()
        {
            recipeDictionary = new Dictionary<string, dynamic>();
            Tuple<string, float> makes = new Tuple<string, float>("Steel Ingot", 45);
            Tuple<string, float> takes1 = new Tuple<string, float>("Iron Ore", 45);
            Tuple<string, float> takes2 = new Tuple<string, float>("Coal", 45);
            string tempMachine = "Miner";
            recipeDictionary.Add("Steel Ingot", new { tempMachine, makes, takes1, takes2 });
        }

        public override string GetMachineName()
        {
            return "Foundry";
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
            if (recipeDictionary[item].tempMachine == "Miner")
            {
                tempString = miner.ToString(text, recipeDictionary[item].takes1.Item1, recipeDictionary[item].takes1.Item2 * efficiency);
                tempString = miner.ToString(tempString, recipeDictionary[item].takes2.Item1, recipeDictionary[item].takes2.Item2 * efficiency);
            }

            return tempString;
        }


    }
}
