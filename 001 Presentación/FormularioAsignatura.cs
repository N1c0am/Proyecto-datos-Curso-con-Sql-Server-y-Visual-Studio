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
    public partial class FormularioAsignatura : Form
    {
        SqlConnection conexion = new SqlConnection("server=SJR1NSAH-NICO ; database=Curso ; integrated security = true");
        public FormularioAsignatura()
        {
            InitializeComponent();
        }
        private void FormularioAsignatura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cursoDataSet.asignatura' Puede moverla o quitarla según sea necesario.
            this.asignaturaTableAdapter.Fill(this.cursoDataSet.asignatura);

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txb_codAsignatura.Text = "";
            txb_nombre.Text = "";
            txb_descripcion.Text = ""; 
            txb_codAsignatura.Select(); 

            gb_mantenedor.Enabled = true; 
            txb_codAsignatura.Enabled = true;
            gb_botones.Enabled = false;

            conexion.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string queryAsignatura = "INSERT INTO asignatura VALUES (@pk_asignatura,@asig_descripcion,@asig_nombre)";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(queryAsignatura, conexion);
                cmd.Parameters.AddWithValue("@pk_asignatura", txb_codAsignatura.Text);
                cmd.Parameters.AddWithValue("@asig_descripcion", txb_descripcion.Text);
                cmd.Parameters.AddWithValue("@asig_nombre", txb_nombre.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Asignatura ingresado correctamente");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            txb_codAsignatura.Text = "";
            txb_nombre.Text = "";
            txb_descripcion.Text = "";
            gb_mantenedor.Enabled = false;
            gb_botones.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string queryAsignatura = "DELETE FROM asignatura WHERE pk_asignatura=@pk_asignatura";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(queryAsignatura, conexion);
                cmd.Parameters.AddWithValue("@pk_asignatura", txb_codAsignatura.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Asignatura eliminada correctamente");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txb_codAsignatura.Select();
            gb_mantenedor.Enabled = true;
            txb_codAsignatura.Enabled = false;
            gb_botones.Enabled = true;

            try
            {
                string queryAsignatura = "UPDATE alumno SET asig_descripcion=@asig_descripcion, asig_nombre=@asig_nombre WHERE pk_asignatura=@pk_asignatura";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(queryAsignatura, conexion);
                cmd.Parameters.AddWithValue("@pk_asignatura", txb_codAsignatura.Text);
                cmd.Parameters.AddWithValue("@asig_descripcion", txb_descripcion.Text);//Recibe 2 parametros, el primero hace referencia a lo que está escrito en el queryalumno, y el otro es lo que está escrito en el txb 
                cmd.Parameters.AddWithValue("@asig_nombre", txb_nombre.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Asignatura Actualizada");
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
                MessageBox.Show("ERROR: "+ex.Message);
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Asignatura", conexion);
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM asignatura WHERE pk_asignatura=@pk_asignatura", conexion);
                cmd.Parameters.AddWithValue("@pk_asignatura", txb_codAsignatura.Text);
                conexion.Open();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    txb_nombre.Text = registro["asig_descripcion"].ToString();
                    txb_descripcion.Text = registro["asig_nombre"].ToString();

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
            txb_codAsignatura.Text = "";
            txb_nombre.Text = "";
            txb_descripcion.Text = "";

            gb_mantenedor.Enabled = false;
            gb_botones.Enabled = true;

            conexion.Close();
        }
    }
}
