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
            addBut = new Button();
            deleteBut = new Button();
            updateBut = new Button();
            closeBut = new Button();
            groupeBut = new Button();
            searchAuthorBut = new Button();
            basketBut = new Button();
            clearBusketBut = new Button();
            ((System.ComponentModel.ISupportInitialize)listBooks).BeginInit();
            SuspendLayout();
            // 
            // listBooks
            // 
            listBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBooks.Location = new Point(12, 12);
            listBooks.Name = "listBooks";
            listBooks.RowHeadersWidth = 51;
            listBooks.Size = new Size(687, 374);
            listBooks.TabIndex = 0;
            listBooks.CellDoubleClick += listBooks_CellDoubleClick;
            listBooks.CellMouseClick += listBooks_CellMouseClick;
            // 
            // addBut
            // 
            addBut.Location = new Point(705, 11);
            addBut.Name = "addBut";
            addBut.Size = new Size(173, 46);
            addBut.TabIndex = 1;
            addBut.Text = "Добавить";
            addBut.UseVisualStyleBackColor = true;
            addBut.Click += addBut_Click;
            // 
            // deleteBut
            // 
            deleteBut.Location = new Point(705, 63);
            deleteBut.Name = "deleteBut";
            deleteBut.Size = new Size(173, 46);
            deleteBut.TabIndex = 2;
            deleteBut.Text = "Удалить";
            deleteBut.UseVisualStyleBackColor = true;
            deleteBut.Click += deleteBut_Click;
            // 
            // updateBut
            // 
            updateBut.Location = new Point(879, 11);
            updateBut.Name = "updateBut";
            updateBut.Size = new Size(173, 46);
            updateBut.TabIndex = 3;
            updateBut.Text = "Изменить";
            updateBut.UseVisualStyleBackColor = true;
            updateBut.Click += updateBut_Click;
            // 
            // closeBut
            // 
            closeBut.Location = new Point(705, 339);
            closeBut.Name = "closeBut";
            closeBut.Size = new Size(147, 46);
            closeBut.TabIndex = 4;
            closeBut.Text = "Закрыть";
            closeBut.UseVisualStyleBackColor = true;
            closeBut.Click += closeBut_Click;
            // 
            // groupeBut
            // 
            groupeBut.Location = new Point(705, 185);
            groupeBut.Name = "groupeBut";
            groupeBut.Size = new Size(184, 46);
            groupeBut.TabIndex = 5;
            groupeBut.Text = "Группировка по жанру";
            groupeBut.UseVisualStyleBackColor = true;
            groupeBut.Click += groupeBut_Click;
            // 
            // searchAuthorBut
            // 
            searchAuthorBut.Location = new Point(894, 185);
            searchAuthorBut.Name = "searchAuthorBut";
            searchAuthorBut.Size = new Size(158, 46);
            searchAuthorBut.TabIndex = 6;
            searchAuthorBut.Text = "Поиск автора";
            searchAuthorBut.UseVisualStyleBackColor = true;
            searchAuthorBut.Click += searchAuthorBut_Click;
            // 
            // basketBut
            // 
            basketBut.Location = new Point(894, 237);
            basketBut.Name = "basketBut";
            basketBut.Size = new Size(158, 45);
            basketBut.TabIndex = 7;
            basketBut.Text = "Корзина";
            basketBut.UseVisualStyleBackColor = true;
            basketBut.Click += busketBut_Click;
            // 
            // clearBusketBut
            // 
            clearBusketBut.Location = new Point(705, 237);
            clearBusketBut.Name = "clearBusketBut";
            clearBusketBut.Size = new Size(184, 45);
            clearBusketBut.TabIndex = 8;
            clearBusketBut.Text = "Очистить корзину";
            clearBusketBut.UseVisualStyleBackColor = true;
            clearBusketBut.Click += clearBusketBut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 397);
            Controls.Add(clearBusketBut);
            Controls.Add(basketBut);
            Controls.Add(searchAuthorBut);
            Controls.Add(groupeBut);
            Controls.Add(closeBut);
            Controls.Add(updateBut);
            Controls.Add(deleteBut);
            Controls.Add(addBut);
            Controls.Add(listBooks);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)listBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView listBooks;
        private Button addBut;
        private Button deleteBut;
        private Button updateBut;
        private Button closeBut;
        private Button groupeBut;
        private Button searchAuthorBut;
        private Button basketBut;
        private Button clearBusketBut;
    }
}
