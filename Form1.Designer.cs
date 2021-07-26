
namespace DepreciationForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabHow2Use = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TabInventory = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateInventory = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtLifetime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEnding = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtStarting = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LstInventory = new System.Windows.Forms.ListBox();
            this.TabSummary = new System.Windows.Forms.TabPage();
            this.lblCalcValue = new System.Windows.Forms.Label();
            this.BtnCalcInv = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabHow2Use.SuspendLayout();
            this.TabInventory.SuspendLayout();
            this.TabSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabHow2Use);
            this.tabControl1.Controls.Add(this.TabInventory);
            this.tabControl1.Controls.Add(this.TabSummary);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(486, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // TabHow2Use
            // 
            this.TabHow2Use.Controls.Add(this.label1);
            this.TabHow2Use.Controls.Add(this.textBox1);
            this.TabHow2Use.Location = new System.Drawing.Point(4, 29);
            this.TabHow2Use.Name = "TabHow2Use";
            this.TabHow2Use.Padding = new System.Windows.Forms.Padding(3);
            this.TabHow2Use.Size = new System.Drawing.Size(478, 356);
            this.TabHow2Use.TabIndex = 0;
            this.TabHow2Use.Text = "How to use this application";
            this.TabHow2Use.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Parchment", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Depreciation Form";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(314, 212);
            this.textBox1.TabIndex = 0;
            // 
            // TabInventory
            // 
            this.TabInventory.Controls.Add(this.button1);
            this.TabInventory.Controls.Add(this.BtnAdd);
            this.TabInventory.Controls.Add(this.dateTimePicker1);
            this.TabInventory.Controls.Add(this.DateInventory);
            this.TabInventory.Controls.Add(this.label7);
            this.TabInventory.Controls.Add(this.label6);
            this.TabInventory.Controls.Add(this.TxtLifetime);
            this.TabInventory.Controls.Add(this.label5);
            this.TabInventory.Controls.Add(this.TxtEnding);
            this.TabInventory.Controls.Add(this.label4);
            this.TabInventory.Controls.Add(this.TxtStarting);
            this.TabInventory.Controls.Add(this.label3);
            this.TabInventory.Controls.Add(this.TxtTitle);
            this.TabInventory.Controls.Add(this.label2);
            this.TabInventory.Controls.Add(this.LstInventory);
            this.TabInventory.Location = new System.Drawing.Point(4, 29);
            this.TabInventory.Name = "TabInventory";
            this.TabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.TabInventory.Size = new System.Drawing.Size(478, 356);
            this.TabInventory.TabIndex = 1;
            this.TabInventory.Text = "Inventory";
            this.TabInventory.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(44, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remove Selected Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.Location = new System.Drawing.Point(262, 277);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(164, 30);
            this.BtnAdd.TabIndex = 13;
            this.BtnAdd.Text = "Add Item to Inventory";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 244);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 27);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // DateInventory
            // 
            this.DateInventory.Checked = false;
            this.DateInventory.Location = new System.Drawing.Point(229, 185);
            this.DateInventory.Name = "DateInventory";
            this.DateInventory.Size = new System.Drawing.Size(239, 27);
            this.DateInventory.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date out of inventory:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date in inventory:";
            // 
            // TxtLifetime
            // 
            this.TxtLifetime.Location = new System.Drawing.Point(361, 125);
            this.TxtLifetime.Name = "TxtLifetime";
            this.TxtLifetime.Size = new System.Drawing.Size(111, 27);
            this.TxtLifetime.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lifetime (years):";
            // 
            // TxtEnding
            // 
            this.TxtEnding.Location = new System.Drawing.Point(361, 92);
            this.TxtEnding.Name = "TxtEnding";
            this.TxtEnding.Size = new System.Drawing.Size(111, 27);
            this.TxtEnding.TabIndex = 6;
            this.TxtEnding.Text = "0.00";
            this.TxtEnding.TextChanged += new System.EventHandler(this.DigitTextBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "End Value $:";
            // 
            // TxtStarting
            // 
            this.TxtStarting.Location = new System.Drawing.Point(361, 59);
            this.TxtStarting.Name = "TxtStarting";
            this.TxtStarting.Size = new System.Drawing.Size(111, 27);
            this.TxtStarting.TabIndex = 4;
            this.TxtStarting.Text = "0.00";
            this.TxtStarting.TextChanged += new System.EventHandler(this.DigitTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Starting Value $:";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(361, 26);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(111, 27);
            this.TxtTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // LstInventory
            // 
            this.LstInventory.FormattingEnabled = true;
            this.LstInventory.HorizontalScrollbar = true;
            this.LstInventory.ItemHeight = 20;
            this.LstInventory.Location = new System.Drawing.Point(17, 18);
            this.LstInventory.Name = "LstInventory";
            this.LstInventory.Size = new System.Drawing.Size(206, 244);
            this.LstInventory.TabIndex = 0;
            // 
            // TabSummary
            // 
            this.TabSummary.Controls.Add(this.lblCalcValue);
            this.TabSummary.Controls.Add(this.BtnCalcInv);
            this.TabSummary.Location = new System.Drawing.Point(4, 29);
            this.TabSummary.Name = "TabSummary";
            this.TabSummary.Size = new System.Drawing.Size(478, 356);
            this.TabSummary.TabIndex = 2;
            this.TabSummary.Text = "Summary";
            this.TabSummary.UseVisualStyleBackColor = true;
            // 
            // lblCalcValue
            // 
            this.lblCalcValue.AutoSize = true;
            this.lblCalcValue.Location = new System.Drawing.Point(239, 149);
            this.lblCalcValue.Name = "lblCalcValue";
            this.lblCalcValue.Size = new System.Drawing.Size(0, 20);
            this.lblCalcValue.TabIndex = 1;
            // 
            // BtnCalcInv
            // 
            this.BtnCalcInv.Location = new System.Drawing.Point(99, 92);
            this.BtnCalcInv.Name = "BtnCalcInv";
            this.BtnCalcInv.Size = new System.Drawing.Size(190, 29);
            this.BtnCalcInv.TabIndex = 0;
            this.BtnCalcInv.Text = "Calculate Inventory Value";
            this.BtnCalcInv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 398);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.TabHow2Use.ResumeLayout(false);
            this.TabHow2Use.PerformLayout();
            this.TabInventory.ResumeLayout(false);
            this.TabInventory.PerformLayout();
            this.TabSummary.ResumeLayout(false);
            this.TabSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabHow2Use;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage TabInventory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker DateInventory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtLifetime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEnding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtStarting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LstInventory;
        private System.Windows.Forms.TabPage TabSummary;
        private System.Windows.Forms.Label lblCalcValue;
        private System.Windows.Forms.Button BtnCalcInv;
    }
}

