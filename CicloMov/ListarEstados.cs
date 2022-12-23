﻿using System;
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
    public partial class frmListarEstados : Form
    {
        DataTable Tbl4;
        public frmListarEstados()
        {
            InitializeComponent();
        }
        private void frmListarEstados_Load(object sender, EventArgs e)
        {
            Tbl4 = new DataTable();

            Tbl4.Columns.Add(" N° ", typeof(int));
            Tbl4.Columns.Add("Código do Estado", typeof(int));
            Tbl4.Columns.Add("Nome do Estado", typeof(string));
            Tbl4.Columns.Add("Sigla", typeof(string));

            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM estados", cnn);
            try
            {

                cnn.Open();

                MySqlDataReader myReader;
                myReader = comando.ExecuteReader();
                try
                {
                    while (myReader.Read())
                    {
                        int Max = dataGridView4.Rows.Count + 1;

                        DataRow Linha;

                        Linha = Tbl4.NewRow();

                        Linha[0] = Max;
                        Linha[1] = myReader.GetInt32(0);
                        Linha[2] = myReader.GetString(1);
                        Linha[3] = myReader.GetString(2);

                        Tbl4.Rows.Add(Linha);
                        dataGridView4.DataSource = Tbl4;

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
    }
}
