using Book.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Book.businessLogic;
using Book.BusinessLogic;

namespace Book.winform
{
    public partial class ResaultForm : Form
    {
        /// <summary>
        /// Создание формы для отображения итоговой суммы и списка товаров в корзине
        /// </summary>
        /// <param name="sum">Сумма в корзине</param>
        /// <param name="items">Список книг в корзине</param>
        public ResaultForm(ILogic l)
        {
            InitializeComponent();
            var lines = l.GetBusket();
            foreach (var item in lines)
            {
                busketItems.Text += $"{item.Title} - {item.Author}. Цена: {item.Price} рублей.\n";
            }
            busketItems.Text += $"Итог: {l.GetSum()} рублей";
        }

        /// <summary>
        /// Создание формы для отображения текстового сообщения
        /// </summary>
        /// <param name="s">Текстовое сообщение</param>
        public ResaultForm(string s)
        {
            InitializeComponent();
            busketItems.Text = s.ToString();
        }

        /// <summary>
        /// Закрытие формы при нажатии на кнопку "Закрыть"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
