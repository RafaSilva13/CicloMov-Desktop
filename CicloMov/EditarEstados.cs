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
    public partial class frmEditarEstados : Form
    {
        int verificarEstado = 0;
        public frmEditarEstados()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarEstados area_ListarEstados = new frmListarEstados();

            area_ListarEstados.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtCodEstados.Text != "" && txtNomeEstado.Text != "" && txtSiglaEstado.Text != "")
            {
                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando = new MySqlCommand("UPDATE estados SET descricao_estado = @id_estado, sigla = @sigla WHERE cod_estado = @cod;", cnn);
                try
                {
                    cnn.Open();

                    comando.Parameters.AddWithValue("@cod", txtCodEstados.Text);
                    comando.Parameters.AddWithValue("@id_estado", txtNomeEstado.Text);
                    comando.Parameters.AddWithValue("@sigla", txtSiglaEstado.Text);

                    MySqlDataReader myReader;

                    myReader = comando.ExecuteReader();
                    try
                    {
                        MessageBox.Show("Ponto alterado com sucesso!");

                        txtCodEstados.Text = "";
                        txtNomeEstado.Text = "";
                        txtSiglaEstado.Text = "";

                        txtNomeEstado.Enabled = false;
                        txtSiglaEstado.Enabled = false;
                    }
                    finally
                    {
                        myReader.Close();
                        cnn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void txtCodEstados_TextChanged(object sender, EventArgs e)
        {
            if (txtCodEstados.Text != "")
            {
                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando2 = new MySqlCommand("SELECT * FROM estados WHERE cod_estado = @id_estado", cnn);
                MySqlCommand comando = new MySqlCommand("SELECT * FROM estados WHERE cod_estado = @id_estado", cnn);
                try
                {
                    cnn.Open();

                    comando.Parameters.AddWithValue("@id_estado", txtCodEstados.Text);
                    comando2.Parameters.AddWithValue("@id_estado", txtCodEstados.Text);

                    MySqlDataReader myReader;

                    myReader = comando2.ExecuteReader();
                    try
                    {
                        if (myReader.Read())
                        {
                            verificarEstado = 1;
                        }
                    }
                    finally
                    {
                        myReader.Close();
                    }

                    if (verificarEstado == 1)
                    {
                        myReader = comando.ExecuteReader();
                        try
                        {
                            txtNomeEstado.Text = "";
                            txtSiglaEstado.Text = "";

                            txtNomeEstado.Enabled = true;
                            txtSiglaEstado.Enabled = true; 
  

                            while (myReader.Read())
                            {
                                txtNomeEstado.Text = myReader.GetString(1);
                                txtSiglaEstado.Text = myReader.GetString(2);
                                
                            }

                            verificarEstado = 0;
                        }
                        finally
                        {
                            myReader.Close();
                            cnn.Close();
                        }
                    }
                    else
                    {
                        txtNomeEstado.Text = "";
                        txtSiglaEstado.Text = "";

                        txtNomeEstado.Enabled = false;
                        txtSiglaEstado.Enabled = false; ;
                        
                        MessageBox.Show("Estado não encontrado!");
                    }

                }
                catch (Exception ex)
                {
                    txtNomeEstado.Text = "";
                    txtSiglaEstado.Text = "";

                    txtNomeEstado.Enabled = false;
                    txtSiglaEstado.Enabled = false; ;

                    MessageBox.Show("Estado não encontrado!");
                }
            }
            else
            {
                txtNomeEstado.Text = "";
                txtSiglaEstado.Text = "";

                txtNomeEstado.Enabled = false;
                txtSiglaEstado.Enabled = false;
            }
        }

        private void frmEditarEstados_Load(object sender, EventArgs e)
        {
            txtCodEstados.Text = "";
            txtNomeEstado.Text = "";
            txtSiglaEstado.Text = "";

            txtNomeEstado.Enabled = false;
            txtSiglaEstado.Enabled = false;
        }
    }
}
