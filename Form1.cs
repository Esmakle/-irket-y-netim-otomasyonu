using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Tasar�mc� kodlar�n�n �a�r�lmas�
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProductManagement productForm = new FrmProductManagement();
            productForm.Show(); // Yeni formu a�ar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCustomerManagement customerForm = new FrmCustomerManagement();
            customerForm.Show(); // Yeni formu a�ar
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOrderManagement orderForm = new FrmOrderManagement();
            orderForm.Show(); // Yeni formu a�ar
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmReturnManagement returnForm = new FrmReturnManagement();
            returnForm.Show(); // Yeni formu a�ar
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmStockTracking stockForm = new FrmStockTracking();
            stockForm.Show(); // Yeni formu a�ar
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close(); // Formu kapat�r
        }
    }
}
