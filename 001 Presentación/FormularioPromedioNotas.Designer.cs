namespace _001_Presentación
{
    partial class FormularioPromedioNotas
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
            this.btn_conectar = new System.Windows.Forms.Button();
            this.gb_botones = new System.Windows.Forms.GroupBox();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_notasAltas = new System.Windows.Forms.Button();
            this.btn_notasBajas = new System.Windows.Forms.Button();
            this.dgv_notasAltas = new System.Windows.Forms.DataGridView();
            this.dgv_notasBajas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Curso)).BeginInit();
            this.gb_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notasAltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notasBajas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Curso
            // 
            this.dgv_Curso.AllowUserToAddRows = false;
            this.dgv_Curso.AllowUserToDeleteRows = false;
            this.dgv_Curso.AllowUserToOrderColumns = true;
            this.dgv_Curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Curso.Location = new System.Drawing.Point(659, 12);
            this.dgv_Curso.Name = "dgv_Curso";
            this.dgv_Curso.ReadOnly = true;
            this.dgv_Curso.Size = new System.Drawing.Size(349, 407);
            this.dgv_Curso.TabIndex = 32;
            // 
            // btn_conectar
            // 
            this.btn_conectar.BackColor = System.Drawing.Color.Yellow;
            this.btn_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar.ForeColor = System.Drawing.Color.Red;
            this.btn_conectar.Location = new System.Drawing.Point(442, 45);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(100, 50);
            this.btn_conectar.TabIndex = 31;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = false;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // gb_botones
            // 
            this.gb_botones.BackColor = System.Drawing.Color.Green;
            this.gb_botones.Controls.Add(this.btn_seleccionar);
            this.gb_botones.Location = new System.Drawing.Point(107, 12);
            this.gb_botones.Name = "gb_botones";
            this.gb_botones.Size = new System.Drawing.Size(114, 95);
            this.gb_botones.TabIndex = 30;
            this.gb_botones.TabStop = false;
            this.gb_botones.Text = "Botones";
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.BackColor = System.Drawing.Color.Yellow;
            this.btn_seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.ForeColor = System.Drawing.Color.Red;
            this.btn_seleccionar.Location = new System.Drawing.Point(6, 33);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(100, 50);
            this.btn_seleccionar.TabIndex = 18;
            this.btn_seleccionar.Text = "Lista Promedio de Notas";
            this.btn_seleccionar.UseVisualStyleBackColor = false;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // btn_notasAltas
            // 
            this.btn_notasAltas.BackColor = System.Drawing.Color.Yellow;
            this.btn_notasAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notasAltas.ForeColor = System.Drawing.Color.Red;
            this.btn_notasAltas.Location = new System.Drawing.Point(113, 123);
            this.btn_notasAltas.Name = "btn_notasAltas";
            this.btn_notasAltas.Size = new System.Drawing.Size(100, 50);
            this.btn_notasAltas.TabIndex = 33;
            this.btn_notasAltas.Text = "Promedio de Notas Altas";
            this.btn_notasAltas.UseVisualStyleBackColor = false;
            this.btn_notasAltas.Click += new System.EventHandler(this.btn_notasAltas_Click);
            // 
            // btn_notasBajas
            // 
            this.btn_notasBajas.BackColor = System.Drawing.Color.Yellow;
            this.btn_notasBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notasBajas.ForeColor = System.Drawing.Color.Red;
            this.btn_notasBajas.Location = new System.Drawing.Point(442, 123);
            this.btn_notasBajas.Name = "btn_notasBajas";
            this.btn_notasBajas.Size = new System.Drawing.Size(100, 50);
            this.btn_notasBajas.TabIndex = 34;
            this.btn_notasBajas.Text = "Promedio de Notas Bajas";
            this.btn_notasBajas.UseVisualStyleBackColor = false;
            this.btn_notasBajas.Click += new System.EventHandler(this.btn_notasBajas_Click);
            // 
            // dgv_notasAltas
            // 
            this.dgv_notasAltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notasAltas.Location = new System.Drawing.Point(12, 179);
            this.dgv_notasAltas.Name = "dgv_notasAltas";
            this.dgv_notasAltas.Size = new System.Drawing.Size(300, 245);
            this.dgv_notasAltas.TabIndex = 35;
            // 
            // dgv_notasBajas
            // 
            this.dgv_notasBajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notasBajas.Location = new System.Drawing.Point(342, 179);
            this.dgv_notasBajas.Name = "dgv_notasBajas";
            this.dgv_notasBajas.Size = new System.Drawing.Size(300, 245);
            this.dgv_notasBajas.TabIndex = 36;
            // 
            // FormularioPromedioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1020, 431);
            this.Controls.Add(this.dgv_notasBajas);
            this.Controls.Add(this.dgv_notasAltas);
            this.Controls.Add(this.btn_notasBajas);
            this.Controls.Add(this.btn_notasAltas);
            this.Controls.Add(this.dgv_Curso);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.gb_botones);
            this.Name = "FormularioPromedioNotas";
            this.Text = "Formulario Promedio Notas";
            this.Load += new System.EventHandler(this.FormularioPromedioNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Curso)).EndInit();
            this.gb_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notasAltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notasBajas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Curso;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.GroupBox gb_botones;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_notasAltas;
        private System.Windows.Forms.Button btn_notasBajas;
        private System.Windows.Forms.DataGridView dgv_notasAltas;
        private System.Windows.Forms.DataGridView dgv_notasBajas;
    }
}