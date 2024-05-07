namespace A
{
    partial class Calc
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
            this.sequenciaN = new System.Windows.Forms.Label();
            this.histo_sinal = new System.Windows.Forms.Label();
            this.histo = new System.Windows.Forms.Label();
            this.numeros = new System.Windows.Forms.Label();
            this.mais = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.vezes = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.dividido = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.nove = new System.Windows.Forms.Button();
            this.oito = new System.Windows.Forms.Button();
            this.sete = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.dois = new System.Windows.Forms.Button();
            this.quatro = new System.Windows.Forms.Button();
            this.um = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sequenciaN
            // 
            this.sequenciaN.AutoSize = true;
            this.sequenciaN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sequenciaN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sequenciaN.Location = new System.Drawing.Point(39, 98);
            this.sequenciaN.Name = "sequenciaN";
            this.sequenciaN.Size = new System.Drawing.Size(13, 20);
            this.sequenciaN.TabIndex = 48;
            this.sequenciaN.Text = " ";
            // 
            // histo_sinal
            // 
            this.histo_sinal.AutoSize = true;
            this.histo_sinal.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histo_sinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.histo_sinal.Location = new System.Drawing.Point(591, 91);
            this.histo_sinal.Name = "histo_sinal";
            this.histo_sinal.Size = new System.Drawing.Size(13, 20);
            this.histo_sinal.TabIndex = 47;
            this.histo_sinal.Text = " ";
            this.histo_sinal.Visible = false;
            // 
            // histo
            // 
            this.histo.AutoSize = true;
            this.histo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.histo.Location = new System.Drawing.Point(591, 71);
            this.histo.Name = "histo";
            this.histo.Size = new System.Drawing.Size(17, 20);
            this.histo.TabIndex = 46;
            this.histo.Text = "  ";
            this.histo.Visible = false;
            // 
            // numeros
            // 
            this.numeros.AutoSize = true;
            this.numeros.Font = new System.Drawing.Font("Microsoft New Tai Lue", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numeros.Location = new System.Drawing.Point(23, 15);
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(0, 88);
            this.numeros.TabIndex = 45;
            // 
            // mais
            // 
            this.mais.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mais.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.mais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mais.Location = new System.Drawing.Point(595, 313);
            this.mais.Name = "mais";
            this.mais.Size = new System.Drawing.Size(186, 58);
            this.mais.TabIndex = 44;
            this.mais.Text = "+";
            this.mais.UseVisualStyleBackColor = false;
            this.mais.Click += new System.EventHandler(this.Mais_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.SystemColors.Highlight;
            this.igual.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.igual.Location = new System.Drawing.Point(403, 377);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(378, 58);
            this.igual.TabIndex = 43;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(19, 377);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(378, 58);
            this.zero.TabIndex = 42;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // vezes
            // 
            this.vezes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vezes.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.vezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vezes.Location = new System.Drawing.Point(595, 185);
            this.vezes.Name = "vezes";
            this.vezes.Size = new System.Drawing.Size(186, 58);
            this.vezes.TabIndex = 41;
            this.vezes.Text = "x";
            this.vezes.UseVisualStyleBackColor = false;
            this.vezes.Click += new System.EventHandler(this.Vezes_Click);
            // 
            // menos
            // 
            this.menos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menos.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menos.Location = new System.Drawing.Point(595, 249);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(186, 58);
            this.menos.TabIndex = 40;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = false;
            this.menos.Click += new System.EventHandler(this.Menos_Click);
            // 
            // apagar
            // 
            this.apagar.BackColor = System.Drawing.Color.Transparent;
            this.apagar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apagar.Location = new System.Drawing.Point(403, 121);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(186, 58);
            this.apagar.TabIndex = 39;
            this.apagar.Text = "APAGAR";
            this.apagar.UseVisualStyleBackColor = false;
            this.apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // dividido
            // 
            this.dividido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dividido.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.dividido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dividido.Location = new System.Drawing.Point(595, 121);
            this.dividido.Name = "dividido";
            this.dividido.Size = new System.Drawing.Size(186, 58);
            this.dividido.TabIndex = 38;
            this.dividido.Text = "/";
            this.dividido.UseVisualStyleBackColor = false;
            this.dividido.Click += new System.EventHandler(this.Dividido_Click);
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.limpar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpar.Location = new System.Drawing.Point(19, 121);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(378, 58);
            this.limpar.TabIndex = 37;
            this.limpar.Text = "CE";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // nove
            // 
            this.nove.Location = new System.Drawing.Point(403, 185);
            this.nove.Name = "nove";
            this.nove.Size = new System.Drawing.Size(186, 58);
            this.nove.TabIndex = 36;
            this.nove.Text = "9";
            this.nove.UseVisualStyleBackColor = true;
            this.nove.Click += new System.EventHandler(this.Nove_Click);
            // 
            // oito
            // 
            this.oito.Location = new System.Drawing.Point(211, 185);
            this.oito.Name = "oito";
            this.oito.Size = new System.Drawing.Size(186, 58);
            this.oito.TabIndex = 35;
            this.oito.Text = "8";
            this.oito.UseVisualStyleBackColor = true;
            this.oito.Click += new System.EventHandler(this.Oito_Click);
            // 
            // sete
            // 
            this.sete.Location = new System.Drawing.Point(19, 185);
            this.sete.Name = "sete";
            this.sete.Size = new System.Drawing.Size(186, 58);
            this.sete.TabIndex = 34;
            this.sete.Text = "7";
            this.sete.UseVisualStyleBackColor = true;
            this.sete.Click += new System.EventHandler(this.Sete_Click);
            // 
            // seis
            // 
            this.seis.Location = new System.Drawing.Point(403, 249);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(186, 58);
            this.seis.TabIndex = 33;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.Seis_Click);
            // 
            // cinco
            // 
            this.cinco.Location = new System.Drawing.Point(211, 249);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(186, 58);
            this.cinco.TabIndex = 32;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.Cinco_Click);
            // 
            // tres
            // 
            this.tres.Location = new System.Drawing.Point(403, 313);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(186, 58);
            this.tres.TabIndex = 31;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.Tres_Click);
            // 
            // dois
            // 
            this.dois.Location = new System.Drawing.Point(211, 313);
            this.dois.Name = "dois";
            this.dois.Size = new System.Drawing.Size(186, 58);
            this.dois.TabIndex = 29;
            this.dois.Text = "2";
            this.dois.UseVisualStyleBackColor = true;
            this.dois.Click += new System.EventHandler(this.Dois_Click);
            // 
            // quatro
            // 
            this.quatro.Location = new System.Drawing.Point(19, 249);
            this.quatro.Name = "quatro";
            this.quatro.Size = new System.Drawing.Size(186, 58);
            this.quatro.TabIndex = 30;
            this.quatro.Text = "4";
            this.quatro.UseVisualStyleBackColor = true;
            this.quatro.Click += new System.EventHandler(this.Quatro_Click);
            // 
            // um
            // 
            this.um.Location = new System.Drawing.Point(19, 313);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(186, 58);
            this.um.TabIndex = 28;
            this.um.Text = "1";
            this.um.UseVisualStyleBackColor = true;
            this.um.Click += new System.EventHandler(this.Um_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sequenciaN);
            this.Controls.Add(this.histo_sinal);
            this.Controls.Add(this.histo);
            this.Controls.Add(this.numeros);
            this.Controls.Add(this.mais);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.vezes);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.dividido);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.nove);
            this.Controls.Add(this.oito);
            this.Controls.Add(this.sete);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dois);
            this.Controls.Add(this.quatro);
            this.Controls.Add(this.um);
            this.Name = "Calc";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sequenciaN;
        private System.Windows.Forms.Label histo_sinal;
        private System.Windows.Forms.Label histo;
        private System.Windows.Forms.Label numeros;
        private System.Windows.Forms.Button mais;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button vezes;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button dividido;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button nove;
        private System.Windows.Forms.Button oito;
        private System.Windows.Forms.Button sete;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button dois;
        private System.Windows.Forms.Button quatro;
        private System.Windows.Forms.Button um;
    }
}