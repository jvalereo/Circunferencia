namespace AreaCircunferencia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRaio = new System.Windows.Forms.Label();
            this.textBoxRaio = new System.Windows.Forms.TextBox();
            this.lblPi = new System.Windows.Forms.Label();
            this.textBoxPi = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClique = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(63, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcule Area da Circunfência";
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaio.Location = new System.Drawing.Point(32, 113);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(154, 20);
            this.lblRaio.TabIndex = 1;
            this.lblRaio.Text = "Digite o numero do raio:";
            // 
            // textBoxRaio
            // 
            this.textBoxRaio.Location = new System.Drawing.Point(35, 140);
            this.textBoxRaio.Name = "textBoxRaio";
            this.textBoxRaio.Size = new System.Drawing.Size(151, 20);
            this.textBoxRaio.TabIndex = 2;
            // 
            // lblPi
            // 
            this.lblPi.AutoSize = true;
            this.lblPi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPi.Location = new System.Drawing.Point(35, 179);
            this.lblPi.Name = "lblPi";
            this.lblPi.Size = new System.Drawing.Size(147, 20);
            this.lblPi.TabIndex = 3;
            this.lblPi.Text = "Digite o numero de pi: ";
            // 
            // textBoxPi
            // 
            this.textBoxPi.Location = new System.Drawing.Point(38, 204);
            this.textBoxPi.Name = "textBoxPi";
            this.textBoxPi.Size = new System.Drawing.Size(148, 20);
            this.textBoxPi.TabIndex = 4;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(140, 269);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 34);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(240, 269);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 34);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AreaCircunferencia.Properties.Resources.area_circulo;
            this.pictureBox1.Location = new System.Drawing.Point(188, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnClique
            // 
            this.btnClique.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClique.Location = new System.Drawing.Point(39, 269);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(84, 34);
            this.btnClique.TabIndex = 9;
            this.btnClique.Text = "Clique";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 327);
            this.ControlBox = false;
            this.Controls.Add(this.btnClique);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.textBoxPi);
            this.Controls.Add(this.lblPi);
            this.Controls.Add(this.textBoxRaio);
            this.Controls.Add(this.lblRaio);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area da Circunferncia ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.TextBox textBoxRaio;
        private System.Windows.Forms.Label lblPi;
        private System.Windows.Forms.TextBox textBoxPi;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClique;
    }
}

