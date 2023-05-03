namespace DatabaseProgramv2
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choose_month_label = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.month_Enter_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choose_month_label
            // 
            this.choose_month_label.AutoSize = true;
            this.choose_month_label.Location = new System.Drawing.Point(12, 19);
            this.choose_month_label.Name = "choose_month_label";
            this.choose_month_label.Size = new System.Drawing.Size(82, 13);
            this.choose_month_label.TabIndex = 0;
            this.choose_month_label.Text = "Choose Month: ";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthComboBox.Location = new System.Drawing.Point(100, 19);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 21);
            this.monthComboBox.TabIndex = 1;
            // 
            // month_Enter_Button
            // 
            this.month_Enter_Button.Location = new System.Drawing.Point(114, 58);
            this.month_Enter_Button.Name = "month_Enter_Button";
            this.month_Enter_Button.Size = new System.Drawing.Size(75, 23);
            this.month_Enter_Button.TabIndex = 2;
            this.month_Enter_Button.Text = "Enter";
            this.month_Enter_Button.UseVisualStyleBackColor = true;
            this.month_Enter_Button.Click += new System.EventHandler(this.month_Enter_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 672);
            this.Controls.Add(this.month_Enter_Button);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.choose_month_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choose_month_label;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Button month_Enter_Button;
    }
}

