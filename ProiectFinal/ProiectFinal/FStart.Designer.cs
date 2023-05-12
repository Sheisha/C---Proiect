namespace ProiectFinal
{
    partial class FStart
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
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specializariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscrieriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.specializariToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inscrieriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(233, 92);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(326, 25);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Aplicatie pt. inscriere studenti";
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitlu.Visible = false;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(280, 136);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(212, 20);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor: Ivanof Alexia-Andreea";
            this.lblAutor.Visible = false;
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Location = new System.Drawing.Point(281, 192);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(47, 13);
            this.lblUtilizator.TabIndex = 2;
            this.lblUtilizator.Text = "Utilizator";
            this.lblUtilizator.Visible = false;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(281, 233);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(37, 13);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola";
            this.lblParola.Visible = false;
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(338, 192);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(138, 20);
            this.txtUtilizator.TabIndex = 4;
            this.txtUtilizator.Visible = false;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(338, 233);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(138, 20);
            this.txtParola.TabIndex = 5;
            this.txtParola.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(350, 285);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(119, 26);
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specializariToolStripMenuItem});
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.studentiToolStripMenuItem.Text = "Studenti";
            // 
            // specializariToolStripMenuItem
            // 
            this.specializariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscrieriToolStripMenuItem});
            this.specializariToolStripMenuItem.Name = "specializariToolStripMenuItem";
            this.specializariToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.specializariToolStripMenuItem.Text = "Specializari";
            // 
            // inscrieriToolStripMenuItem
            // 
            this.inscrieriToolStripMenuItem.Name = "inscrieriToolStripMenuItem";
            this.inscrieriToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.inscrieriToolStripMenuItem.Text = "Inscrieri";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem1,
            this.specializariToolStripMenuItem1,
            this.inscrieriToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip2";
            this.menuStrip1.Visible = false;
            // 
            // studentiToolStripMenuItem1
            // 
            this.studentiToolStripMenuItem1.Name = "studentiToolStripMenuItem1";
            this.studentiToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.studentiToolStripMenuItem1.Text = "Studenti";
            this.studentiToolStripMenuItem1.Click += new System.EventHandler(this.studentiToolStripMenuItem_Click);
            // 
            // specializariToolStripMenuItem1
            // 
            this.specializariToolStripMenuItem1.Name = "specializariToolStripMenuItem1";
            this.specializariToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.specializariToolStripMenuItem1.Text = "Specializari";
            this.specializariToolStripMenuItem1.Click += new System.EventHandler(this.specializariToolStripMenuItem_Click);
            // 
            // inscrieriToolStripMenuItem1
            // 
            this.inscrieriToolStripMenuItem1.Name = "inscrieriToolStripMenuItem1";
            this.inscrieriToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.inscrieriToolStripMenuItem1.Text = "Inscrieri";
            this.inscrieriToolStripMenuItem1.Click += new System.EventHandler(this.inscrieriToolStripMenuItem_Click);
            // 
            // FStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 390);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Name = "FStart";
            this.Text = "FStart";
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specializariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscrieriToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem specializariToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inscrieriToolStripMenuItem1;
    }
}

