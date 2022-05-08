using Satisfactory_Optimizer.Machines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Satisfactory_Optimizer
{
    public partial class Form1 : Form
    {
        private IDictionary<String, Machine> MachineDictionary = new Dictionary<String, Machine>();
        private List<String> ConstructorItems = new List<String>() {"Iron Rod","Iron Plate","Screws", "Copper Sheet", "Steel Beam", "Steel Pipe","Wire", "Cable", "Quickwire", "Concrete", "Quartz Crystal", "Silica" };
        private List<String> AssemblerItems = new List<String>() {"Reinforced Iron Plate", "Modular Frame", "Encased Industrial Beam", "Rotor", "Stator", "Motor", "Smart Plating", "NYI Versatile Framework", "NYI Automated Wiring","AI Limiter" };
        private List<String> FoundryItems = new List<string>() { "Steel Ingot" };
        public Form1()
        {
            InitializeComponent();

            //add all recipes
            MachineDictionary.Add("Constructor", new Constructor());
            MachineDictionary.Add("Assembler", new Assembler());
            MachineDictionary.Add("Foundry", new Foundry());
            ItemComboBox.SelectedIndex = 1;
            MachineComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutPutLabel.Text = $"{MachineDictionary[MachineComboBox.Text].ToString("", ItemComboBox.Text, float.Parse(QuantityTextBox.Text))}";
        }

        private void MachineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MachineComboBox.SelectedIndex == 0)
            {
                ItemComboBox.Items.Clear();
                ItemComboBox.Items.AddRange(ConstructorItems.ToArray());
                ItemComboBox.SelectedIndex = 0;
            }
            else if (MachineComboBox.SelectedIndex == 1)
            {
                ItemComboBox.Items.Clear();
                ItemComboBox.Items.AddRange(AssemblerItems.ToArray());
                ItemComboBox.SelectedIndex = 0;
            }

            if (MachineComboBox.SelectedIndex == 2)
            {
                ItemComboBox.Items.Clear();
                ItemComboBox.Items.AddRange(FoundryItems.ToArray());
                ItemComboBox.SelectedIndex = 0;
            }
        }

        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ignores an error that occurs on runtime when the MachineComboBox is empty
            try { QuantityTextBox.Text = MachineDictionary[MachineComboBox.Text].GetProducedItemQuantity(ItemComboBox.Text).ToString(); }
            catch (Exception) { }
        }
    }
}