using System;
using System.Text;
using System.Windows.Forms;

namespace criptografar
{
    public partial class frmDescriptografar : Form
    {
        public frmDescriptografar()
        {
            InitializeComponent();
            Form1 form1 = new Form1();
            form1.Close();
        }

        private void btnDescritpo_Click(object sender, EventArgs e)
        {
            string cript = richTxtMsg.Text;
            int criptFinal = 0;
            byte[] text = ASCIIEncoding.Default.GetBytes(cript);
            string teste = "";

            foreach (var c in text)
            {
                criptFinal =  (int)c - 2;
                byte[] convertido = { (byte)criptFinal };
                teste = teste + Encoding.Default.GetString(convertido);
            }
            richTxtDescript.Text = teste;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void criptografarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            
           
        }

        private void btnClearDescitpto_Click(object sender, EventArgs e)
        {
            richTxtDescript.Text = "";
            richTxtMsg.Text = "";
        }
    }
}
