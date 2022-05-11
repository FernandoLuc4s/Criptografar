using System;
using System.Text;
using System.Windows.Forms;

namespace criptografar
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
           // richTxtCript.Enabled = false;
        }

       
        private void btnCritpo_Click(object sender, EventArgs e)
        {
            string cript = richTxtMsg.Text;
            int criptFinal = 0;
            byte[] text = ASCIIEncoding.Default.GetBytes(cript);
            string teste="";

            foreach (var c in text) 
            {
                criptFinal = 2+(int)c;
                byte[] convertido = { (byte)criptFinal };
                teste = teste + Encoding.Default.GetString(convertido); 
            }
            richTxtCript.Text = teste;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTxtMsg.Text ="";
            richTxtCript.Text ="";
        }

        private void richTextBox1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void decriptografarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDescriptografar formDescripto = new frmDescriptografar();

            this.Hide();
            formDescripto.ShowDialog();
            formDescripto.Dispose();
        }

        private void lblCripto_Click(object sender, EventArgs e)
        {

        }
    }
}
