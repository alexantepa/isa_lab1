namespace Book.winform
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
            listBooks = new DataGridView();
            add = new Button();
            delete = new Button();
            update = new Button();
            close = new Button();
            groupe = new Button();
            ((System.ComponentModel.ISupportInitialize)listBooks).BeginInit();
            SuspendLayout();
            // 
            // listBooks
            // 
            listBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBooks.Location = new Point(12, 12);
            listBooks.Name = "listBooks";
            listBooks.RowHeadersWidth = 51;
            listBooks.Size = new Size(1040, 374);
            listBooks.TabIndex = 0;
            // 
            // add
            // 
            add.Location = new Point(599, 392);
            add.Name = "add";
            add.Size = new Size(147, 46);
            add.TabIndex = 1;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // delete
            // 
            delete.Location = new Point(905, 392);
            delete.Name = "delete";
            delete.Size = new Size(147, 46);
            delete.TabIndex = 2;
            delete.Text = "Удалить";
            delete.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            update.Location = new Point(752, 392);
            update.Name = "update";
            update.Size = new Size(147, 46);
            update.TabIndex = 3;
            update.Text = "Изменить";
            update.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            close.Location = new Point(12, 392);
            close.Name = "close";
            close.Size = new Size(147, 46);
            close.TabIndex = 4;
            close.Text = "Закрыть";
            close.UseVisualStyleBackColor = true;
            // 
            // groupe
            // 
            groupe.Location = new Point(446, 392);
            groupe.Name = "groupe";
            groupe.Size = new Size(147, 46);
            groupe.TabIndex = 5;
            groupe.Text = "Группировка";
            groupe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 450);
            Controls.Add(groupe);
            Controls.Add(close);
            Controls.Add(update);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(listBooks);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)listBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView listBooks;
        private Button add;
        private Button delete;
        private Button update;
        private Button close;
        private Button groupe;
    }
}
