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
            this.calculatePrincipleButton = new System.Windows.Forms.Button();
            this.inputMonthlyPayment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateAPRButton = new System.Windows.Forms.Button();
            this.calculateNumPaymentsButton = new System.Windows.Forms.Button();
            this.calculateMonthlyPaymentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principle";
            // 
            // inputPrinciple
            // 
            this.inputPrinciple.Location = new System.Drawing.Point(135, 8);
            this.inputPrinciple.Name = "inputPrinciple";
            this.inputPrinciple.Size = new System.Drawing.Size(92, 20);
            this.inputPrinciple.TabIndex = 1;
            this.inputPrinciple.ModifiedChanged += new System.EventHandler(this.inputPrinciple_Enter);
            // 
            // inputAPR
            // 
            this.inputAPR.Location = new System.Drawing.Point(135, 54);
            this.inputAPR.Name = "inputAPR";
            this.inputAPR.Size = new System.Drawing.Size(92, 20);
            this.inputAPR.TabIndex = 3;
            this.inputAPR.ModifiedChanged += new System.EventHandler(this.inputAPR_ModifiedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "APR";
            // 
            // inputNumPayments
            // 
            this.inputNumPayments.Location = new System.Drawing.Point(135, 101);
            this.inputNumPayments.Name = "inputNumPayments";
            this.inputNumPayments.Size = new System.Drawing.Size(92, 20);
            this.inputNumPayments.TabIndex = 5;
            this.inputNumPayments.ModifiedChanged += new System.EventHandler(this.inputNumPayments_ModifiedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "# Payments";
            // 
            // calculatePrincipleButton
            // 
            this.calculatePrincipleButton.Location = new System.Drawing.Point(233, 4);
            this.calculatePrincipleButton.Name = "calculatePrincipleButton";
            this.calculatePrincipleButton.Size = new System.Drawing.Size(68, 27);
            this.calculatePrincipleButton.TabIndex = 6;
            this.calculatePrincipleButton.Text = "Calculate";
            this.calculatePrincipleButton.UseVisualStyleBackColor = true;
            this.calculatePrincipleButton.Click += new System.EventHandler(this.calculatePrincipleButton_Click);
            // 
            // inputMonthlyPayment
            // 
            this.inputMonthlyPayment.Location = new System.Drawing.Point(135, 146);
            this.inputMonthlyPayment.Name = "inputMonthlyPayment";
            this.inputMonthlyPayment.Size = new System.Drawing.Size(92, 20);
            this.inputMonthlyPayment.TabIndex = 8;
            this.inputMonthlyPayment.ModifiedChanged += new System.EventHandler(this.inputMonthlyPayment_ModifiedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monthly Payment";
            // 
            // calculateAPRButton
            // 
            this.calculateAPRButton.Location = new System.Drawing.Point(233, 50);
            this.calculateAPRButton.Name = "calculateAPRButton";
            this.calculateAPRButton.Size = new System.Drawing.Size(68, 27);
            this.calculateAPRButton.TabIndex = 9;
            this.calculateAPRButton.Text = "Calculate";
            this.calculateAPRButton.UseVisualStyleBackColor = true;
            this.calculateAPRButton.Click += new System.EventHandler(this.calculateAPRButton_Click);
            // 
            // calculateNumPaymentsButton
            // 
            this.calculateNumPaymentsButton.Location = new System.Drawing.Point(233, 97);
            this.calculateNumPaymentsButton.Name = "calculateNumPaymentsButton";
            this.calculateNumPaymentsButton.Size = new System.Drawing.Size(68, 27);
            this.calculateNumPaymentsButton.TabIndex = 10;
            this.calculateNumPaymentsButton.Text = "Calculate";
            this.calculateNumPaymentsButton.UseVisualStyleBackColor = true;
            this.calculateNumPaymentsButton.Click += new System.EventHandler(this.calculateNumPaymentsButton_Click);
            // 
            // calculateMonthlyPaymentButton
            // 
            this.calculateMonthlyPaymentButton.Location = new System.Drawing.Point(233, 142);
            this.calculateMonthlyPaymentButton.Name = "calculateMonthlyPaymentButton";
            this.calculateMonthlyPaymentButton.Size = new System.Drawing.Size(68, 27);
            this.calculateMonthlyPaymentButton.TabIndex = 11;
            this.calculateMonthlyPaymentButton.Text = "Calculate";
            this.calculateMonthlyPaymentButton.UseVisualStyleBackColor = true;
            this.calculateMonthlyPaymentButton.Click += new System.EventHandler(this.calculateMonthlyPaymentButton_Click);
            // 
            // CalculatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 183);
            this.Controls.Add(this.calculateMonthlyPaymentButton);
            this.Controls.Add(this.calculateNumPaymentsButton);
            this.Controls.Add(this.calculateAPRButton);
            this.Controls.Add(this.inputMonthlyPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculatePrincipleButton);
            this.Controls.Add(this.inputNumPayments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputAPR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPrinciple);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorWindow";
            this.Text = "Calculator";
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
        private System.Windows.Forms.Button calculatePrincipleButton;
        private System.Windows.Forms.TextBox inputMonthlyPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateAPRButton;
        private System.Windows.Forms.Button calculateNumPaymentsButton;
        private System.Windows.Forms.Button calculateMonthlyPaymentButton;
    }
}