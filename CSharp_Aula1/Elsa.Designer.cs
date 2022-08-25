namespace CSharp_Aula1
{
    partial class Elsa
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
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(727, 10);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(64, 114);
            this.btnRetornar.TabIndex = 0;
            this.btnRetornar.Text = "Voltar para segunda página";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(727, 145);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(64, 114);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Ir para primeira página";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // Elsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnRetornar);
            this.Name = "Elsa";
            this.Text = "Elsa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnInicio;
    }
}