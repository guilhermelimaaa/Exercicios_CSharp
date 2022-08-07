namespace ProjetoMenu
{
    partial class frmMenuPrincipal
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
            this.mstMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio25ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prcAplicativos = new System.Diagnostics.Process();
            this.mstMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMenuPrincipal
            // 
            this.mstMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.aplicativosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mstMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstMenuPrincipal.Name = "mstMenuPrincipal";
            this.mstMenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mstMenuPrincipal.TabIndex = 0;
            this.mstMenuPrincipal.Text = "mstMenuPrincipal";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercicio12ToolStripMenuItem,
            this.exercicio25ToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "&Programas";
            // 
            // exercicio12ToolStripMenuItem
            // 
            this.exercicio12ToolStripMenuItem.Name = "exercicio12ToolStripMenuItem";
            this.exercicio12ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercicio12ToolStripMenuItem.Text = "Exercicio 12";
            this.exercicio12ToolStripMenuItem.Click += new System.EventHandler(this.exercicio12ToolStripMenuItem_Click);
            // 
            // exercicio25ToolStripMenuItem
            // 
            this.exercicio25ToolStripMenuItem.Name = "exercicio25ToolStripMenuItem";
            this.exercicio25ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercicio25ToolStripMenuItem.Text = "Exercicio 25";
            this.exercicio25ToolStripMenuItem.Click += new System.EventHandler(this.exercicio25ToolStripMenuItem_Click);
            // 
            // aplicativosToolStripMenuItem
            // 
            this.aplicativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.calculadoraToolStripMenuItem});
            this.aplicativosToolStripMenuItem.Name = "aplicativosToolStripMenuItem";
            this.aplicativosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.aplicativosToolStripMenuItem.Text = "&Aplicativos";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.wordToolStripMenuItem.Text = "&Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.excelToolStripMenuItem.Text = "&Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.calculadoraToolStripMenuItem.Text = "&Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairDoSistemaToolStripMenuItem});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "&Sair";
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            this.sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            this.sairDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sairDoSistemaToolStripMenuItem.Text = "&Sair do Sistema";
            this.sairDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.sairDoSistemaToolStripMenuItem_Click);
            // 
            // prcAplicativos
            // 
            this.prcAplicativos.StartInfo.Domain = "";
            this.prcAplicativos.StartInfo.LoadUserProfile = false;
            this.prcAplicativos.StartInfo.Password = null;
            this.prcAplicativos.StartInfo.StandardErrorEncoding = null;
            this.prcAplicativos.StartInfo.StandardOutputEncoding = null;
            this.prcAplicativos.StartInfo.UserName = "";
            this.prcAplicativos.SynchronizingObject = this;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.mstMenuPrincipal);
            this.MainMenuStrip = this.mstMenuPrincipal;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.mstMenuPrincipal.ResumeLayout(false);
            this.mstMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio25ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private System.Diagnostics.Process prcAplicativos;
    }
}

