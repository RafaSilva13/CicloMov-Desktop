namespace CicloMov
{
    partial class frmDeletarPonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeletarPonto));
            this.txtCodigoDeletarPonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barraClientes = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ckbConfirmacaoPonto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.barraClientes)).BeginInit();
            this.barraClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigoDeletarPonto
            // 
            this.txtCodigoDeletarPonto.Location = new System.Drawing.Point(74, 78);
            this.txtCodigoDeletarPonto.Name = "txtCodigoDeletarPonto";
            this.txtCodigoDeletarPonto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDeletarPonto.TabIndex = 0;
            this.txtCodigoDeletarPonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoDeletarPonto.TextChanged += new System.EventHandler(this.txtCodigoDeletarPonto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o Código a ser deletado";
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
            this.barraClientes.TabIndex = 17;
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
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 21);
            this.toolStripLabel1.Text = "Deletar Pontos";
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
            // ckbConfirmacaoPonto
            // 
            this.ckbConfirmacaoPonto.AutoSize = true;
            this.ckbConfirmacaoPonto.Location = new System.Drawing.Point(40, 104);
            this.ckbConfirmacaoPonto.Name = "ckbConfirmacaoPonto";
            this.ckbConfirmacaoPonto.Size = new System.Drawing.Size(170, 17);
            this.ckbConfirmacaoPonto.TabIndex = 18;
            this.ckbConfirmacaoPonto.Text = "Sim, desejo deletar esse ponto";
            this.ckbConfirmacaoPonto.UseVisualStyleBackColor = true;
            // 
            // frmDeletarPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 186);
            this.Controls.Add(this.ckbConfirmacaoPonto);
            this.Controls.Add(this.barraClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoDeletarPonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeletarPonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar";
            this.Load += new System.EventHandler(this.frmDeletarPonto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barraClientes)).EndInit();
            this.barraClientes.ResumeLayout(false);
            this.barraClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoDeletarPonto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.BindingNavigator barraClientes;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.CheckBox ckbConfirmacaoPonto;
    }
}