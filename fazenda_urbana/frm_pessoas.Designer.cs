using System;
using System.Windows.Forms;

namespace fazenda_urbana
{
    partial class frm_pessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pessoas));
            this.label_nome = new System.Windows.Forms.Label();
            this.label_cpf = new System.Windows.Forms.Label();
            this.label_cnpj = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_endereco = new System.Windows.Forms.Label();
            this.label_cargo = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_cnpj = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_cargo = new System.Windows.Forms.TextBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(41, 37);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(93, 13);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome ( Fantasia ):";
            // 
            // label_cpf
            // 
            this.label_cpf.AutoSize = true;
            this.label_cpf.Location = new System.Drawing.Point(41, 74);
            this.label_cpf.Name = "label_cpf";
            this.label_cpf.Size = new System.Drawing.Size(30, 13);
            this.label_cpf.TabIndex = 1;
            this.label_cpf.Text = "CPF:";
            // 
            // label_cnpj
            // 
            this.label_cnpj.AutoSize = true;
            this.label_cnpj.Location = new System.Drawing.Point(41, 110);
            this.label_cnpj.Name = "label_cnpj";
            this.label_cnpj.Size = new System.Drawing.Size(37, 13);
            this.label_cnpj.TabIndex = 2;
            this.label_cnpj.Text = "CNPJ:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(41, 148);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(35, 13);
            this.label_email.TabIndex = 3;
            this.label_email.Text = "Email:";
            // 
            // label_endereco
            // 
            this.label_endereco.AutoSize = true;
            this.label_endereco.Location = new System.Drawing.Point(325, 37);
            this.label_endereco.Name = "label_endereco";
            this.label_endereco.Size = new System.Drawing.Size(56, 13);
            this.label_endereco.TabIndex = 4;
            this.label_endereco.Text = "Endereço:";
            // 
            // label_cargo
            // 
            this.label_cargo.AutoSize = true;
            this.label_cargo.Location = new System.Drawing.Point(325, 74);
            this.label_cargo.Name = "label_cargo";
            this.label_cargo.Size = new System.Drawing.Size(94, 13);
            this.label_cargo.TabIndex = 5;
            this.label_cargo.Text = "Cargo ( Atividade):";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(140, 37);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(89, 74);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf.TabIndex = 7;
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(89, 110);
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(100, 20);
            this.txt_cnpj.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(89, 145);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 9;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(387, 37);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(100, 20);
            this.txt_endereco.TabIndex = 10;
            // 
            // txt_cargo
            // 
            this.txt_cargo.Location = new System.Drawing.Point(425, 71);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(100, 20);
            this.txt_cargo.TabIndex = 11;
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(253, 138);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 12;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(357, 138);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 13;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(469, 138);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 14;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(581, 138);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 171);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fazenda_urbana.Properties.Resources.logo_UNIP;
            this.pictureBox1.Location = new System.Drawing.Point(648, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frm_pessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label_cargo);
            this.Controls.Add(this.label_endereco);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_cnpj);
            this.Controls.Add(this.label_cpf);
            this.Controls.Add(this.label_nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_pessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Pessoas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_cpf;
        private System.Windows.Forms.Label label_cnpj;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_endereco;
        private System.Windows.Forms.Label label_cargo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_cnpj;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.TextBox txt_cargo;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}
