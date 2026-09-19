namespace Book.winform
{
    partial class busket
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
            close = new Button();
            busketItems = new RichTextBox();
            totalPrice = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // close
            // 
            close.Font = new Font("Segoe UI", 14F);
            close.Location = new Point(674, 362);
            close.Name = "close";
            close.Size = new Size(114, 49);
            close.TabIndex = 0;
            close.Text = "Закрыть";
            close.UseVisualStyleBackColor = true;
            // 
            // busketItems
            // 
            busketItems.Font = new Font("Segoe UI", 14F);
            busketItems.Location = new Point(12, 12);
            busketItems.Name = "busketItems";
            busketItems.ReadOnly = true;
            busketItems.Size = new Size(776, 299);
            busketItems.TabIndex = 1;
            busketItems.Text = "";
            // 
            // totalPrice
            // 
            totalPrice.Font = new Font("Segoe UI", 14F);
            totalPrice.Location = new Point(608, 317);
            totalPrice.Name = "totalPrice";
            totalPrice.ReadOnly = true;
            totalPrice.Size = new Size(180, 39);
            totalPrice.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(527, 320);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 3;
            label1.Text = "Всего:";
            // 
            // busket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 428);
            Controls.Add(label1);
            Controls.Add(totalPrice);
            Controls.Add(busketItems);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "busket";
            Text = "busket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button close;
        private RichTextBox busketItems;
        private TextBox totalPrice;
        private Label label1;
    }
}