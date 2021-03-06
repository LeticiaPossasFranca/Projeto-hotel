
namespace ProjetoHotel
{
    partial class Frm_AtualizaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AtualizaUsuarios));
            this.msk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.msk_rg = new System.Windows.Forms.MaskedTextBox();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.msk_numero = new System.Windows.Forms.MaskedTextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            this.cmb_ativo = new System.Windows.Forms.ComboBox();
            this.lbl_ativo = new System.Windows.Forms.Label();
            this.lbl_pesquisa = new System.Windows.Forms.Label();
            this.lbl_criterio = new System.Windows.Forms.Label();
            this.cmb_criterio = new System.Windows.Forms.ComboBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.msk_pesquisa = new System.Windows.Forms.MaskedTextBox();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // msk_telefone
            // 
            this.msk_telefone.Location = new System.Drawing.Point(797, 205);
            this.msk_telefone.Margin = new System.Windows.Forms.Padding(4);
            this.msk_telefone.Mask = "(99)00000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(184, 31);
            this.msk_telefone.TabIndex = 26;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(101, 281);
            this.txt_rua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rua.Multiline = true;
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(166, 31);
            this.txt_rua.TabIndex = 25;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(101, 205);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.MaxLength = 50;
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(438, 31);
            this.txt_nome.TabIndex = 24;
            // 
            // msk_rg
            // 
            this.msk_rg.Location = new System.Drawing.Point(588, 205);
            this.msk_rg.Margin = new System.Windows.Forms.Padding(4);
            this.msk_rg.Mask = "99,999,999-9";
            this.msk_rg.Name = "msk_rg";
            this.msk_rg.Size = new System.Drawing.Size(148, 31);
            this.msk_rg.TabIndex = 23;
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(583, 176);
            this.lbl_rg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(49, 25);
            this.lbl_rg.TabIndex = 22;
            this.lbl_rg.Text = "RG:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(96, 176);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(75, 25);
            this.lbl_nome.TabIndex = 21;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(792, 176);
            this.lbl_telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(98, 25);
            this.lbl_telefone.TabIndex = 20;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Location = new System.Drawing.Point(96, 252);
            this.lbl_rua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(57, 25);
            this.lbl_rua.TabIndex = 19;
            this.lbl_rua.Text = "Rua:";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(852, 337);
            this.lbl_tipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(61, 25);
            this.lbl_tipo.TabIndex = 37;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(470, 337);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(93, 25);
            this.lbl_usuario.TabIndex = 38;
            this.lbl_usuario.Text = "Usuário:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(475, 366);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(166, 31);
            this.txt_usuario.TabIndex = 39;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(660, 337);
            this.lbl_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(76, 25);
            this.lbl_senha.TabIndex = 41;
            this.lbl_senha.Text = "Senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(665, 366);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(166, 31);
            this.txt_senha.TabIndex = 42;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(857, 364);
            this.cmb_tipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(124, 33);
            this.cmb_tipo.TabIndex = 43;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(400, 29);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(309, 38);
            this.lbl_titulo.TabIndex = 44;
            this.lbl_titulo.Text = "Atualiza Cadastro";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(286, 252);
            this.lbl_numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(96, 25);
            this.lbl_numero.TabIndex = 47;
            this.lbl_numero.Text = "Número:";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(470, 252);
            this.lbl_bairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(79, 25);
            this.lbl_bairro.TabIndex = 48;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(475, 281);
            this.txt_bairro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bairro.Multiline = true;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(166, 31);
            this.txt_bairro.TabIndex = 49;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(660, 252);
            this.lbl_cidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(83, 25);
            this.lbl_cidade.TabIndex = 50;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(665, 281);
            this.txt_cidade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cidade.Multiline = true;
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(166, 31);
            this.txt_cidade.TabIndex = 51;
            // 
            // msk_numero
            // 
            this.msk_numero.Location = new System.Drawing.Point(291, 281);
            this.msk_numero.Margin = new System.Windows.Forms.Padding(4);
            this.msk_numero.Mask = "99999999";
            this.msk_numero.Name = "msk_numero";
            this.msk_numero.Size = new System.Drawing.Size(148, 31);
            this.msk_numero.TabIndex = 52;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(101, 366);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Multiline = true;
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(166, 31);
            this.txt_estado.TabIndex = 53;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(286, 337);
            this.lbl_cep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(59, 25);
            this.lbl_cep.TabIndex = 54;
            this.lbl_cep.Text = "CEP:";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(96, 337);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(83, 25);
            this.lbl_estado.TabIndex = 55;
            this.lbl_estado.Text = "Estado:";
            // 
            // msk_cep
            // 
            this.msk_cep.Location = new System.Drawing.Point(291, 366);
            this.msk_cep.Margin = new System.Windows.Forms.Padding(4);
            this.msk_cep.Mask = "99999-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(148, 31);
            this.msk_cep.TabIndex = 56;
            // 
            // cmb_ativo
            // 
            this.cmb_ativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ativo.FormattingEnabled = true;
            this.cmb_ativo.Location = new System.Drawing.Point(857, 281);
            this.cmb_ativo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ativo.Name = "cmb_ativo";
            this.cmb_ativo.Size = new System.Drawing.Size(124, 33);
            this.cmb_ativo.TabIndex = 57;
            // 
            // lbl_ativo
            // 
            this.lbl_ativo.AutoSize = true;
            this.lbl_ativo.Location = new System.Drawing.Point(852, 252);
            this.lbl_ativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ativo.Name = "lbl_ativo";
            this.lbl_ativo.Size = new System.Drawing.Size(67, 25);
            this.lbl_ativo.TabIndex = 58;
            this.lbl_ativo.Text = "Ativo:";
            // 
            // lbl_pesquisa
            // 
            this.lbl_pesquisa.AutoSize = true;
            this.lbl_pesquisa.Location = new System.Drawing.Point(104, 107);
            this.lbl_pesquisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pesquisa.Name = "lbl_pesquisa";
            this.lbl_pesquisa.Size = new System.Drawing.Size(103, 25);
            this.lbl_pesquisa.TabIndex = 59;
            this.lbl_pesquisa.Text = "Pesquisar";
            // 
            // lbl_criterio
            // 
            this.lbl_criterio.AutoSize = true;
            this.lbl_criterio.Location = new System.Drawing.Point(400, 104);
            this.lbl_criterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_criterio.Name = "lbl_criterio";
            this.lbl_criterio.Size = new System.Drawing.Size(83, 25);
            this.lbl_criterio.TabIndex = 61;
            this.lbl_criterio.Text = "Critério";
            // 
            // cmb_criterio
            // 
            this.cmb_criterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_criterio.FormattingEnabled = true;
            this.cmb_criterio.Location = new System.Drawing.Point(491, 101);
            this.cmb_criterio.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_criterio.Name = "cmb_criterio";
            this.cmb_criterio.Size = new System.Drawing.Size(124, 33);
            this.cmb_criterio.TabIndex = 62;
            this.cmb_criterio.SelectedIndexChanged += new System.EventHandler(this.cmb_criterio_SelectedIndexChanged);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(450, 650);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(204, 55);
            this.btn_voltar.TabIndex = 63;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(101, 435);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.Size = new System.Drawing.Size(880, 176);
            this.dgv_usuarios.TabIndex = 64;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(777, 89);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(204, 55);
            this.btn_salvar.TabIndex = 65;
            this.btn_salvar.Text = "Atualizar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // msk_pesquisa
            // 
            this.msk_pesquisa.Location = new System.Drawing.Point(215, 101);
            this.msk_pesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.msk_pesquisa.Name = "msk_pesquisa";
            this.msk_pesquisa.Size = new System.Drawing.Size(184, 31);
            this.msk_pesquisa.TabIndex = 67;
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisa.Image")));
            this.btn_pesquisa.Location = new System.Drawing.Point(631, 97);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(41, 43);
            this.btn_pesquisa.TabIndex = 66;
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // Frm_AtualizaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 719);
            this.ControlBox = false;
            this.Controls.Add(this.msk_pesquisa);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.cmb_criterio);
            this.Controls.Add(this.lbl_criterio);
            this.Controls.Add(this.lbl_pesquisa);
            this.Controls.Add(this.lbl_ativo);
            this.Controls.Add(this.cmb_ativo);
            this.Controls.Add(this.msk_cep);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.msk_numero);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.msk_telefone);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.msk_rg);
            this.Controls.Add(this.lbl_rg);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_rua);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(72)))), ((int)(((byte)(112)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_AtualizaUsuarios";
            this.Text = "Atualiza Cadastro";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MaskedTextBox msk_telefone;
        public System.Windows.Forms.TextBox txt_rua;
        public System.Windows.Forms.TextBox txt_nome;
        public System.Windows.Forms.MaskedTextBox msk_rg;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_usuario;
        public System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_senha;
        public System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_bairro;
        public System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_cidade;
        public System.Windows.Forms.TextBox txt_cidade;
        public System.Windows.Forms.MaskedTextBox msk_numero;
        public System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_estado;
        public System.Windows.Forms.MaskedTextBox msk_cep;
        private System.Windows.Forms.ComboBox cmb_ativo;
        private System.Windows.Forms.Label lbl_ativo;
        private System.Windows.Forms.Label lbl_pesquisa;
        private System.Windows.Forms.Label lbl_criterio;
        private System.Windows.Forms.ComboBox cmb_criterio;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_pesquisa;
        public System.Windows.Forms.MaskedTextBox msk_pesquisa;
    }
}