using QueuingForm;

namespace BasicQueuing
{
    public partial class Form1 : Form
    {
        CashierClass cashier = new CashierClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P -");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
            cashierWindow.ShowDialog();
        }
    }
}