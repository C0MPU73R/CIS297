namespace Generics
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.displayItemsLabel = new System.Windows.Forms.Label();
			this.typeTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.plantNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.edibleCheckBox = new System.Windows.Forms.CheckBox();
			this.addPlantButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(144, 75);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 68);
			this.button1.TabIndex = 0;
			this.button1.Text = "ShowItems";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// displayItemsLabel
			// 
			this.displayItemsLabel.AutoSize = true;
			this.displayItemsLabel.Location = new System.Drawing.Point(149, 212);
			this.displayItemsLabel.Name = "displayItemsLabel";
			this.displayItemsLabel.Size = new System.Drawing.Size(0, 25);
			this.displayItemsLabel.TabIndex = 1;
			// 
			// typeTextBox
			// 
			this.typeTextBox.Location = new System.Drawing.Point(718, 91);
			this.typeTextBox.Name = "typeTextBox";
			this.typeTextBox.Size = new System.Drawing.Size(100, 31);
			this.typeTextBox.TabIndex = 2;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(1044, 94);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(100, 31);
			this.nameTextBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(539, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Type of animal:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(842, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Name of Animal:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(772, 175);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(215, 78);
			this.button2.TabIndex = 6;
			this.button2.Text = "Add Animal";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// plantNameTextBox
			// 
			this.plantNameTextBox.Location = new System.Drawing.Point(718, 356);
			this.plantNameTextBox.Name = "plantNameTextBox";
			this.plantNameTextBox.Size = new System.Drawing.Size(100, 31);
			this.plantNameTextBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(539, 359);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 25);
			this.label3.TabIndex = 8;
			this.label3.Text = "Type of plant:";
			// 
			// edibleCheckBox
			// 
			this.edibleCheckBox.AutoSize = true;
			this.edibleCheckBox.Location = new System.Drawing.Point(871, 359);
			this.edibleCheckBox.Name = "edibleCheckBox";
			this.edibleCheckBox.Size = new System.Drawing.Size(116, 29);
			this.edibleCheckBox.TabIndex = 9;
			this.edibleCheckBox.Text = "Edible?";
			this.edibleCheckBox.UseVisualStyleBackColor = true;
			// 
			// addPlantButton
			// 
			this.addPlantButton.Location = new System.Drawing.Point(781, 437);
			this.addPlantButton.Name = "addPlantButton";
			this.addPlantButton.Size = new System.Drawing.Size(185, 87);
			this.addPlantButton.TabIndex = 10;
			this.addPlantButton.Text = "Add Plant";
			this.addPlantButton.UseVisualStyleBackColor = true;
			this.addPlantButton.Click += new System.EventHandler(this.addPlantButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1330, 827);
			this.Controls.Add(this.addPlantButton);
			this.Controls.Add(this.edibleCheckBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.plantNameTextBox);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.typeTextBox);
			this.Controls.Add(this.displayItemsLabel);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label displayItemsLabel;
		private System.Windows.Forms.TextBox typeTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox plantNameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox edibleCheckBox;
		private System.Windows.Forms.Button addPlantButton;
	}
}

