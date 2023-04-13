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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (text_login_usuario.Text == "" || text_login_senha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para prosseguir!");
            }
            else
            {
                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;database=bd_estacionamento");
                MySqlCommand comando = new MySqlCommand("SELECT * FROM administradores WHERE usuario_administrador = @usuario and senha_administrador = @senha", cnn);
                try
                {

                    comando.Parameters.AddWithValue("@usuario", text_login_usuario.Text);
                    comando.Parameters.AddWithValue("@senha", text_login_senha.Text);

                    cnn.Open();

                    MySqlDataReader myReader;
                    myReader = comando.ExecuteReader();
                    try
                    {
                        if (myReader.Read())
                        {
                            this.Hide();

                            frmMenu menu = new frmMenu();

                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos!\n\nTente novamente");
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
                    MessageBox.Show("Usuário ou senha incorretos!\n\nTente novamente");
                }
            }
        }
    }
}
