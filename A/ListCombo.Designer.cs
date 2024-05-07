namespace A
{
    partial class ListCombo
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
            this.Excluidos = new System.Windows.Forms.ListBox();
            this.produtos = new System.Windows.Forms.ComboBox();
            this.excluir = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Excluidos
            // 
            this.Excluidos.FormattingEnabled = true;
            this.Excluidos.Location = new System.Drawing.Point(12, 172);
            this.Excluidos.Name = "Excluidos";
            this.Excluidos.Size = new System.Drawing.Size(253, 186);
            this.Excluidos.TabIndex = 0;
            this.Excluidos.SelectedIndexChanged += new System.EventHandler(this.Excluidos_SelectedIndexChanged);
            // 
            // produtos
            // 
            this.produtos.FormattingEnabled = true;
            this.produtos.Items.AddRange(new object[] {
            "Camisa",
            "Blusa",
            "Bermuda",
            "Calca",
            "Jaqueta",
            "Tenis"});
            this.produtos.Location = new System.Drawing.Point(12, 87);
            this.produtos.Name = "produtos";
            this.produtos.Size = new System.Drawing.Size(253, 21);
            this.produtos.TabIndex = 2;
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(12, 116);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(75, 23);
            this.excluir.TabIndex = 3;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 55);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 4;
            this.add.Text = "Adicionar";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(12, 27);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(253, 20);
            this.nome.TabIndex = 5;
            this.nome.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produtos Excluidos";
            // 
            // ListCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.add);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.produtos);
            this.Controls.Add(this.Excluidos);
            this.Name = "ListCombo";
            this.Text = "ListCombo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Excluidos;
        private System.Windows.Forms.ComboBox produtos;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}