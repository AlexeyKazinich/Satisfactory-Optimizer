using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satisfactory_Optimizer.Machines
{
    public abstract class Machine
    {

        public abstract string GetMachineName();

        public abstract string GetProducedItemName(string item);

        public abstract float GetProducedItemQuantity(string item);

        public abstract string CallMachines(string text, string item, float quantity, float efficiency);
        public string ToString(string text, string item, float quantity)
        {
            float efficiency;
            int regularMachine = 0;
            int maxedMachined = 0;
            //if quantity % GetRequiredItemQuantity = 0 which means all machines are 100%
            //if only 1 machine under 100%
            //if multiple machines at 100% and 1 under 100%
            if (quantity % GetProducedItemQuantity(item) == 0)
            {
                maxedMachined = (int)(quantity / GetProducedItemQuantity(item));
                efficiency = 1;

            }
            else if (quantity > GetProducedItemQuantity(item))
            {
                maxedMachined = (int)Math.Floor(quantity / GetProducedItemQuantity(item));
                regularMachine = 1;
                efficiency = (quantity % GetProducedItemQuantity(item)) / GetProducedItemQuantity(item);
            }
            else
            {
                efficiency = quantity / GetProducedItemQuantity(item);
                regularMachine = 1;
            }

            if(GetMachineName() == "Constructor" || GetMachineName() == "Smelter" || GetMachineName() == "Assembler" || GetMachineName() == "Foundry")
            {
                if (maxedMachined == 0)
                {
                    text += $"{regularMachine} {GetMachineName()} at {Math.Round(Convert.ToDouble(efficiency * 100),4)}% producing {Math.Round(Convert.ToDouble(GetProducedItemQuantity(item) * efficiency),4)} {GetProducedItemName(item)} ->";
                    text = CallMachines(text, item, 0, efficiency);
                }

                else if (maxedMachined != 0 && regularMachine == 0)
                {
                    text += $"{maxedMachined} {GetMachineName()} at 100% producing {Math.Round(Convert.ToDouble(GetProducedItemQuantity(item) * maxedMachined),4)} {GetProducedItemName(item)} ->";
                    text = CallMachines(text, item, 0, maxedMachined);
                }

                else if (maxedMachined != 0 && regularMachine != 0)
                {
                    text += $"{maxedMachined} {GetMachineName()} at 100% and {regularMachine} at {Math.Round(Convert.ToDouble(efficiency * 100), 4)}% producing {GetProducedItemQuantity(item) * efficiency + GetProducedItemQuantity(item) * maxedMachined} {GetProducedItemName(item)} ->";
                    text = CallMachines(text, item, 0, efficiency + maxedMachined);
                }
            }

            else if(GetMachineName() == "Miner")
            {
                if (maxedMachined == 0)
                {
                    text += $"{regularMachine} {GetMachineName()} at {Math.Round(Convert.ToDouble(efficiency * 100), 4)}% producing {Math.Round(Convert.ToDouble(GetProducedItemQuantity(item) * efficiency),4)} {GetProducedItemName(item)}\n";

                }

                else if (maxedMachined != 0 && regularMachine == 0)
                {
                    text += $"{maxedMachined} {GetMachineName()} at 100% producing {Math.Round(Convert.ToDouble(GetProducedItemQuantity(item) * maxedMachined),4)} {GetProducedItemName(item)}\n";

                }

                else if (maxedMachined != 0 && regularMachine != 0)
                {
                    text += $"{maxedMachined} {GetMachineName()} at 100% and {regularMachine} at {Math.Round(Convert.ToDouble(efficiency * 100), 4)}% producing {Math.Round(Convert.ToDouble(GetProducedItemQuantity(item) * efficiency + GetProducedItemQuantity(item) * maxedMachined),4)} {GetProducedItemName(item)}\n";
                }
            }

            return text;
        }
    }
}
