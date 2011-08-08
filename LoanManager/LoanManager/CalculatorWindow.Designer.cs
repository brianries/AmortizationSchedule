namespace LoanManager
{
    partial class CalculatorWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputPrinciple = new System.Windows.Forms.TextBox();
            this.inputAPR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNumPayments = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputMonthlyPayment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.generateSchedule = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principle";
            // 
            // inputPrinciple
            // 
            this.inputPrinciple.Location = new System.Drawing.Point(139, 28);
            this.inputPrinciple.Name = "inputPrinciple";
            this.inputPrinciple.Size = new System.Drawing.Size(92, 20);
            this.inputPrinciple.TabIndex = 1;
            this.inputPrinciple.TextChanged += new System.EventHandler(this.inputPrinciple_Changed);
            // 
            // inputAPR
            // 
            this.inputAPR.Location = new System.Drawing.Point(139, 74);
            this.inputAPR.Name = "inputAPR";
            this.inputAPR.Size = new System.Drawing.Size(92, 20);
            this.inputAPR.TabIndex = 3;
            this.inputAPR.TextChanged += new System.EventHandler(this.inputAPR_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "APR";
            // 
            // inputNumPayments
            // 
            this.inputNumPayments.Location = new System.Drawing.Point(139, 121);
            this.inputNumPayments.Name = "inputNumPayments";
            this.inputNumPayments.Size = new System.Drawing.Size(92, 20);
            this.inputNumPayments.TabIndex = 5;
            this.inputNumPayments.TextChanged += new System.EventHandler(this.inputNumPayments_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "# Payments";
            // 
            // inputMonthlyPayment
            // 
            this.inputMonthlyPayment.Location = new System.Drawing.Point(149, 188);
            this.inputMonthlyPayment.Name = "inputMonthlyPayment";
            this.inputMonthlyPayment.Size = new System.Drawing.Size(92, 20);
            this.inputMonthlyPayment.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monthly Payment";
            // 
            // generateSchedule
            // 
            this.generateSchedule.Location = new System.Drawing.Point(18, 229);
            this.generateSchedule.Name = "generateSchedule";
            this.generateSchedule.Size = new System.Drawing.Size(247, 27);
            this.generateSchedule.TabIndex = 11;
            this.generateSchedule.Text = "Generate Schedule";
            this.generateSchedule.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputNumPayments);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputAPR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputPrinciple);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 168);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Parameters";
            // 
            // CalculatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 270);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generateSchedule);
            this.Controls.Add(this.inputMonthlyPayment);
            this.Controls.Add(this.label4);
            this.Name = "CalculatorWindow";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPrinciple;
        private System.Windows.Forms.TextBox inputAPR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNumPayments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputMonthlyPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generateSchedule;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}