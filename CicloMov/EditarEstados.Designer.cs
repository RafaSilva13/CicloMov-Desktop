namespace CicloMov
{
    partial class frmEditarEstados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarEstados));
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodEstados = new System.Windows.Forms.TextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.barraClientes = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSiglaEstado = new System.Windows.Forms.TextBox();
            this.txtNomeEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.barraClientes)).BeginInit();
            this.barraClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Código";
            // 
            // txtCodEstados
            // 
            this.txtCodEstados.Location = new System.Drawing.Point(74, 62);
            this.txtCodEstados.Name = "txtCodEstados";
            this.txtCodEstados.Size = new System.Drawing.Size(100, 20);
            this.txtCodEstados.TabIndex = 49;
            this.txtCodEstados.TextChanged += new System.EventHandler(this.txtCodEstados_TextChanged);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 21);
            this.toolStripButton2.Text = "Confirmar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // barraClientes
            // 
            this.barraClientes.AddNewItem = null;
            this.barraClientes.CountItem = null;
            this.barraClientes.DeleteItem = null;
            this.barraClientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barraClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.bindingNavigatorSeparator1});
            this.barraClientes.Location = new System.Drawing.Point(0, 0);
            this.barraClientes.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.barraClientes.MoveFirstItem = null;
            this.barraClientes.MoveLastItem = null;
            this.barraClientes.MoveNextItem = null;
            this.barraClientes.MovePreviousItem = null;
            this.barraClientes.Name = "barraClientes";
            this.barraClientes.Padding = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.barraClientes.PositionItem = null;
            this.barraClientes.Size = new System.Drawing.Size(237, 25);
            this.barraClientes.TabIndex = 40;
            this.barraClientes.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 21);
            this.toolStripButton1.Text = "Voltar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(95, 21);
            this.toolStripLabel1.Text = "Editar Estados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nome Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Sigla";
            // 
            // txtSiglaEstado
            // 
            this.txtSiglaEstado.Location = new System.Drawing.Point(74, 153);
            this.txtSiglaEstado.Name = "txtSiglaEstado";
            this.txtSiglaEstado.Size = new System.Drawing.Size(47, 20);
            this.txtSiglaEstado.TabIndex = 51;
            // 
            // txtNomeEstado
            // 
            this.txtNomeEstado.Location = new System.Drawing.Point(74, 108);
            this.txtNomeEstado.Name = "txtNomeEstado";
            this.txtNomeEstado.Size = new System.Drawing.Size(100, 20);
            this.txtNomeEstado.TabIndex = 52;
            // 
            // frmEditarEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 204);
            this.Controls.Add(this.txtNomeEstado);
            this.Controls.Add(this.txtSiglaEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodEstados);
            this.Controls.Add(this.barraClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmEditarEstados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.frmEditarEstados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barraClientes)).EndInit();
            this.barraClientes.ResumeLayout(false);
            this.barraClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodEstados;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        public System.Windows.Forms.BindingNavigator barraClientes;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSiglaEstado;
        private System.Windows.Forms.TextBox txtNomeEstado;
    }
}