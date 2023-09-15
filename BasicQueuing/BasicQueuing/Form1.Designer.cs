namespace BasicQueuing
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
            btnCashier = new Button();
            label1 = new Label();
            lblQueue = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = SystemColors.ButtonFace;
            btnCashier.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCashier.Location = new Point(45, 53);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(135, 110);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(233, 79);
            label1.Name = "label1";
            label1.Size = new Size(118, 14);
            label1.TabIndex = 1;
            label1.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(187, 103);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(205, 45);
            lblQueue.TabIndex = 2;
            lblQueue.Text = "P - 10007";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(45, 166);
            label3.Name = "label3";
            label3.Size = new Size(135, 13);
            label3.TabIndex = 3;
            label3.Text = "*click to get a number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 232);
            Controls.Add(label3);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label label1;
        private Label lblQueue;
        private Label label3;
    }
}