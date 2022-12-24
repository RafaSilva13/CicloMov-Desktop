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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public partial class CustomizeFormExample : frmListarClientes
        {
            Color BorderColor = Color.Green;
        }

        private void btnAreaClientes_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarClientes area_clientes = new frmListarClientes();

            area_clientes.Show();
        }

        private void btnAreaPontos_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarPontos area_pontos = new frmListarPontos();

            area_pontos.Show();
        }

        private void btnAreaEstados_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarEstados area_estados = new frmListarEstados();

            area_estados.Show();
        }

        private void btnAreaCidades_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarCidades area_cidades = new frmListarCidades();

            area_cidades.Show();
        }

        private void btnAreaServicos_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmListarServicos area_servicos = new frmListarServicos();

            area_servicos.Show();
        }
    }
}
