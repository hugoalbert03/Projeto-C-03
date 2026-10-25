namespace ExemploMDI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            formulário1ToolStripMenuItem = new ToolStripMenuItem();
            formulário2ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            janelaToolStripMenuItem = new ToolStripMenuItem();
            cascataToolStripMenuItem = new ToolStripMenuItem();
            ladoALagoToolStripMenuItem = new ToolStripMenuItem();
            ladoALadoHorizontalToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            frmClientesToolStripMenuItem = new ToolStripMenuItem();
            frmFornecedorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, janelaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = janelaToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formulário1ToolStripMenuItem, formulário2ToolStripMenuItem, toolStripSeparator1, toolStripMenuItem1 });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(79, 25);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // formulário1ToolStripMenuItem
            // 
            formulário1ToolStripMenuItem.Name = "formulário1ToolStripMenuItem";
            formulário1ToolStripMenuItem.Size = new Size(224, 26);
            formulário1ToolStripMenuItem.Text = "Formulário 1";
            formulário1ToolStripMenuItem.Click += formulário1ToolStripMenuItem_Click;
            // 
            // formulário2ToolStripMenuItem
            // 
            formulário2ToolStripMenuItem.Name = "formulário2ToolStripMenuItem";
            formulário2ToolStripMenuItem.Size = new Size(224, 26);
            formulário2ToolStripMenuItem.Text = "Formulário 2";
            formulário2ToolStripMenuItem.Click += formulário2ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(224, 26);
            toolStripMenuItem1.Text = "Sair";
            // 
            // janelaToolStripMenuItem
            // 
            janelaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascataToolStripMenuItem, ladoALagoToolStripMenuItem, ladoALadoHorizontalToolStripMenuItem, toolStripSeparator2, frmClientesToolStripMenuItem, frmFornecedorToolStripMenuItem });
            janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            janelaToolStripMenuItem.Size = new Size(71, 25);
            janelaToolStripMenuItem.Text = " Janela";
            // 
            // cascataToolStripMenuItem
            // 
            cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            cascataToolStripMenuItem.Size = new Size(254, 26);
            cascataToolStripMenuItem.Text = "Cascata";
            cascataToolStripMenuItem.Click += cascataToolStripMenuItem_Click;
            // 
            // ladoALagoToolStripMenuItem
            // 
            ladoALagoToolStripMenuItem.Name = "ladoALagoToolStripMenuItem";
            ladoALagoToolStripMenuItem.Size = new Size(254, 26);
            ladoALagoToolStripMenuItem.Text = "Lado a Lado Vertical";
            ladoALagoToolStripMenuItem.Click += ladoALagoToolStripMenuItem_Click;
            // 
            // ladoALadoHorizontalToolStripMenuItem
            // 
            ladoALadoHorizontalToolStripMenuItem.Name = "ladoALadoHorizontalToolStripMenuItem";
            ladoALadoHorizontalToolStripMenuItem.Size = new Size(254, 26);
            ladoALadoHorizontalToolStripMenuItem.Text = "Lado a Lado Horizontal";
            ladoALadoHorizontalToolStripMenuItem.Click += ladoALadoHorizontalToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(251, 6);
            // 
            // frmClientesToolStripMenuItem
            // 
            frmClientesToolStripMenuItem.Name = "frmClientesToolStripMenuItem";
            frmClientesToolStripMenuItem.Size = new Size(254, 26);
            frmClientesToolStripMenuItem.Text = "1 frmClientes";
            // 
            // frmFornecedorToolStripMenuItem
            // 
            frmFornecedorToolStripMenuItem.Name = "frmFornecedorToolStripMenuItem";
            frmFornecedorToolStripMenuItem.Size = new Size(254, 26);
            frmFornecedorToolStripMenuItem.Text = "2 frmFornecedor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem formulário1ToolStripMenuItem;
        private ToolStripMenuItem formulário2ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem janelaToolStripMenuItem;
        private ToolStripMenuItem cascataToolStripMenuItem;
        private ToolStripMenuItem ladoALagoToolStripMenuItem;
        private ToolStripMenuItem ladoALadoHorizontalToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem frmClientesToolStripMenuItem;
        private ToolStripMenuItem frmFornecedorToolStripMenuItem;
    }
}
