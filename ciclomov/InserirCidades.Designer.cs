namespace CicloMov
{
    partial class frmInserirCidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirCidades));
            this.barraClientes = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barraClientes)).BeginInit();
            this.barraClientes.SuspendLayout();
            this.SuspendLayout();
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
            this.barraClientes.Size = new System.Drawing.Size(251, 25);
            this.barraClientes.TabIndex = 27;
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
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 21);
            this.toolStripLabel1.Text = "Inserir Cidades";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.Location = new System.Drawing.Point(80, 117);
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCidade.TabIndex = 26;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(80, 72);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(100, 21);
            this.cbxEstado.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nome Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Estado";
            // 
            // frmInserirCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 186);
            this.Controls.Add(this.barraClientes);
            this.Controls.Add(this.txtNomeCidade);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInserirCidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir";
            this.Load += new System.EventHandler(this.frmInserirCidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barraClientes)).EndInit();
            this.barraClientes.ResumeLayout(false);
            this.barraClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.BindingNavigator barraClientes;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.TextBox txtNomeCidade;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}