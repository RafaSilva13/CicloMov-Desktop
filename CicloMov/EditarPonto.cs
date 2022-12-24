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
    public partial class frmEditarPonto : Form
    {
        int idcidade;
        string cidadeEscolhido;
        int verificarPonto = 0;

        public frmEditarPonto()
        {
            InitializeComponent();
        }

        private void frmEditarPonto_Load(object sender, EventArgs e)
        {
            txtCodPontos.Text = "";
            cbxEstado.Text = "";
            cbxCidade.Text = "";
            txtVagasTotais.Text = "";
            txtLinkMaps.Text = "";
            txtDescricao.Text = "";
            cbxCidade.Items.Clear();

            txtCodPontos.Select();
            cbxEstado.Enabled = false;
            cbxCidade.Enabled = false; ;
            txtVagasTotais.Enabled = false;
            txtLinkMaps.Enabled = false;
            txtDescricao.Enabled = false;


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

        private void cbxEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int indice = cbxEstado.SelectedIndex;
            cbxCidade.Text = "";
            cbxCidade.Items.Clear();

            MySqlConnection cnn2 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando2 = new MySqlCommand("SELECT * FROM cidades WHERE id_estado = @idEstado", cnn2);
            try
            {
                comando2.Parameters.AddWithValue("@idEstado", indice);

                cnn2.Open();

                MySqlDataReader myReader;

                myReader = comando2.ExecuteReader();
                try
                {
                    int i = 0;

                    while (myReader.Read())
                    {
                        cbxCidade.Items.Insert(i, myReader.GetString(2));
                        i++;
                    }

                }
                finally
                {
                    myReader.Close();
                    cnn2.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (cbxEstado.Text != "" && cbxCidade.Text != "" && txtVagasTotais.Text != "" && txtLinkMaps.Text != "" && txtDescricao.Text != "")
            {
                int estado = cbxEstado.SelectedIndex;
                int cidade = idcidade;

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando = new MySqlCommand("UPDATE pontos SET id_estado=@idEstado, id_cidade=@idCidade, vagas_livres_ponto=@vagasLivres, vagas_totais_ponto=@vagasTotais, mapa=@link, descricao=@descricao WHERE cod_ponto=@id_ponto;", cnn);
                try
                {
                    cnn.Open();

                    comando.Parameters.AddWithValue("@id_ponto", txtCodPontos.Text);
                    comando.Parameters.AddWithValue("@idEstado", estado);
                    comando.Parameters.AddWithValue("@idCidade", cidade);
                    comando.Parameters.AddWithValue("@vagasLivres", txtVagasTotais.Text);
                    comando.Parameters.AddWithValue("@vagasTotais", txtVagasTotais.Text);
                    comando.Parameters.AddWithValue("@link", txtLinkMaps.Text);
                    comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);

                    MySqlDataReader myReader;
                  
                    myReader = comando.ExecuteReader();
                    try
                    {
                        MessageBox.Show("Ponto alterado com sucesso!");

                        txtCodPontos.Text = "";
                        cbxEstado.Text = "";
                        cbxCidade.Text = "";
                        txtVagasTotais.Text = "";
                        txtLinkMaps.Text = "";
                        txtDescricao.Text = "";
                        cbxCidade.Items.Clear();

                        cbxEstado.Enabled = false;
                        cbxCidade.Enabled = false;
                        txtVagasTotais.Enabled = false;
                        txtLinkMaps.Enabled = false;
                        txtDescricao.Enabled = false;
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
        private void cbxCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cidadeEscolhido = cbxCidade.Text;

            MySqlConnection cnn2 = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando2 = new MySqlCommand("SELECT cod_cidade FROM cidades WHERE descricao_cidade = @nomeCidade", cnn2);
            try
            {
                comando2.Parameters.AddWithValue("@nomeCidade", cidadeEscolhido);

                cnn2.Open();

                MySqlDataReader myReader;

                myReader = comando2.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        idcidade = myReader.GetInt32(0);
                    }

                }
                finally
                {
                    myReader.Close();
                    cnn2.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCodPontos_TextChanged(object sender, EventArgs e)
        {
            if(txtCodPontos.Text != "")
            {

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando2 = new MySqlCommand("SELECT * FROM pontos WHERE cod_ponto = @id_ponto", cnn);
                MySqlCommand comando = new MySqlCommand("SELECT * FROM pontos t1 INNER JOIN estados t2 ON t1.id_estado = t2.cod_estado INNER JOIN cidades t3 ON t1.id_cidade = t3.cod_cidade WHERE t1.cod_ponto = @id_ponto", cnn);
                try
                {
                    cnn.Open();

                    comando.Parameters.AddWithValue("@id_ponto", txtCodPontos.Text);
                    comando2.Parameters.AddWithValue("@id_ponto", txtCodPontos.Text);

                    MySqlDataReader myReader;

                    myReader = comando2.ExecuteReader();
                    try
                    {
                        if (myReader.Read())
                        {
                            verificarPonto = 1;
                        }
                    }
                    finally
                    {
                        myReader.Close();
                    }

                    if (verificarPonto == 1)
                    {
                        myReader = comando.ExecuteReader();
                        try
                        {
                            cbxEstado.Text = "";
                            cbxCidade.Text = "";
                            txtVagasTotais.Text = "";
                            txtLinkMaps.Text = "";
                            txtDescricao.Text = "";
                            cbxCidade.Items.Clear();

                            cbxEstado.Enabled = true;
                            cbxCidade.Enabled = true; ;
                            txtVagasTotais.Enabled = true;
                            txtLinkMaps.Enabled = true;
                            txtDescricao.Enabled = true;

                            while (myReader.Read())
                            {
                                cbxEstado.Text = myReader.GetString(8);
                                cbxCidade.Text = myReader.GetString(12);
                                txtVagasTotais.Text = myReader.GetString(4);
                                txtLinkMaps.Text = myReader.GetString(6);
                                txtDescricao.Text = myReader.GetString(5);
                            }

                            verificarPonto = 0;
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
                        cbxCidade.Text = "";
                        txtVagasTotais.Text = "";
                        txtLinkMaps.Text = "";
                        txtDescricao.Text = "";
                        cbxCidade.Items.Clear();

                        cbxEstado.Enabled = false;
                        cbxCidade.Enabled = false; ;
                        txtVagasTotais.Enabled = false;
                        txtLinkMaps.Enabled = false;
                        txtDescricao.Enabled = false;
                        
                        MessageBox.Show("Ponto não encontrado!");
                    }

                }
                catch (Exception ex)
                {
                    cbxEstado.Text = "";
                    cbxCidade.Text = "";
                    txtVagasTotais.Text = "";
                    txtLinkMaps.Text = "";
                    txtDescricao.Text = "";
                    cbxCidade.Items.Clear();

                    cbxEstado.Enabled = false;
                    cbxCidade.Enabled = false; ;
                    txtVagasTotais.Enabled = false;
                    txtLinkMaps.Enabled = false;
                    txtDescricao.Enabled = false;

                    MessageBox.Show("Ponto não encontrado!");
                }
            }
            else
            {
                cbxEstado.Enabled = false;
                cbxCidade.Enabled = false; ;
                txtVagasTotais.Enabled = false;
                txtLinkMaps.Enabled = false;
                txtDescricao.Enabled = false;
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            frmListarPontos area_pontos = new frmListarPontos();

            area_pontos.Show();
        }

    }
}
