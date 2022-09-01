namespace _001_Presentación
{
    partial class FormularioNotas
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
            this.dgv_Curso = new System.Windows.Forms.DataGridView();
            this.gb_botones = new System.Windows.Forms.GroupBox();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.gb_mantenedor = new System.Windows.Forms.GroupBox();
            this.cbxNombre = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txb_asignatura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_semestre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_codNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_nota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_cursoSemestre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txb_run = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Curso)).BeginInit();
            this.gb_botones.SuspendLayout();
            this.gb_mantenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Curso
            // 
            this.dgv_Curso.AllowUserToAddRows = false;
            this.dgv_Curso.AllowUserToDeleteRows = false;
            this.dgv_Curso.AllowUserToOrderColumns = true;
            this.dgv_Curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Curso.Location = new System.Drawing.Point(507, 146);
            this.dgv_Curso.Name = "dgv_Curso";
            this.dgv_Curso.ReadOnly = true;
            this.dgv_Curso.Size = new System.Drawing.Size(511, 280);
            this.dgv_Curso.TabIndex = 23;
            // 
            // gb_botones
            // 
            this.gb_botones.BackColor = System.Drawing.Color.Green;
            this.gb_botones.Controls.Add(this.btn_seleccionar);
            this.gb_botones.Controls.Add(this.btn_eliminar);
            this.gb_botones.Controls.Add(this.btn_actualizar);
            this.gb_botones.Controls.Add(this.btn_nuevo);
            this.gb_botones.Location = new System.Drawing.Point(0, 0);
            this.gb_botones.Name = "gb_botones";
            this.gb_botones.Size = new System.Drawing.Size(517, 124);
            this.gb_botones.TabIndex = 20;
            this.gb_botones.TabStop = false;
            this.gb_botones.Text = "Botones";
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.BackColor = System.Drawing.Color.Yellow;
            this.btn_seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.ForeColor = System.Drawing.Color.Red;
            this.btn_seleccionar.Location = new System.Drawing.Point(189, 28);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(100, 50);
            this.btn_seleccionar.TabIndex = 18;
            this.btn_seleccionar.Text = "Lista de Notas";
            this.btn_seleccionar.UseVisualStyleBackColor = false;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Yellow;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Red;
            this.btn_eliminar.Location = new System.Drawing.Point(401, 28);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 50);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.Yellow;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.Red;
            this.btn_actualizar.Location = new System.Drawing.Point(295, 28);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(100, 50);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.Yellow;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Image = global::_001_Presentación.Properties.Resources._new;
            this.btn_nuevo.Location = new System.Drawing.Point(18, 19);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(149, 83);
            this.btn_nuevo.TabIndex = 5;
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // gb_mantenedor
            // 
            this.gb_mantenedor.BackColor = System.Drawing.Color.Green;
            this.gb_mantenedor.Controls.Add(this.cbxNombre);
            this.gb_mantenedor.Controls.Add(this.btn_buscar);
            this.gb_mantenedor.Controls.Add(this.txb_asignatura);
            this.gb_mantenedor.Controls.Add(this.label7);
            this.gb_mantenedor.Controls.Add(this.txb_semestre);
            this.gb_mantenedor.Controls.Add(this.label6);
            this.gb_mantenedor.Controls.Add(this.txb_codNota);
            this.gb_mantenedor.Controls.Add(this.label5);
            this.gb_mantenedor.Controls.Add(this.txb_nota);
            this.gb_mantenedor.Controls.Add(this.label4);
            this.gb_mantenedor.Controls.Add(this.txb_cursoSemestre);
            this.gb_mantenedor.Controls.Add(this.label3);
            this.gb_mantenedor.Controls.Add(this.btn_guardar);
            this.gb_mantenedor.Controls.Add(this.txb_run);
            this.gb_mantenedor.Controls.Add(this.label1);
            this.gb_mantenedor.Enabled = false;
            this.gb_mantenedor.Location = new System.Drawing.Point(0, 146);
            this.gb_mantenedor.Name = "gb_mantenedor";
            this.gb_mantenedor.Size = new System.Drawing.Size(380, 280);
            this.gb_mantenedor.TabIndex = 19;
            this.gb_mantenedor.TabStop = false;
            this.gb_mantenedor.Text = "Mantenedor";
            // 
            // cbxNombre
            // 
            this.cbxNombre.DisplayMember = "pk_alumno";
            this.cbxNombre.FormattingEnabled = true;
            this.cbxNombre.Location = new System.Drawing.Point(9, 200);
            this.cbxNombre.Name = "cbxNombre";
            this.cbxNombre.Size = new System.Drawing.Size(121, 21);
            this.cbxNombre.TabIndex = 7;
            this.cbxNombre.ValueMember = "pk_alumno";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Yellow;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.Red;
            this.btn_buscar.Location = new System.Drawing.Point(267, 119);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(100, 50);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txb_asignatura
            // 
            this.txb_asignatura.Location = new System.Drawing.Point(131, 149);
            this.txb_asignatura.MaxLength = 2;
            this.txb_asignatura.Name = "txb_asignatura";
            this.txb_asignatura.Size = new System.Drawing.Size(100, 20);
            this.txb_asignatura.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Asignatura:";
            // 
            // txb_semestre
            // 
            this.txb_semestre.Location = new System.Drawing.Point(9, 149);
            this.txb_semestre.MaxLength = 2;
            this.txb_semestre.Name = "txb_semestre";
            this.txb_semestre.Size = new System.Drawing.Size(100, 20);
            this.txb_semestre.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Semestre:";
            // 
            // txb_codNota
            // 
            this.txb_codNota.Location = new System.Drawing.Point(129, 95);
            this.txb_codNota.MaxLength = 100;
            this.txb_codNota.Name = "txb_codNota";
            this.txb_codNota.Size = new System.Drawing.Size(100, 20);
            this.txb_codNota.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Código nota:";
            // 
            // txb_nota
            // 
            this.txb_nota.Location = new System.Drawing.Point(129, 41);
            this.txb_nota.MaxLength = 4;
            this.txb_nota.Name = "txb_nota";
            this.txb_nota.Size = new System.Drawing.Size(100, 20);
            this.txb_nota.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nota:";
            // 
            // txb_cursoSemestre
            // 
            this.txb_cursoSemestre.Location = new System.Drawing.Point(9, 95);
            this.txb_cursoSemestre.MaxLength = 100;
            this.txb_cursoSemestre.Name = "txb_cursoSemestre";
            this.txb_cursoSemestre.Size = new System.Drawing.Size(100, 20);
            this.txb_cursoSemestre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Curso y Semestre:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Yellow;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.Red;
            this.btn_guardar.Location = new System.Drawing.Point(267, 25);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 50);
            this.btn_guardar.TabIndex = 16;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txb_run
            // 
            this.txb_run.Location = new System.Drawing.Point(9, 41);
            this.txb_run.MaxLength = 9;
            this.txb_run.Name = "txb_run";
            this.txb_run.Size = new System.Drawing.Size(100, 20);
            this.txb_run.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rut:";
            // 
            // btn_conectar
            // 
            this.btn_conectar.BackColor = System.Drawing.Color.Yellow;
            this.btn_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar.ForeColor = System.Drawing.Color.Red;
            this.btn_conectar.Location = new System.Drawing.Point(552, 28);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(100, 50);
            this.btn_conectar.TabIndex = 24;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Yellow;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_cancelar.Location = new System.Drawing.Point(386, 171);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 50);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // FormularioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1026, 427);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.dgv_Curso);
            this.Controls.Add(this.gb_botones);
            this.Controls.Add(this.gb_mantenedor);
            this.Name = "FormularioNotas";
            this.Text = "NOTAS";
            this.Load += new System.EventHandler(this.FormularioNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Curso)).EndInit();
            this.gb_botones.ResumeLayout(false);
            this.gb_mantenedor.ResumeLayout(false);
            this.gb_mantenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Curso;
        private System.Windows.Forms.GroupBox gb_botones;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox gb_mantenedor;
        private System.Windows.Forms.ComboBox cbxNombre;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txb_asignatura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_semestre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_codNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_nota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_cursoSemestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txb_run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}