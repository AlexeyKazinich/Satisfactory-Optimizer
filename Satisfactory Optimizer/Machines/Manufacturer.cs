using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Optimizer.Machines
{
    public class Manufacturer : Machine
    {
        private IDictionary<string, dynamic> recipeDictionary;
        public Manufacturer()
        {
            recipeDictionary = new Dictionary<string, dynamic>();
            Tuple<string,string, float> makes = new Tuple<string,string, float>("Manufacturer","Computer", 2.5f);
            Tuple<string,string, float> takes1 = new Tuple<string,string, float>("Assembler","Circuit Board", 25);
            Tuple<string, string, float> takes2 = new Tuple<string, string, float>("Constructor","Cable", 22.5f);
            Tuple<string, string, float> takes3 = new Tuple<string, string, float>("Refinery","Plastic", 45);
            Tuple<string, string, float> takes4 = new Tuple<string, string, float>("Constructor","Screw", 130);
            recipeDictionary.Add(makes.Item2, new {makes, takes1, takes2, takes3, takes4 });
        }
        public override string CallMachines(string text, string item, float quantity, float efficiency)
        {
            throw new NotImplementedException();
        }

        public override string GetMachineName()
        {
            throw new NotImplementedException();
        }

        public override string GetProducedItemName(string item)
        {
            throw new NotImplementedException();
        }

        public override float GetProducedItemQuantity(string item)
        {
            throw new NotImplementedException();
        }
    }
}
