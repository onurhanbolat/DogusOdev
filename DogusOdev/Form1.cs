using DogusOdev.SOLID;
using Microsoft.VisualBasic.Logging;

namespace DogusOdev
{
    public partial class Form1 : Form
    {
        string selectedPaymentType;
        IPayment iPay;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PaymentFactory factory = new PaymentFactory();
            iPay = factory.newCreateObject(selectedPaymentType);
            PaymentManager manager = new PaymentManager(iPay);
            lblResult.Text = manager.PaymentSave(txtAmount.Text);
        }

        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPaymentType = cmbPaymentType.SelectedItem.ToString();
        }
    }
}
