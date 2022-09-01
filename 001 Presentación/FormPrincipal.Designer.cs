namespace _001_Presentación
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulario1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.formularioDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDeAsignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDeSemestresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioPromedioDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Barra = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_1 = new System.Windows.Forms.ToolStripButton();
            this.btn_2 = new System.Windows.Forms.ToolStripButton();
            this.btn_3 = new System.Windows.Forms.ToolStripButton();
            this.btn_4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_5 = new System.Windows.Forms.ToolStripButton();
            this.Menu.SuspendLayout();
            this.Barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(872, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulario1ToolStripMenuItem,
            this.toolStripSeparator1,
            this.formularioDeNotasToolStripMenuItem,
            this.formularioDeAsignaturasToolStripMenuItem,
            this.formularioDeSemestresToolStripMenuItem});
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.datosToolStripMenuItem.Text = "Datos";
            // 
            // formulario1ToolStripMenuItem
            // 
            this.formulario1ToolStripMenuItem.Name = "formulario1ToolStripMenuItem";
            this.formulario1ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.formulario1ToolStripMenuItem.Text = "Formulario Alumno";
            this.formulario1ToolStripMenuItem.Click += new System.EventHandler(this.formulario1ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // formularioDeNotasToolStripMenuItem
            // 
            this.formularioDeNotasToolStripMenuItem.Name = "formularioDeNotasToolStripMenuItem";
            this.formularioDeNotasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.formularioDeNotasToolStripMenuItem.Text = "Formulario de Notas";
            this.formularioDeNotasToolStripMenuItem.Click += new System.EventHandler(this.formularioDeNotasToolStripMenuItem_Click);
            // 
            // formularioDeAsignaturasToolStripMenuItem
            // 
            this.formularioDeAsignaturasToolStripMenuItem.Name = "formularioDeAsignaturasToolStripMenuItem";
            this.formularioDeAsignaturasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.formularioDeAsignaturasToolStripMenuItem.Text = "Formulario de Asignaturas";
            this.formularioDeAsignaturasToolStripMenuItem.Click += new System.EventHandler(this.formularioDeAsignaturasToolStripMenuItem_Click);
            // 
            // formularioDeSemestresToolStripMenuItem
            // 
            this.formularioDeSemestresToolStripMenuItem.Name = "formularioDeSemestresToolStripMenuItem";
            this.formularioDeSemestresToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.formularioDeSemestresToolStripMenuItem.Text = "Formulario de Semestres";
            this.formularioDeSemestresToolStripMenuItem.Click += new System.EventHandler(this.formularioDeSemestresToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioPromedioDeNotasToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.procesosToolStripMenuItem.Text = "Cálculos";
            // 
            // formularioPromedioDeNotasToolStripMenuItem
            // 
            this.formularioPromedioDeNotasToolStripMenuItem.Name = "formularioPromedioDeNotasToolStripMenuItem";
            this.formularioPromedioDeNotasToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.formularioPromedioDeNotasToolStripMenuItem.Text = "Formulario Promedio de Notas";
            this.formularioPromedioDeNotasToolStripMenuItem.Click += new System.EventHandler(this.formularioPromedioDeNotasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Barra
            // 
            this.Barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btn_1,
            this.btn_2,
            this.btn_3,
            this.btn_4,
            this.toolStripSeparator4,
            this.btn_5});
            this.Barra.Location = new System.Drawing.Point(0, 24);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(872, 73);
            this.Barra.TabIndex = 2;
            this.Barra.Text = "Formulario";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // btn_1
            // 
            this.btn_1.AutoSize = false;
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Image = ((System.Drawing.Image)(resources.GetObject("btn_1.Image")));
            this.btn_1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(120, 70);
            this.btn_1.Text = "Alumnos";
            this.btn_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.AutoSize = false;
            this.btn_2.BackColor = System.Drawing.Color.Lime;
            this.btn_2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Image = ((System.Drawing.Image)(resources.GetObject("btn_2.Image")));
            this.btn_2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(120, 70);
            this.btn_2.Text = "Notas";
            this.btn_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.AutoSize = false;
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Image = ((System.Drawing.Image)(resources.GetObject("btn_3.Image")));
            this.btn_3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(120, 70);
            this.btn_3.Text = "Asignaturas";
            this.btn_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.AutoSize = false;
            this.btn_4.BackColor = System.Drawing.Color.Lime;
            this.btn_4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Image = ((System.Drawing.Image)(resources.GetObject("btn_4.Image")));
            this.btn_4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(120, 70);
            this.btn_4.Text = "Semestres";
            this.btn_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 73);
            // 
            // btn_5
            // 
            this.btn_5.AutoSize = false;
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Image = ((System.Drawing.Image)(resources.GetObject("btn_5.Image")));
            this.btn_5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(120, 70);
            this.btn_5.Text = "Promedio de Notas";
            this.btn_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 552);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "FormPrincipal";
            this.Text = "INFORMACIÓN CURSO";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulario1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip Barra;
        private System.Windows.Forms.ToolStripButton btn_1;
        private System.Windows.Forms.ToolStripButton btn_2;
        private System.Windows.Forms.ToolStripButton btn_3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem formularioDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_4;
        private System.Windows.Forms.ToolStripButton btn_5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem formularioDeAsignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDeSemestresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioPromedioDeNotasToolStripMenuItem;
    }
}