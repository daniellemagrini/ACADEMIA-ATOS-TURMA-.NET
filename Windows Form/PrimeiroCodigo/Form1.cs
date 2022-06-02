using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroCodigo
{
    public partial class form_aplicacao : Form
    {
        public form_aplicacao()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao programa!");
        }

        private void botaook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informações:\r\n" +
                            "Nome: " + tb_nome.Text + "\r\n" +
                            "Email: " + tb_email.Text + "\r\n" +
                            "Endereço: " + tb_endereco.Text + "\r\n" +
                            "Celular: " + tb_celular.Text);
            tb_nome.Clear();
            tb_email.Clear();
            tb_endereco.Clear();
            tb_celular.Clear();

            Close();
        }

        private void botaocancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_email.Clear();
            tb_endereco.Clear();
            tb_celular.Clear();
            MessageBox.Show("CANCELADO!");
            Close();   
        }

        private void lb_nome_Click(object sender, EventArgs e)
        {

        }
    }
}
