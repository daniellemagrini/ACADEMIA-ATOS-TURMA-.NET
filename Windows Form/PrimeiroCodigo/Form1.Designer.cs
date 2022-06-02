namespace PrimeiroCodigo
{
    partial class form_aplicacao
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
            this.botaook = new System.Windows.Forms.Button();
            this.botaocancelar = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_endereco = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.lb_celular = new System.Windows.Forms.Label();
            this.tb_celular = new System.Windows.Forms.TextBox();
            this.lb_sexo = new System.Windows.Forms.Label();
            this.tb_sexo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaook
            // 
            this.botaook.Location = new System.Drawing.Point(35, 187);
            this.botaook.Name = "botaook";
            this.botaook.Size = new System.Drawing.Size(116, 28);
            this.botaook.TabIndex = 5;
            this.botaook.Tag = "";
            this.botaook.Text = "OK";
            this.botaook.UseVisualStyleBackColor = true;
            this.botaook.Click += new System.EventHandler(this.botaook_Click);
            // 
            // botaocancelar
            // 
            this.botaocancelar.Location = new System.Drawing.Point(199, 187);
            this.botaocancelar.Name = "botaocancelar";
            this.botaocancelar.Size = new System.Drawing.Size(116, 28);
            this.botaocancelar.TabIndex = 6;
            this.botaocancelar.Tag = "";
            this.botaocancelar.Text = "CANCELAR";
            this.botaocancelar.UseVisualStyleBackColor = true;
            this.botaocancelar.Click += new System.EventHandler(this.botaocancelar_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(87, 27);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(228, 20);
            this.tb_nome.TabIndex = 0;
            this.tb_nome.Tag = "";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(28, 30);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(38, 13);
            this.lb_nome.TabIndex = 3;
            this.lb_nome.Text = "Nome:";
            this.lb_nome.Click += new System.EventHandler(this.lb_nome_Click);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(32, 62);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(35, 13);
            this.lb_email.TabIndex = 4;
            this.lb_email.Text = "Email:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(87, 58);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(228, 20);
            this.tb_email.TabIndex = 1;
            this.tb_email.Tag = "";
            // 
            // lb_endereco
            // 
            this.lb_endereco.AutoSize = true;
            this.lb_endereco.Location = new System.Drawing.Point(32, 92);
            this.lb_endereco.Name = "lb_endereco";
            this.lb_endereco.Size = new System.Drawing.Size(56, 13);
            this.lb_endereco.TabIndex = 6;
            this.lb_endereco.Text = "Endereço:";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(87, 89);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(228, 20);
            this.tb_endereco.TabIndex = 2;
            this.tb_endereco.Tag = "";
            // 
            // lb_celular
            // 
            this.lb_celular.AutoSize = true;
            this.lb_celular.Location = new System.Drawing.Point(32, 123);
            this.lb_celular.Name = "lb_celular";
            this.lb_celular.Size = new System.Drawing.Size(42, 13);
            this.lb_celular.TabIndex = 8;
            this.lb_celular.Text = "Celular:";
            // 
            // tb_celular
            // 
            this.tb_celular.Location = new System.Drawing.Point(87, 120);
            this.tb_celular.Name = "tb_celular";
            this.tb_celular.Size = new System.Drawing.Size(228, 20);
            this.tb_celular.TabIndex = 3;
            this.tb_celular.Tag = "";
            // 
            // lb_sexo
            // 
            this.lb_sexo.AutoSize = true;
            this.lb_sexo.Location = new System.Drawing.Point(32, 152);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(34, 13);
            this.lb_sexo.TabIndex = 10;
            this.lb_sexo.Text = "Sexo:";
            // 
            // tb_sexo
            // 
            this.tb_sexo.Location = new System.Drawing.Point(87, 152);
            this.tb_sexo.Name = "tb_sexo";
            this.tb_sexo.Size = new System.Drawing.Size(228, 20);
            this.tb_sexo.TabIndex = 4;
            this.tb_sexo.Tag = "";
            // 
            // form_aplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 229);
            this.Controls.Add(this.tb_sexo);
            this.Controls.Add(this.lb_sexo);
            this.Controls.Add(this.tb_celular);
            this.Controls.Add(this.lb_celular);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.lb_endereco);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.botaocancelar);
            this.Controls.Add(this.botaook);
            this.Name = "form_aplicacao";
            this.Text = "Aplicativo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaook;
        private System.Windows.Forms.Button botaocancelar;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_endereco;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label lb_celular;
        private System.Windows.Forms.TextBox tb_celular;
        private System.Windows.Forms.Label lb_sexo;
        private System.Windows.Forms.TextBox tb_sexo;
    }
}

