namespace A
{
    partial class feedback
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Hnão = new System.Windows.Forms.RadioButton();
            this.Hsim = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dimenor = new System.Windows.Forms.RadioButton();
            this.dimaior = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.heteroTop = new System.Windows.Forms.RadioButton();
            this.maquinaDeLavar = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Hnão);
            this.groupBox5.Controls.Add(this.Hsim);
            this.groupBox5.Location = new System.Drawing.Point(12, 228);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 90);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Está satisfeito com nosso produto?";
            // 
            // Hnão
            // 
            this.Hnão.AutoSize = true;
            this.Hnão.Location = new System.Drawing.Point(19, 52);
            this.Hnão.Name = "Hnão";
            this.Hnão.Size = new System.Drawing.Size(45, 17);
            this.Hnão.TabIndex = 1;
            this.Hnão.TabStop = true;
            this.Hnão.Text = "Não";
            this.Hnão.UseVisualStyleBackColor = true;
            // 
            // Hsim
            // 
            this.Hsim.AutoSize = true;
            this.Hsim.Location = new System.Drawing.Point(19, 24);
            this.Hsim.Name = "Hsim";
            this.Hsim.Size = new System.Drawing.Size(42, 17);
            this.Hsim.TabIndex = 0;
            this.Hsim.TabStop = true;
            this.Hsim.Text = "Sim";
            this.Hsim.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dimenor);
            this.groupBox4.Controls.Add(this.dimaior);
            this.groupBox4.Location = new System.Drawing.Point(12, 122);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 90);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Maior de Idade";
            // 
            // dimenor
            // 
            this.dimenor.AutoSize = true;
            this.dimenor.Location = new System.Drawing.Point(19, 52);
            this.dimenor.Name = "dimenor";
            this.dimenor.Size = new System.Drawing.Size(45, 17);
            this.dimenor.TabIndex = 1;
            this.dimenor.TabStop = true;
            this.dimenor.Text = "Não";
            this.dimenor.UseVisualStyleBackColor = true;
            // 
            // dimaior
            // 
            this.dimaior.AutoSize = true;
            this.dimaior.Location = new System.Drawing.Point(19, 24);
            this.dimaior.Name = "dimaior";
            this.dimaior.Size = new System.Drawing.Size(42, 17);
            this.dimaior.TabIndex = 0;
            this.dimaior.TabStop = true;
            this.dimaior.Text = "Sim";
            this.dimaior.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.heteroTop);
            this.groupBox3.Controls.Add(this.maquinaDeLavar);
            this.groupBox3.Location = new System.Drawing.Point(12, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 90);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexo";
            // 
            // heteroTop
            // 
            this.heteroTop.AutoSize = true;
            this.heteroTop.Location = new System.Drawing.Point(19, 52);
            this.heteroTop.Name = "heteroTop";
            this.heteroTop.Size = new System.Drawing.Size(34, 17);
            this.heteroTop.TabIndex = 1;
            this.heteroTop.TabStop = true;
            this.heteroTop.Text = "M";
            this.heteroTop.UseVisualStyleBackColor = true;
            // 
            // maquinaDeLavar
            // 
            this.maquinaDeLavar.AutoSize = true;
            this.maquinaDeLavar.Location = new System.Drawing.Point(19, 24);
            this.maquinaDeLavar.Name = "maquinaDeLavar";
            this.maquinaDeLavar.Size = new System.Drawing.Size(31, 17);
            this.maquinaDeLavar.TabIndex = 0;
            this.maquinaDeLavar.TabStop = true;
            this.maquinaDeLavar.Text = "F";
            this.maquinaDeLavar.UseVisualStyleBackColor = true;
            this.maquinaDeLavar.CheckedChanged += new System.EventHandler(this.MaquinaDeLavar_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 348);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 90);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Deixe seu comentario (Opcional)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "feedback";
            this.Text = "feedback";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton Hnão;
        private System.Windows.Forms.RadioButton Hsim;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton dimenor;
        private System.Windows.Forms.RadioButton dimaior;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton heteroTop;
        private System.Windows.Forms.RadioButton maquinaDeLavar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}