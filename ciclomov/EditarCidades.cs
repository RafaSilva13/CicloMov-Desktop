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
    public partial class frmEditarCidades : Form
    {
        int verificarCidade = 0;
        public frmEditarCidades()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarCidades area_cidades = new frmListarCidades();

            area_cidades.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (cbxEstado.Text != "" && txtCodCidade.Text != "" && txtNomeCidade.Text != "")
            {
                int estado = cbxEstado.SelectedIndex;
                string cidade = txtCodCidade.Text;

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando = new MySqlCommand("UPDATE cidades SET id_estado=@idEstado, descricao_cidade=@descricao WHERE cod_cidade = @idCidade;", cnn);
                try
                {
                    cnn.Open();

                    comando.Parameters.AddWithValue("@idCidade", cidade);
                    comando.Parameters.AddWithValue("@idEstado", estado);
                    comando.Parameters.AddWithValue("@descricao", txtNomeCidade.Text);

                    MySqlDataReader myReader;

                    myReader = comando.ExecuteReader();
                    try
                    {
                        MessageBox.Show("Cidade alterado com sucesso!");

                        txtCodCidade.Text = "";
                        cbxEstado.Text = "";
                        txtNomeCidade.Text = "";

                        cbxEstado.Enabled = false;
                        txtNomeCidade.Enabled = false;  
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

        private void frmEditarCidades_Load(object sender, EventArgs e)
        {
            cbxEstado.Text = "";
            txtCodCidade.Text = "";

            txtCodCidade.Select();
            cbxEstado.Enabled = false;
            txtNomeCidade.Enabled = false;

            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM estados", cnn);
            try
            {

                cnn.Open();

                MySqlDataReader myReader;

                myReader = comando.ExecuteReader();
                try
                {

                    int i = 0;

                    while (myReader.Read())
                    {
                        cbxEstado.Items.Insert(i, myReader.GetString(1));
                        i++;
                    }

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

        private void txtCodCidade_TextChanged(object sender, EventArgs e)
        {
            if (txtCodCidade.Text != "")
            {

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando2 = new MySqlCommand("SELECT * FROM cidades WHERE cod_cidade = @id_cidades", cnn);
                MySqlCommand comando = new MySqlCommand("SELECT * FROM cidades t1 INNER JOIN estados t2 ON t1.id_estado = t2.cod_estado WHERE t1.cod_cidade = @id_cidades", cnn);
                try
                {
                    cnn.Open();

                    comando.Parameters.AddWithValue("@id_cidades", txtCodCidade.Text);
                    comando2.Parameters.AddWithValue("@id_cidades", txtCodCidade.Text);

                    MySqlDataReader myReader;

                    myReader = comando2.ExecuteReader();
                    try
                    {
                        if (myReader.Read())
                        {
                            verificarCidade = 1;
                        }
                    }
                    finally
                    {
                        myReader.Close();
                    }

                    if (verificarCidade == 1)
                    {
                        myReader = comando.ExecuteReader();
                        try
                        {
                            cbxEstado.Text = "";
                            txtNomeCidade.Text = "";
                            
                            cbxEstado.Enabled = true;
                            txtNomeCidade.Enabled = true;
                            
                            while (myReader.Read())
                            {
                                cbxEstado.Text = myReader.GetString(4);
                                txtNomeCidade.Text = myReader.GetString(2);
                            }

                            verificarCidade = 0;
                        }
                        finally
                        {
                            myReader.Close();
                            cnn.Close();
                        }
                    }
                    else
                    {
                        cbxEstado.Text = "";
                        txtNomeCidade.Text = "";

                        cbxEstado.Enabled = false;
                        txtNomeCidade.Enabled = false;

                        MessageBox.Show("Cidade não encontrado!");
                    }

                }
                catch (Exception ex)
                {
                    cbxEstado.Text = "";
                    txtNomeCidade.Text = "";

                    cbxEstado.Enabled = false;
                    txtNomeCidade.Enabled = false;

                    MessageBox.Show("Cidade não encontrado!");
                }
            }
            else
            {
                cbxEstado.Enabled = false;
                txtNomeCidade.Enabled = false; 
            }
        }
    }
}
