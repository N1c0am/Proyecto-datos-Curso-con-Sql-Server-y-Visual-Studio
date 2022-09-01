using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //importar

namespace _001_Presentación
{
    public partial class Formulario_alumno : Form
    {
        SqlConnection conexion = new SqlConnection("server=SJR1NSAH-NICO ; database=Curso ; integrated security = true");
        public Formulario_alumno()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txb_run.Text = "";
            txb_nombre.Text = ""; 
            txb_apellido.Text = "";
            txb_direccion.Text = "";
            txb_semestre.Text = "";
            txb_asignatura.Text = "";

            txb_run.Select();

            gb_mantenedor.Enabled = true;
            /*btn_cancelar.Enabled = true;
            btn_guardar.Enabled = true;
            btn_guardar.Enabled = true;
            txb_run.Enabled = true;
            txb_nombre.Enabled = true;
            txb_apellido.Enabled = true;
            txb_direccion.Enabled = true;
            txb_semestre.Enabled = true;
            txb_asignatura.Enabled = true;*/

            gb_botones.Enabled = false; 
            /*btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_seleccionar.Enabled = false;*/

            conexion.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txb_run.Text = ""; 
            txb_nombre.Text = ""; 
            txb_apellido.Text = "";
            txb_direccion.Text = "";
            txb_semestre.Text = "";
            txb_asignatura.Text = "";

            gb_mantenedor.Enabled = true;
            /*btn_cancelar.Enabled = true;
            btn_guardar.Enabled = true;
            btn_guardar.Enabled = true;
            txb_run.Enabled = true;
            txb_nombre.Enabled = true;
            txb_apellido.Enabled = true;
            txb_direccion.Enabled = true;
            txb_semestre.Enabled = true;
            txb_asignatura.Enabled = true;*/

            gb_botones.Enabled = true;
            /*btn_nuevo.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_seleccionar.Enabled = false;*/

            conexion.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string queryAlumno = "INSERT INTO alumno VALUES (@pk_alumno,@pk_semestre,@pk_asignatura,@alu_nombre_alumno,@alu_apellido_alumno,@alu_direccion)"; //creamos un string que contenga la query de insertar datos de los alumnos con sus respectivas columnas
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
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: "+ex.ToString());
            }  

            txb_run.Text = "";
            txb_nombre.Text = "";
            txb_apellido.Text = "";
            txb_direccion.Text = "";
            txb_semestre.Text = "";
            txb_asignatura.Text = "";

            gb_mantenedor.Enabled = false;
            gb_botones.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                //SqlCommand cmd = new SqlCommand ("DELETE FROM alumno WHERE pk_alumno=@pk_alumno", conexion);
                SqlCommand cmd = new SqlCommand("EXEC proc_eliminarAlumno @pk_alumno", conexion);
                cmd.Parameters.AddWithValue("@pk_alumno", txb_run.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Alumno eliminado correctamente");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }   

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //string queryAlumno = "UPDATE alumno SET alu_nombre_alumno=@alu_nombre_alumno, alu_apellido_alumno=@alu_apellido_alumno, alu_direccion=@alu_direccion WHERE pk_alumno=@pk_alumno";
                string queryAlumno = "exec proc_actualizarAlumno @pk_alumno, @pk_semestre, @pk_asignatura, @alu_nombre_alumno, @alu_apellido_alumno, @alu_direccion";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(queryAlumno, conexion);
                cmd.Parameters.AddWithValue("@pk_alumno", txb_run.Text);
                cmd.Parameters.AddWithValue("@pk_semestre", txb_semestre.Text);//Recibe 2 parametros, el primero hace referencia a lo que está escrito en el queryalumno, y el otro es lo que está escrito en el txb 
                cmd.Parameters.AddWithValue("@pk_asignatura", txb_asignatura.Text);
                cmd.Parameters.AddWithValue("@alu_nombre_alumno", txb_nombre.Text);
                cmd.Parameters.AddWithValue("@alu_apellido_alumno", txb_apellido.Text);
                cmd.Parameters.AddWithValue("@alu_direccion", txb_direccion.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Alumno Actualizado");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

            txb_run.Select();
            gb_mantenedor.Enabled = true; 
            gb_botones.Enabled = true;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Alumno", conexion); 
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv_Curso.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

            gb_mantenedor.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM alumno WHERE pk_alumno=@pk_alumno", conexion);
                cmd.Parameters.AddWithValue("@pk_alumno", txb_run.Text);
                conexion.Open();
                SqlDataReader registro = cmd.ExecuteReader(); 
                if (registro.Read()) //
                {
                    txb_nombre.Text = registro["alu_nombre_alumno"].ToString();
                    txb_apellido.Text = registro["alu_apellido_alumno"].ToString();
                    txb_direccion.Text = registro["alu_direccion"].ToString();
                    txb_asignatura.Text = registro["pk_asignatura"].ToString();
                    txb_semestre.Text = registro["pk_semestre"].ToString();
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
            gb_botones.Enabled = true;
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open(); //abre la conexion
                MessageBox.Show("Conexión a la db exitosa");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }
        private void cbxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void lb_mantenedor_Click(object sender, EventArgs e)
        {
            /*string TextoElegido;
            int LongitudTexto;

            TextoElegido = this.lb_mantenedor.SelectedItem.ToString().Trim();
            LongitudTexto = TextoElegido.Length;
            
            txb_run.Text = TextoElegido.Substring(0, 9); //Muestra los 9 caracteres del código
            txb_descripcion.Text = TextoElegido.Substring(12, LongitudTexto-12); //Muestra los caracteres de la descripción*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cursoDataSet1.alumno' Puede moverla o quitarla según sea necesario.
            //this.alumnoTableAdapter.Fill(this.cursoDataSet1.alumno);

        }

        private void dgv_Curso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
