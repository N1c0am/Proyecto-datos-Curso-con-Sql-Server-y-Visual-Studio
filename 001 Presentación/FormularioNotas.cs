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
    public partial class FormularioNotas : Form
    {
        SqlConnection conexion = new SqlConnection("server=SJR1NSAH-NICO ; database=Curso ; integrated security = true");
        public FormularioNotas()
        {
            InitializeComponent();
        }
        private void FormularioNotas_Load(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txb_run.Text = ""; //limpia el contenido del textbox codigo
            txb_nota.Text = ""; //limpia el contenido del textbox descripcion
            txb_run.Select(); //Después de limpiar se posiciona en el textbox codigo (.Focus())

            gb_mantenedor.Enabled = true; //habilitar groupbox mantenedor
            txb_run.Enabled = true;
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
                string queryNota = "INSERT INTO nota VALUES (@pk_nota,@pk_alumno,@pk_semestre,@pk_asignatura,@nota,@num_nota)";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(queryNota, conexion);
                cmd.Parameters.AddWithValue("@pk_nota", txb_codNota.Text);
                cmd.Parameters.AddWithValue("@pk_alumno", txb_run.Text);
                cmd.Parameters.AddWithValue("@pk_semestre", txb_semestre.Text);
                cmd.Parameters.AddWithValue("@pk_asignatura", txb_asignatura.Text);
                cmd.Parameters.AddWithValue("@nota", txb_nota.Text);
                cmd.Parameters.AddWithValue("@num_nota", txb_cursoSemestre.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Nota ingresado correctamente");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            txb_run.Text = "";
            txb_nota.Text = "";
            gb_mantenedor.Enabled = false;
            gb_botones.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string queryAlumno = "DELETE FROM nota WHERE pk_nota=@pk_nota";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(queryAlumno, conexion);
                cmd.Parameters.AddWithValue("@pk_nota", txb_codNota.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Nota eliminado correctamente");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txb_run.Select();
            gb_mantenedor.Enabled = true; //habilitar groupbox mantenedor
            txb_run.Enabled = false;
            gb_botones.Enabled = true;

            try
            {
                string queryNota = "UPDATE nota SET nota=@nota, num_nota=@num_nota WHERE pk_nota=@pk_nota";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(queryNota, conexion);
                cmd.Parameters.AddWithValue("@pk_nota", txb_codNota.Text);
                cmd.Parameters.AddWithValue("@pk_alumno", txb_run.Text);//Recibe 2 parametros, el primero hace referencia a lo que está escrito en el queryalumno, y el otro es lo que está escrito en el txb 
                cmd.Parameters.AddWithValue("@pk_semestre", txb_semestre.Text);
                cmd.Parameters.AddWithValue("@pk_asignatura", txb_asignatura.Text);
                cmd.Parameters.AddWithValue("@nota", txb_nota.Text);
                cmd.Parameters.AddWithValue("@num_nota", txb_cursoSemestre.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Nota Actualizada Correctamente");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
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
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Nota", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv_Curso.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            gb_mantenedor.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM nota WHERE pk_nota=@pk_nota", conexion);
                cmd.Parameters.AddWithValue("@pk_nota", txb_codNota.Text);
                conexion.Open();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    txb_run.Text = registro["pk_alumno"].ToString();
                    txb_semestre.Text = registro["pk_semestre"].ToString();
                    txb_asignatura.Text = registro["pk_asignatura"].ToString();
                    txb_nota.Text = registro["nota"].ToString();
                    txb_cursoSemestre.Text = registro["num_nota"].ToString();
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            gb_botones.Enabled = true;
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            txb_run.Text = "";
            txb_nota.Text = "";

            gb_mantenedor.Enabled = false; //deshabilitar groupbox mantenedor
            gb_botones.Enabled = true; //habilitar groupbox botones 

            conexion.Close();
        }
    }
}
