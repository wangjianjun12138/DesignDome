using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class FormCashAccpet : Form
    {
        private Double m_totalPrice;
        public FormCashAccpet()
        {
            InitializeComponent();
            m_totalPrice = 0.0;
            m_comboBox.Items.Add("无折扣");
            m_comboBox.Items.Add("打8折");
            m_comboBox.Items.Add("满100减10");
            m_comboBox.SelectedIndex = 0;
        }

        private void m_buttonOk_Click(object sender, EventArgs e)
        {
            Double price = Convert.ToDouble(m_textBoxPrice.Text);
            Double count = Convert.ToDouble(m_textBoxCount.Text);
            Double cashValue = price * count;
            m_totalPrice += cashValue;
            String itemInfo = String.Format("单价：{0}    数量：{1}    合计：{2}", price, count, cashValue);
            m_listBoxItems.Items.Add(itemInfo);

            CashConext cc = new CashConext(m_comboBox.Text);
            m_labelTotal.Text = cc.ContextInterface(m_totalPrice).ToString("0.00");
        }

        private void m_buttonReset_Click(object sender, EventArgs e)
        {
            m_listBoxItems.Items.Clear();
            m_textBoxCount.Text = String.Empty;
            m_textBoxPrice.Text = String.Empty;
            m_totalPrice = 0;
        }
    }
}
