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

namespace _001_Presentación
{
    public partial class FormularioSemestre : Form
    {
        SqlConnection conexion = new SqlConnection("server=SJR1NSAH-NICO ; database=Curso ; integrated security = true");

        public FormularioSemestre()
        {
            InitializeComponent();
        }

        private void FormularioSemestre_Load(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txb_codAsignatura.Text = ""; //limpia el contenido del textbox codigo
            txb_descripcion.Text = ""; //limpia el contenido del textbox descripcion
            txb_codSemestre.Select(); //Después de limpiar se posiciona en el textbox codigo (.Focus())

            gb_mantenedor.Enabled = true; //habilitar groupbox mantenedor
            txb_codSemestre.Enabled = true;
            gb_botones.Enabled = false; //deshabilitar groupbox botones 

            conexion.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string queryAlumno = "INSERT INTO semestre VALUES (@pk_semestre,@pk_asignatura,@pk_tipo_semestre,@fecha)";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(queryAlumno, conexion);
                cmd.Parameters.AddWithValue("@pk_semestre", txb_codSemestre.Text);
                cmd.Parameters.AddWithValue("@pk_asignatura", txb_codAsignatura.Text);
                cmd.Parameters.AddWithValue("@pk_tipo_semestre", txb_tipoSemestre.Text);
                cmd.Parameters.AddWithValue("@fecha", txb_fecha.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Semestre ingresado correctamente");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

            txb_codSemestre.Text = "";
            txb_descripcion.Text = "";
            gb_mantenedor.Enabled = false;
            gb_botones.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string querySemestre = "EXEC proc_eliminarSemestre @pk_semestre";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(querySemestre, conexion);
                cmd.Parameters.AddWithValue("@pk_semestre", txb_codSemestre.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Semestre eliminado correctamente");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txb_codSemestre.Select();
            gb_mantenedor.Enabled = true; //habilitar groupbox mantenedor
            txb_codSemestre.Enabled = false;
            gb_botones.Enabled = true;

            try
            {
                string querySemestre = "EXEC proc_actualizarSemestre @pk_semestre, @pk_asignatura, @pk_tipo_semestre, @fecha";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(querySemestre, conexion);
                cmd.Parameters.AddWithValue("@pk_semestre", txb_codSemestre.Text);
                cmd.Parameters.AddWithValue("@pk_asignatura", txb_codAsignatura.Text);//Recibe 2 parametros, el primero hace referencia a lo que está escrito en el queryalumno, y el otro es lo que está escrito en el txb 
                cmd.Parameters.AddWithValue("@pk_tipo_semestre", txb_tipoSemestre.Text);
                cmd.Parameters.AddWithValue("@fecha", txb_fecha.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Semestre Actualizado");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
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
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM semestre s, tipo_semestre ts where s.pk_tipo_semestre = ts.pk_tipo_semestre", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv_Curso.DataSource = dt;

                gb_mantenedor.Enabled = true;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            } 
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM semestre WHERE pk_semestre=@pk_semestre", conexion);
                cmd.Parameters.AddWithValue("@pk_alumno", txb_codSemestre.Text);
                conexion.Open();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    txb_codSemestre.Text = registro["pk_semestre"].ToString();
                    txb_codAsignatura.Text = registro["pk_asignatura"].ToString();
                    txb_tipoSemestre.Text = registro["pk_tipo_semestre"].ToString();
                    txb_fecha.Text = registro["fecha"].ToString();
                    txb_descripcion.Text = registro["descripcion"].ToString();
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
            gb_botones.Enabled = true;
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            txb_codSemestre.Text = "";
            txb_descripcion.Text = "";

            gb_mantenedor.Enabled = false; //deshabilitar groupbox mantenedor
            gb_botones.Enabled = true; //habilitar groupbox botones 

            conexion.Close();
        }
    }
}
