﻿namespace CSharp_Aula1
{
    partial class Jafar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.btnUniao = new System.Windows.Forms.Button();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnValorizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContagem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.btnMudar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 8);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(268, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(96, 64);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(268, 20);
            this.txtSobrenome.TabIndex = 0;
            // 
            // btnUniao
            // 
            this.btnUniao.Location = new System.Drawing.Point(96, 141);
            this.btnUniao.Name = "btnUniao";
            this.btnUniao.Size = new System.Drawing.Size(268, 54);
            this.btnUniao.TabIndex = 1;
            this.btnUniao.Text = "Unir nomes";
            this.btnUniao.UseVisualStyleBackColor = true;
            this.btnUniao.Click += new System.EventHandler(this.btnUniao_Click);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(96, 233);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(268, 20);
            this.txtNomeCompleto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome completo";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(555, 8);
            this.txtN1.Multiline = true;
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(45, 20);
            this.txtN1.TabIndex = 3;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(555, 64);
            this.txtN2.Multiline = true;
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(45, 20);
            this.txtN2.TabIndex = 3;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(477, 233);
            this.txtN3.Multiline = true;
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(194, 20);
            this.txtN3.TabIndex = 3;
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(501, 139);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(48, 56);
            this.btnSoma.TabIndex = 4;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "N1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "N2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resultado";
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(621, 139);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(50, 55);
            this.btnSomar.TabIndex = 6;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(477, 315);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(217, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(96, 315);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(217, 20);
            this.txtValor.TabIndex = 7;
            // 
            // btnValorizar
            // 
            this.btnValorizar.Location = new System.Drawing.Point(339, 315);
            this.btnValorizar.Name = "btnValorizar";
            this.btnValorizar.Size = new System.Drawing.Size(103, 20);
            this.btnValorizar.TabIndex = 8;
            this.btnValorizar.Text = "Valorizar";
            this.btnValorizar.UseVisualStyleBackColor = true;
            this.btnValorizar.Click += new System.EventHandler(this.btnValorizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(726, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Valor";
            // 
            // txtContagem
            // 
            this.txtContagem.Location = new System.Drawing.Point(326, 377);
            this.txtContagem.Name = "txtContagem";
            this.txtContagem.Size = new System.Drawing.Size(127, 20);
            this.txtContagem.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Quantidade de somas";
            // 
            // btnTrocar
            // 
            this.btnTrocar.Location = new System.Drawing.Point(383, 98);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(70, 97);
            this.btnTrocar.TabIndex = 12;
            this.btnTrocar.Text = "Ir para próxima página";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // btnMudar
            // 
            this.btnMudar.Location = new System.Drawing.Point(383, 2);
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.Size = new System.Drawing.Size(70, 90);
            this.btnMudar.TabIndex = 13;
            this.btnMudar.Text = "Ir para terceira página";
            this.btnMudar.UseVisualStyleBackColor = true;
            this.btnMudar.Click += new System.EventHandler(this.btnMudar_Click);
            // 
            // Jafar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMudar);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtContagem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnValorizar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUniao);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Name = "Jafar";
            this.Text = " Ezequiel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Button btnUniao;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnValorizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContagem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.Button btnMudar;
    }
}

