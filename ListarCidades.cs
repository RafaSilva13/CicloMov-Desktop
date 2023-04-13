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

namespace CicloMov
{
    public partial class frmListarCidades : Form
    {
        DataTable Tbl3;
        public frmListarCidades()
        {
            InitializeComponent();
        }
        private void frmListarCidades_Load(object sender, EventArgs e)
        {
            Tbl3 = new DataTable();

            Tbl3.Columns.Add("      N°   ", typeof(int));
            Tbl3.Columns.Add("Código", typeof(int));
            Tbl3.Columns.Add("Nome da Cidade", typeof(string));
            Tbl3.Columns.Add("  Estado  ", typeof(string));

            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM cidades c1 INNER JOIN estados c2 ON c1.id_estado = c2.cod_estado;", cnn);
            try
            {

                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {

                        int Max = dataGridView3.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl3.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(2);
                        Linha[3] = myReader.GetString(4);

                        Tbl3.Rows.Add(Linha);
                        dataGridView3.DataSource = Tbl3;

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

        private void txtPesquisarCidades_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarCidades.Text == "")
            {
                Tbl3.Clear();

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando = new MySqlCommand("SELECT * FROM cidades c1 INNER JOIN estados c2 ON c1.id_estado = c2.cod_estado;", cnn);
                try
                {

                    cnn.Open();

                    MySqlDataReader myReader;
                    myReader = comando.ExecuteReader();
                    try
                    {
                        while (myReader.Read())
                        {
                            int Max = dataGridView3.Rows.Count + 1;

                            DataRow Linha;

                            Linha = Tbl3.NewRow();

                            Linha[0] = Max;
                            Linha[1] = myReader.GetInt32(0);
                            Linha[2] = myReader.GetString(2);
                            Linha[3] = myReader.GetString(4);

                            Tbl3.Rows.Add(Linha);

                            dataGridView3.DataSource = Tbl3;

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

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM cidades c1 INNER JOIN estados c2 ON c1.id_estado = c2.cod_estado WHERE c1.descricao_cidade = @descricao", cnn);
            try
            {
                comando.Parameters.AddWithValue("@descricao", txtPesquisarCidades.Text);
                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    if (myReader.Read())
                    {
                        Tbl3.Clear();

                        int Max = dataGridView3.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl3.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(2);
                        Linha[3] = myReader.GetString(4);

                        Tbl3.Rows.Add(Linha);


                        dataGridView3.DataSource = Tbl3;

                    }
                    else
                    {
                        MessageBox.Show("Nome não encontrado!");
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Tbl3.Clear();

            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM cidades c1 INNER JOIN estados c2 ON c1.id_estado = c2.cod_estado;", cnn);
            try
            {

                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {

                        int Max = dataGridView3.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl3.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(2);
                        Linha[3] = myReader.GetString(4);

                        Tbl3.Rows.Add(Linha);
                        dataGridView3.DataSource = Tbl3;

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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmInserirCidades area_InserirCidades = new frmInserirCidades();

            area_InserirCidades.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDeletarCidades area_DeletarCidades = new frmDeletarCidades();

            area_DeletarCidades.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmEditarCidades area_EditarCidades = new frmEditarCidades();

            area_EditarCidades.Show();
        }
    }
}
