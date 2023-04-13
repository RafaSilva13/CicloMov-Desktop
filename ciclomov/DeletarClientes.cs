using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CicloMov
{
    public partial class frmDeletarClientes : Form
    {
        int verificarCliente;
        public frmDeletarClientes()
        {
            InitializeComponent();
        }

        private void frmDeletarClientes_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarClientes area_clientes = new frmListarClientes();

            area_clientes.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (ckbConfirmacaoCliente.Checked)
            {
                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando2 = new MySqlCommand("SELECT * FROM clientes WHERE cod_clientes = @Id", cnn);
                MySqlCommand comando = new MySqlCommand("DELETE FROM clientes WHERE cod_clientes = @Id", cnn);
                try
                {
                    cnn.Open();

                    comando2.Parameters.AddWithValue("@Id", txtCodigoDeletarCliente.Text);
                    comando.Parameters.AddWithValue("@Id", txtCodigoDeletarCliente.Text);

                    MySqlDataReader myReader;

                    myReader = comando2.ExecuteReader();
                    try
                    {
                        if (myReader.Read())
                        {
                            verificarCliente = 1;
                        }
                    }
                    finally
                    {
                        myReader.Close();
                    }

                    if (verificarCliente == 1)
                    {
                        myReader = comando.ExecuteReader();

                        try
                        {
                            MessageBox.Show("Item deletado!");
                            txtCodigoDeletarCliente.Text = "";
                            verificarCliente = 0;
                        }
                        finally
                        {
                            myReader.Close();
                            cnn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cliente não encontrado!");
                }
            }
            else
            {
                MessageBox.Show("Por favor marque a checkbox!");
            }
        }
    }
}
