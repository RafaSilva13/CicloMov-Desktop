using System.Drawing;
using System.Windows.Forms;

namespace CicloMov
{
    partial class frmMenu
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
            this.btnAreaClientes = new System.Windows.Forms.Button();
            this.btnAreaPontos = new System.Windows.Forms.Button();
            this.btnAreaEstados = new System.Windows.Forms.Button();
            this.btnAreaCidades = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAreaServicos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAreaClientes
            // 
            this.btnAreaClientes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreaClientes.Location = new System.Drawing.Point(11, 60);
            this.btnAreaClientes.Name = "btnAreaClientes";
            this.btnAreaClientes.Size = new System.Drawing.Size(149, 23);
            this.btnAreaClientes.TabIndex = 0;
            this.btnAreaClientes.Text = "Clientes";
            this.btnAreaClientes.UseVisualStyleBackColor = true;
            this.btnAreaClientes.Click += new System.EventHandler(this.btnAreaClientes_Click);
            // 
            // btnAreaPontos
            // 
            this.btnAreaPontos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAreaPontos.Location = new System.Drawing.Point(11, 89);
            this.btnAreaPontos.Name = "btnAreaPontos";
            this.btnAreaPontos.Size = new System.Drawing.Size(149, 23);
            this.btnAreaPontos.TabIndex = 1;
            this.btnAreaPontos.Text = "Pontos";
            this.btnAreaPontos.UseVisualStyleBackColor = true;
            this.btnAreaPontos.Click += new System.EventHandler(this.btnAreaPontos_Click);
            // 
            // btnAreaEstados
            // 
            this.btnAreaEstados.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAreaEstados.Location = new System.Drawing.Point(166, 89);
            this.btnAreaEstados.Name = "btnAreaEstados";
            this.btnAreaEstados.Size = new System.Drawing.Size(149, 23);
            this.btnAreaEstados.TabIndex = 2;
            this.btnAreaEstados.Text = "Estados";
            this.btnAreaEstados.UseVisualStyleBackColor = true;
            this.btnAreaEstados.Click += new System.EventHandler(this.btnAreaEstados_Click);
            // 
            // btnAreaCidades
            // 
            this.btnAreaCidades.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAreaCidades.Location = new System.Drawing.Point(166, 60);
            this.btnAreaCidades.Name = "btnAreaCidades";
            this.btnAreaCidades.Size = new System.Drawing.Size(149, 23);
            this.btnAreaCidades.TabIndex = 3;
            this.btnAreaCidades.Text = "Cidades";
            this.btnAreaCidades.UseVisualStyleBackColor = true;
            this.btnAreaCidades.Click += new System.EventHandler(this.btnAreaCidades_Click);
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F.Location = new System.Drawing.Point(12, 41);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(52, 14);
            this.F.TabIndex = 4;
            this.F.Text = "Opcões:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gerênciamento de Áreas";
            // 
            // btnAreaServicos
            // 
            this.btnAreaServicos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAreaServicos.Location = new System.Drawing.Point(11, 119);
            this.btnAreaServicos.Name = "btnAreaServicos";
            this.btnAreaServicos.Size = new System.Drawing.Size(304, 23);
            this.btnAreaServicos.TabIndex = 6;
            this.btnAreaServicos.Text = "Serviços";
            this.btnAreaServicos.UseVisualStyleBackColor = true;
            this.btnAreaServicos.Click += new System.EventHandler(this.btnAreaServicos_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(324, 153);
            this.Controls.Add(this.btnAreaServicos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F);
            this.Controls.Add(this.btnAreaCidades);
            this.Controls.Add(this.btnAreaEstados);
            this.Controls.Add(this.btnAreaPontos);
            this.Controls.Add(this.btnAreaClientes);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAreaClientes;
        private System.Windows.Forms.Button btnAreaPontos;
        private System.Windows.Forms.Button btnAreaEstados;
        private System.Windows.Forms.Button btnAreaCidades;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAreaServicos;
    }
}