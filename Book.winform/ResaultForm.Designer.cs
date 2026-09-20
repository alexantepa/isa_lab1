namespace Book.winform
{
    partial class ResaultForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // close
            // 
            close.Font = new Font("Segoe UI", 14F);
            close.Location = new Point(674, 317);
            close.Name = "close";
            close.Size = new Size(114, 49);
            close.TabIndex = 0;
            close.Text = "Закрыть";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
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
            // ResaultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 374);
            Controls.Add(busketItems);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ResaultForm";
            Text = "Результат";
            ResumeLayout(false);
        }

        #endregion

        private Button close;
        private RichTextBox busketItems;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}