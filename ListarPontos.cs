using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using DataGridViewAutoFilter;

namespace CicloMov
{
    public partial class frmListarPontos : Form
    {
        DataTable Tbl2;

        public frmListarPontos()
        {
            InitializeComponent();
        }
        private void ListarPontos_Load(object sender, EventArgs e)
        {

            Tbl2 = new DataTable();

            Tbl2.Columns.Add("N°", typeof(int));
            Tbl2.Columns.Add("Código", typeof(int));
            Tbl2.Columns.Add("Descrição", typeof(string));
            Tbl2.Columns.Add("Estado", typeof(string));
            Tbl2.Columns.Add("Cidade", typeof(string));
            Tbl2.Columns.Add("Vagas Totais", typeof(string));
            Tbl2.Columns.Add("Url Mapa", typeof(string));    

            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM pontos t1 INNER JOIN estados t2 ON t1.id_estado = t2.cod_estado INNER JOIN cidades t3 ON t1.id_cidade = t3.cod_cidade", cnn);
            try
            {

                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        int Max = dataGridView2.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl2.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(5);
                        Linha[3] = myReader.GetString(8);
                        Linha[4] = myReader.GetString(11);
                        Linha[5] = myReader.GetString(4);
                        Linha[6] = myReader.GetString(6);

                        Tbl2.Rows.Add(Linha);


                        dataGridView2.DataSource = Tbl2;
                        
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

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmMenu area_menu = new frmMenu();

            area_menu.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmInseirPontos area_inserirPonto = new frmInseirPontos();

            area_inserirPonto.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDeletarPonto area_deletarPonto = new frmDeletarPonto();

            area_deletarPonto.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmEditarPonto area_editarPonto = new frmEditarPonto();

            area_editarPonto.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Tbl2.Clear();

            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM pontos t1 INNER JOIN estados t2 ON t1.id_estado = t2.cod_estado INNER JOIN cidades t3 ON t1.id_cidade = t3.cod_cidade", cnn);
            try
            {

                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        int Max = dataGridView2.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl2.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(5);
                        Linha[3] = myReader.GetString(8);
                        Linha[4] = myReader.GetString(11);
                        Linha[5] = myReader.GetString(4);
                        Linha[6] = myReader.GetString(6);

                        Tbl2.Rows.Add(Linha);


                        dataGridView2.DataSource = Tbl2;

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

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM pontos t1 INNER JOIN estados t2 ON t1.id_estado = t2.cod_estado INNER JOIN cidades t3 ON t1.id_cidade = t3.cod_cidade WHERE cod_ponto = @codPonto", cnn);
            try
            {
                comando.Parameters.AddWithValue("@codPonto", txtPesquisarPontos.Text);
                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    if (myReader.Read())
                    {
                        Tbl2.Clear();

                        int Max = dataGridView2.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl2.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(5);
                        Linha[3] = myReader.GetString(8);
                        Linha[4] = myReader.GetString(11);
                        Linha[5] = myReader.GetString(4);
                        Linha[6] = myReader.GetString(6);

                        Tbl2.Rows.Add(Linha);


                        dataGridView2.DataSource = Tbl2;

                    }
                    else
                    {
                        MessageBox.Show("Código não encontrado!");
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

        private void txtPesquisarPontos_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarPontos.Text == "")
            {
                Tbl2.Clear();

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando = new MySqlCommand("SELECT * FROM pontos t1 INNER JOIN estados t2 ON t1.id_estado = t2.cod_estado INNER JOIN cidades t3 ON t1.id_cidade = t3.cod_cidade", cnn);
                try
                {

                    cnn.Open();

                    MySqlDataReader myReader;
                    myReader = comando.ExecuteReader();
                    try
                    {
                        while (myReader.Read())
                        {
                            int Max = dataGridView2.Rows.Count + 1;

                            DataRow Linha;

                            Linha = Tbl2.NewRow();

                            Linha[0] = Max;
                            Linha[1] = myReader.GetInt32(0);
                            Linha[2] = myReader.GetString(5);
                            Linha[3] = myReader.GetString(8);
                            Linha[4] = myReader.GetString(11);
                            Linha[5] = myReader.GetString(4);
                            Linha[6] = myReader.GetString(6);

                            Tbl2.Rows.Add(Linha);


                            dataGridView2.DataSource = Tbl2;

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
        }
    }
}
