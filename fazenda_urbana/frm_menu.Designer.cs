namespace fazenda_urbana
{
    partial class frm_menu
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
            this.btn_cad_produtos = new System.Windows.Forms.Button();
            this.btn_cad_categorias = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cad_produtos
            // 
            this.btn_cad_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_produtos.Image = global::fazenda_urbana.Properties.Resources.verduras;
            this.btn_cad_produtos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_produtos.Location = new System.Drawing.Point(78, 65);
            this.btn_cad_produtos.Name = "btn_cad_produtos";
            this.btn_cad_produtos.Size = new System.Drawing.Size(103, 134);
            this.btn_cad_produtos.TabIndex = 2;
            this.btn_cad_produtos.Text = "Cadastrar Produtos";
            this.btn_cad_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_produtos.UseVisualStyleBackColor = true;
            this.btn_cad_produtos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cad_categorias
            // 
            this.btn_cad_categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categorias.Image = global::fazenda_urbana.Properties.Resources.categories;
            this.btn_cad_categorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_categorias.Location = new System.Drawing.Point(233, 65);
            this.btn_cad_categorias.Name = "btn_cad_categorias";
            this.btn_cad_categorias.Size = new System.Drawing.Size(103, 134);
            this.btn_cad_categorias.TabIndex = 3;
            this.btn_cad_categorias.Text = "Cadastrar Categorias";
            this.btn_cad_categorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_categorias.UseVisualStyleBackColor = true;
            this.btn_cad_categorias.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.pessoasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fazenda_urbana.Properties.Resources.backg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cad_categorias);
            this.Controls.Add(this.btn_cad_produtos);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Prinicpal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cad_produtos;
        private System.Windows.Forms.Button btn_cad_categorias;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
    }
}

