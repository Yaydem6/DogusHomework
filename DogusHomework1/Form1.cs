using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogusHomework1
{
    public partial class Form1 : Form
    {
        string selectedMethod;
        IPaymentMethod imethod;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            PaymentFactory paymentFactory = new PaymentFactory();
            imethod = paymentFactory.createObject(selectedMethod);

            PaymentProcess paymentProcess = new PaymentProcess(imethod);

            lbl_message.Text = paymentProcess.payment(txt_amount.Text);

        }

        private void cb_payment_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMethod = cb_payment_method.SelectedItem.ToString();
        }
    }
    
}
