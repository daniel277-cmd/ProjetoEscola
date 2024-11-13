using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoEscola
{
    public partial class Form1 : Form
    {
        Thread nt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_matricula.Text == "usuario" && txt_senha.Text == "1234")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);   
                nt.Start(); 

            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos!");
            }
        }

        private void novoForm()
        {
            Application.Run(new Form2());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
