using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows;

namespace _001_Presentación
{
    public partial class Formulario_alumno : Form
    {
        //SqlConnection conexion = new SqlConnection(CursoDataSet);

        SqlConnection conexion = new SqlConnection("server=SJR1NSAH-NICO ; database=Curso ; integrated security = true");
        public Formulario_alumno()
        {
            InitializeComponent();
        }

        //inicio variable
        int x = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cursoDataSet1.alumno' Puede moverla o quitarla según sea necesario.
            this.alumnoTableAdapter.Fill(this.cursoDataSet1.alumno);
            /*
            SqlCommand cmd = new SqlCommand("SELECT alu_nombre_alumno from alumno", conexion);
            conexion.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            while (registro.Read())
            {
                cbxNombre.Items.Add(registro["alu_nombre_alumno"].ToString());
            }
            conexion.Close();*/
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            x = 1; //nuevo registro

            lb_mantenedor.Enabled = false;

            txb_run.Text = ""; //limpia el contenido del textbox codigo
            txb_descripcion.Text = ""; //limpia el contenido del textbox descripcion
            txb_run.Select(); //Después de limpiar se posiciona en el textbox codigo (.Focus())

            gb_mantenedor.Enabled = true; //habilitar groupbox mantenedor
            /*btn_cancelar.Visible = true;
            btn_guardar.Visible = true;*/

            txb_run.Enabled = true;

            gb_botones.Enabled = false; //deshabilitar groupbox botones 
            /*btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_reporte.Enabled = false;
            btn_salir.Enabled = false;*/

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txb_run.Text = "";
            txb_descripcion.Text = "";

            gb_mantenedor.Enabled = false; //deshabilitar groupbox mantenedor
            /*txb_codigo.Enabled = false;
            //txb_descripcion.Enabled = false;
            //btn_cancelar.Enabled = false;
            //btn_guardar.Enabled = false;*/

            gb_botones.Enabled = true; //habilitar groupbox botones 
            /*btn_nuevo.Enabled = true;
            btn_actualizar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_reporte.Enabled = true;
            btn_salir.Enabled = true;*/

            lb_mantenedor.Enabled = true;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Registro;
            Registro = txb_run.Text.Trim() +" - "+ txb_descripcion.Text.Trim(); //Limpiar espacio en el contenido
            /*
            if(x==1) //nuevo registro
            {
                lb_mantenedor.Items.Add(Registro); //agregar el registro en el listbox mantenedor
            }
            else //actualizar registro
            {
                int TextoEscogido = lb_mantenedor.SelectedIndex; //pasa la posicion elegida de la lista a la variable creada
                lb_mantenedor.Items.Remove(lb_mantenedor.SelectedItem); //elimina el texto
                lb_mantenedor.Items.Insert(TextoEscogido, Registro); //inserta la info nueva, inserta lo que contiene texto escogido (tiene la ubicación donde estaba el anterior) al elemento al cargar que es registro 
            }
            */
            string queryAlumno = "INSERT INTO alumno VALUES (@pk_alumno,@pk_semestre,@pk_asignatura,@alu_nombre_alumno,@alu_apellido_alumno,@alu_direccion)";
            conexion.Open();
            SqlCommand cmd = new SqlCommand(queryAlumno, conexion);
            cmd.Parameters.AddWithValue("@pk_alumno", txb_run.Text);
            cmd.Parameters.AddWithValue("@pk_semestre", txb_semestre.Text);
            cmd.Parameters.AddWithValue("@pk_asignatura", txb_asignatura.Text);
            cmd.Parameters.AddWithValue("@alu_nombre_alumno", txb_nombre.Text);
            cmd.Parameters.AddWithValue("@alu_apellido_alumno", txb_apellido.Text);
            cmd.Parameters.AddWithValue("@alu_direccion", txb_direccion.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Alumno ingresado correctamente");
            // SqlCommand cmd = new SqlCommand("Select * from Alumno", App.config);

            txb_run.Text = "";
            txb_descripcion.Text = "";
            gb_mantenedor.Enabled = false;
            gb_botones.Enabled = true;
            lb_mantenedor.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            string queryAlumno = "DELETE FROM alumno WHERE pk_alumno=@pk_alumno";
            conexion.Open();
            SqlCommand cmd = new SqlCommand(queryAlumno, conexion);
            cmd.Parameters.AddWithValue("@pk_alumno",txb_run.Text);
            cmd.ExecuteNonQuery();
            
            //dgv_Curso.SelectedCells.Clear();

            //lb_mantenedor.Items.Remove(lb_mantenedor.SelectedItem);
            MessageBox.Show("Alumno eliminado correctamente");
            conexion.Close();
        }

        private void lb_mantenedor_Click(object sender, EventArgs e)
        {
            string TextoElegido;
            int LongitudTexto;

            TextoElegido = this.lb_mantenedor.SelectedItem.ToString().Trim();
            LongitudTexto = TextoElegido.Length;
            
            txb_run.Text = TextoElegido.Substring(0, 9); //Muestra los 9 caracteres del código
            txb_descripcion.Text = TextoElegido.Substring(12, LongitudTexto-12); //Muestra los caracteres de la descripción
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            x = 2; //actualiza registro

            lb_mantenedor.Enabled = false;
            txb_run.Select();
            gb_mantenedor.Enabled = true; //habilitar groupbox mantenedor
            txb_run.Enabled = false;
            gb_botones.Enabled = true;

            string queryAlumno = "UPDATE alumno SET alu_nombre_alumno=@alu_nombre_alumno, alu_apellido_alumno=@alu_apellido_alumno, alu_direccion=@alu_direccion WHERE pk_alumno=@pk_alumno";
            conexion.Open();
            SqlCommand cmd = new SqlCommand(queryAlumno, conexion);
            cmd.Parameters.AddWithValue("@pk_alumno", txb_run.Text); 
            cmd.Parameters.AddWithValue("@pk_semestre", txb_semestre.Text);//Recibe 2 parametros, el primero hace referencia a lo que está escrito en el queryalumno, y el otro es lo que está escrito en el txb 
            cmd.Parameters.AddWithValue("@pk_asignatura", txb_asignatura.Text);
            cmd.Parameters.AddWithValue("@alu_nombre_alumno", txb_nombre.Text);
            cmd.Parameters.AddWithValue("@alu_apellido_alumno", txb_apellido.Text);
            cmd.Parameters.AddWithValue("@alu_direccion", txb_direccion.Text);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Alumno Actualizado");
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión a la db exitosa");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Alumno", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            adaptador.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_Curso.DataSource = dt;

            gb_mantenedor.Enabled = true;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM alumno WHERE pk_alumno=@pk_alumno",conexion);
            cmd.Parameters.AddWithValue("@pk_alumno",txb_run.Text);
            conexion.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.Read())
            {
                txb_nombre.Text = registro["alu_nombre_alumno"].ToString();
                txb_apellido.Text = registro["alu_apellido_alumno"].ToString();
                txb_direccion.Text = registro["alu_direccion"].ToString();
                txb_asignatura.Text = registro["pk_asignatura"].ToString();
                txb_semestre.Text = registro["pk_semestre"].ToString();
            }
            conexion.Close();
        }

        private void cbxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
