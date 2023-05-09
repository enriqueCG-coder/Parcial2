
namespace Parcial2.UI.GUI
{
    partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.opcionPadreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRolesChildMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gMovimientosChildMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionPadreToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(873, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.UseWaitCursor = true;
            // 
            // opcionPadreToolStripMenuItem
            // 
            this.opcionPadreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gRolesChildMenuItem,
            this.gMovimientosChildMenuItem});
            this.opcionPadreToolStripMenuItem.Name = "opcionPadreToolStripMenuItem";
            this.opcionPadreToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opcionPadreToolStripMenuItem.Text = "General";
            // 
            // gRolesChildMenuItem
            // 
            this.gRolesChildMenuItem.Name = "gRolesChildMenuItem";
            this.gRolesChildMenuItem.Size = new System.Drawing.Size(203, 22);
            this.gRolesChildMenuItem.Text = "Gestion Clientes";
            this.gRolesChildMenuItem.Click += new System.EventHandler(this.gRolesChildMenuItem_Click);
            // 
            // gMovimientosChildMenuItem
            // 
            this.gMovimientosChildMenuItem.Name = "gMovimientosChildMenuItem";
            this.gMovimientosChildMenuItem.Size = new System.Drawing.Size(203, 22);
            this.gMovimientosChildMenuItem.Text = "Gestión de Movimientos";
            this.gMovimientosChildMenuItem.Click += new System.EventHandler(this.gMovimientosChildMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelSistemaToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 468);
            this.Controls.Add(this.menuStrip);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem opcionPadreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRolesChildMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gMovimientosChildMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}