using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Optimizer.Machines
{
    public class Miner : Machine
    {
        private IDictionary<string, float> recipeDictionary;

        public Miner()
        {
            recipeDictionary = new Dictionary<string, float>();
            recipeDictionary.Add("Iron Ore", 120);
            recipeDictionary.Add("Copper Ore", 120);
            recipeDictionary.Add("Limestone", 120);
            recipeDictionary.Add("Coal", 120);
            recipeDictionary.Add("Sulfur", 120);
            recipeDictionary.Add("Quartz", 120);
            recipeDictionary.Add("Caterium Ore", 120);

        }

        public override string GetMachineName()
        {
            return "Miner";
        }

        public override string GetProducedItemName(string item)
        {
            return item;
        }

        public override float GetProducedItemQuantity(string item)
        {
            return recipeDictionary[item];
        }

        public override string CallMachines(string text, string item, float quantity, float efficiency)
        {
            throw new NotImplementedException();
        }

    }
}
