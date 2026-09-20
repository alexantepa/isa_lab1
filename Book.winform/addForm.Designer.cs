namespace Book.winform
{
    partial class addForm
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
            title = new TextBox();
            price = new TextBox();
            genre = new TextBox();
            author = new TextBox();
            labelTitle = new Label();
            labelPrice = new Label();
            labelGenre = new Label();
            labelAuthor = new Label();
            save = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 14F);
            title.Location = new Point(138, 12);
            title.Name = "title";
            title.Size = new Size(199, 39);
            title.TabIndex = 0;
            // 
            // price
            // 
            price.Font = new Font("Segoe UI", 14F);
            price.Location = new Point(138, 148);
            price.Name = "price";
            price.Size = new Size(199, 39);
            price.TabIndex = 1;
            // 
            // genre
            // 
            genre.Font = new Font("Segoe UI", 14F);
            genre.Location = new Point(138, 103);
            genre.Name = "genre";
            genre.Size = new Size(199, 39);
            genre.TabIndex = 2;
            // 
            // author
            // 
            author.Font = new Font("Segoe UI", 14F);
            author.Location = new Point(138, 58);
            author.Name = "author";
            author.Size = new Size(199, 39);
            author.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(120, 32);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Название";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 14F);
            labelPrice.Location = new Point(12, 148);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(71, 32);
            labelPrice.TabIndex = 5;
            labelPrice.Text = "Цена";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Font = new Font("Segoe UI", 14F);
            labelGenre.Location = new Point(12, 103);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(75, 32);
            labelGenre.TabIndex = 6;
            labelGenre.Text = "Жанр";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Segoe UI", 14F);
            labelAuthor.Location = new Point(12, 51);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(80, 32);
            labelAuthor.TabIndex = 7;
            labelAuthor.Text = "Автор";
            // 
            // save
            // 
            save.Font = new Font("Segoe UI", 12F);
            save.Location = new Point(12, 193);
            save.Name = "save";
            save.Size = new Size(132, 38);
            save.TabIndex = 8;
            save.Text = "Сохранить";
            save.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            cancel.Font = new Font("Segoe UI", 12F);
            cancel.Location = new Point(205, 193);
            cancel.Name = "cancel";
            cancel.Size = new Size(132, 38);
            cancel.TabIndex = 9;
            cancel.Text = "Отмена";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // addForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 240);
            Controls.Add(cancel);
            Controls.Add(save);
            Controls.Add(labelAuthor);
            Controls.Add(labelGenre);
            Controls.Add(labelPrice);
            Controls.Add(labelTitle);
            Controls.Add(author);
            Controls.Add(genre);
            Controls.Add(price);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "addForm";
            Text = "addForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox title;
        private TextBox price;
        private TextBox genre;
        private TextBox author;
        private Label labelTitle;
        private Label labelPrice;
        private Label labelGenre;
        private Label labelAuthor;
        private Button save;
        private Button cancel;
    }
}