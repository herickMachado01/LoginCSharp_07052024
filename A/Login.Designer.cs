namespace A
{
    partial class Login
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
            this.Entrar = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.erro = new System.Windows.Forms.Label();
            this.robo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(190, 214);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 0;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(151, 122);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(154, 20);
            this.User.TabIndex = 1;
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(151, 167);
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '•';
            this.Senha.Size = new System.Drawing.Size(154, 20);
            this.Senha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "BEM VINDO!";
            // 
            // erro
            // 
            this.erro.AutoSize = true;
            this.erro.ForeColor = System.Drawing.Color.Red;
            this.erro.Location = new System.Drawing.Point(123, 243);
            this.erro.Name = "erro";
            this.erro.Size = new System.Drawing.Size(215, 13);
            this.erro.TabIndex = 7;
            this.erro.Text = "User ou senha incorretos! Tente novamente";
            this.erro.Visible = false;
            // 
            // robo
            // 
            this.robo.AutoSize = true;
            this.robo.Location = new System.Drawing.Point(173, 195);
            this.robo.Name = "robo";
            this.robo.Size = new System.Drawing.Size(106, 17);
            this.robo.TabIndex = 8;
            this.robo.TabStop = true;
            this.robo.Text = "Não sou um robo";
            this.robo.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 322);
            this.Controls.Add(this.robo);
            this.Controls.Add(this.erro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Entrar);
            this.Name = "Login";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label erro;
        private System.Windows.Forms.RadioButton robo;
    }
}