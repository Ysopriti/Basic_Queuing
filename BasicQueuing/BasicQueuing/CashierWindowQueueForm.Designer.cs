namespace BasicQueuing
{
    partial class CashierWindowQueueForm
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
            button1 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 58);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(107, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(169, 208);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 249);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListView listView1;
    }
}