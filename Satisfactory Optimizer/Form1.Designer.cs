namespace Satisfactory_Optimizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculateButton = new System.Windows.Forms.Button();
            this.OutPutLabel = new System.Windows.Forms.Label();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.MachineComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 12);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutPutLabel
            // 
            this.OutPutLabel.AutoSize = true;
            this.OutPutLabel.Location = new System.Drawing.Point(12, 57);
            this.OutPutLabel.Name = "OutPutLabel";
            this.OutPutLabel.Size = new System.Drawing.Size(38, 15);
            this.OutPutLabel.TabIndex = 1;
            this.OutPutLabel.Text = "label1";
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Items.AddRange(new object[] {
            "Iron Rod",
            "Iron Plate",
            "Screws"});
            this.ItemComboBox.Location = new System.Drawing.Point(220, 13);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(121, 23);
            this.ItemComboBox.TabIndex = 2;
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(347, 12);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.QuantityTextBox.TabIndex = 3;
            this.QuantityTextBox.Text = "20";
            // 
            // MachineComboBox
            // 
            this.MachineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MachineComboBox.FormattingEnabled = true;
            this.MachineComboBox.Items.AddRange(new object[] {
            "Constructor",
            "Assembler",
            "Foundry"});
            this.MachineComboBox.Location = new System.Drawing.Point(93, 13);
            this.MachineComboBox.Name = "MachineComboBox";
            this.MachineComboBox.Size = new System.Drawing.Size(121, 23);
            this.MachineComboBox.TabIndex = 4;
            this.MachineComboBox.SelectedIndexChanged += new System.EventHandler(this.MachineComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MachineComboBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.ItemComboBox);
            this.Controls.Add(this.OutPutLabel);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CalculateButton;
        private Label OutPutLabel;
        private ComboBox ItemComboBox;
        private TextBox QuantityTextBox;
        private ComboBox MachineComboBox;
    }
}