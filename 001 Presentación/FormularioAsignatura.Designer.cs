namespace _001_Presentación
{
    partial class FormularioAsignatura
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
            this.dgv_Curso = new System.Windows.Forms.DataGridView();
            this.pkasignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asigdescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoDataSet = new _001_Presentación.CursoDataSet();
            this.gb_botones = new System.Windows.Forms.GroupBox();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.gb_mantenedor = new System.Windows.Forms.GroupBox();
            this.cbxNombre = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txb_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_codAsignatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.asignaturaTableAdapter = new _001_Presentación.CursoDataSetTableAdapters.asignaturaTableAdapter();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Curso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataSet)).BeginInit();
            this.gb_botones.SuspendLayout();
            this.gb_mantenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Curso
            // 
            this.dgv_Curso.AllowUserToAddRows = false;
            this.dgv_Curso.AllowUserToDeleteRows = false;
            this.dgv_Curso.AllowUserToOrderColumns = true;
            this.dgv_Curso.AutoGenerateColumns = false;
            this.dgv_Curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Curso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkasignaturaDataGridViewTextBoxColumn,
            this.asigdescripcionDataGridViewTextBoxColumn,
            this.asignombreDataGridViewTextBoxColumn});
            this.dgv_Curso.DataSource = this.asignaturaBindingSource;
            this.dgv_Curso.Location = new System.Drawing.Point(507, 129);
            this.dgv_Curso.Name = "dgv_Curso";
            this.dgv_Curso.ReadOnly = true;
            this.dgv_Curso.Size = new System.Drawing.Size(347, 281);
            this.dgv_Curso.TabIndex = 27;
            // 
            // pkasignaturaDataGridViewTextBoxColumn
            // 
            this.pkasignaturaDataGridViewTextBoxColumn.DataPropertyName = "pk_asignatura";
            this.pkasignaturaDataGridViewTextBoxColumn.HeaderText = "pk_asignatura";
            this.pkasignaturaDataGridViewTextBoxColumn.Name = "pkasignaturaDataGridViewTextBoxColumn";
            this.pkasignaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asigdescripcionDataGridViewTextBoxColumn
            // 
            this.asigdescripcionDataGridViewTextBoxColumn.DataPropertyName = "asig_descripcion";
            this.asigdescripcionDataGridViewTextBoxColumn.HeaderText = "asig_descripcion";
            this.asigdescripcionDataGridViewTextBoxColumn.Name = "asigdescripcionDataGridViewTextBoxColumn";
            this.asigdescripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asignombreDataGridViewTextBoxColumn
            // 
            this.asignombreDataGridViewTextBoxColumn.DataPropertyName = "asig_nombre";
            this.asignombreDataGridViewTextBoxColumn.HeaderText = "asig_nombre";
            this.asignombreDataGridViewTextBoxColumn.Name = "asignombreDataGridViewTextBoxColumn";
            this.asignombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asignaturaBindingSource
            // 
            this.asignaturaBindingSource.DataMember = "asignatura";
            this.asignaturaBindingSource.DataSource = this.cursoDataSet;
            // 
            // cursoDataSet
            // 
            this.cursoDataSet.DataSetName = "CursoDataSet";
            this.cursoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gb_botones.Size = new System.Drawing.Size(513, 124);
            this.gb_botones.TabIndex = 28;
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
            this.btn_seleccionar.Text = "Lista de Asignaturas";
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
            this.gb_mantenedor.Controls.Add(this.txb_nombre);
            this.gb_mantenedor.Controls.Add(this.label4);
            this.gb_mantenedor.Controls.Add(this.btn_guardar);
            this.gb_mantenedor.Controls.Add(this.txb_descripcion);
            this.gb_mantenedor.Controls.Add(this.label2);
            this.gb_mantenedor.Controls.Add(this.txb_codAsignatura);
            this.gb_mantenedor.Controls.Add(this.label1);
            this.gb_mantenedor.Enabled = false;
            this.gb_mantenedor.Location = new System.Drawing.Point(0, 130);
            this.gb_mantenedor.Name = "gb_mantenedor";
            this.gb_mantenedor.Size = new System.Drawing.Size(379, 280);
            this.gb_mantenedor.TabIndex = 29;
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
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(129, 41);
            this.txb_nombre.MaxLength = 100;
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(100, 20);
            this.txb_nombre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre:";
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
            // txb_descripcion
            // 
            this.txb_descripcion.Location = new System.Drawing.Point(84, 81);
            this.txb_descripcion.MaxLength = 50;
            this.txb_descripcion.Multiline = true;
            this.txb_descripcion.Name = "txb_descripcion";
            this.txb_descripcion.Size = new System.Drawing.Size(145, 61);
            this.txb_descripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripción";
            // 
            // txb_codAsignatura
            // 
            this.txb_codAsignatura.Location = new System.Drawing.Point(9, 41);
            this.txb_codAsignatura.MaxLength = 9;
            this.txb_codAsignatura.Name = "txb_codAsignatura";
            this.txb_codAsignatura.Size = new System.Drawing.Size(100, 20);
            this.txb_codAsignatura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código Asignatura:";
            // 
            // asignaturaTableAdapter
            // 
            this.asignaturaTableAdapter.ClearBeforeFill = true;
            // 
            // btn_conectar
            // 
            this.btn_conectar.BackColor = System.Drawing.Color.Yellow;
            this.btn_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar.ForeColor = System.Drawing.Color.Red;
            this.btn_conectar.Location = new System.Drawing.Point(566, 28);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(100, 50);
            this.btn_conectar.TabIndex = 30;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Yellow;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_cancelar.Location = new System.Drawing.Point(385, 155);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 50);
            this.btn_cancelar.TabIndex = 31;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // FormularioAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(857, 413);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.gb_mantenedor);
            this.Controls.Add(this.gb_botones);
            this.Controls.Add(this.dgv_Curso);
            this.Name = "FormularioAsignatura";
            this.Text = "FormularioAsignatura";
            this.Load += new System.EventHandler(this.FormularioAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Curso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txb_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_codAsignatura;
        private System.Windows.Forms.Label label1;
        private CursoDataSet cursoDataSet;
        private System.Windows.Forms.BindingSource asignaturaBindingSource;
        private CursoDataSetTableAdapters.asignaturaTableAdapter asignaturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkasignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asigdescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}