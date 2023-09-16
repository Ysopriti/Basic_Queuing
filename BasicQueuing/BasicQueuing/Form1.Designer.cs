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
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = SystemColors.ButtonFace;
            btnCashier.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCashier.Location = new Point(45, 53);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(126, 110);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
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
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(45, 166);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(126, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "*Click to get a number";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(402, 232);
            Controls.Add(linkLabel1);
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
        private LinkLabel linkLabel1;
    }
}