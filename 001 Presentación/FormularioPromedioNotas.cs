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
    public partial class FormularioPromedioNotas : Form
    {
        SqlConnection conexion = new SqlConnection("server=SJR1NSAH-NICO ; database=Curso ; integrated security = true");

        public FormularioPromedioNotas()
        {
            InitializeComponent();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("EXEC proc_promedioNotasAlumno", conexion);
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
        }

        private void btn_notasAltas_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("EXEC proc_promedioNotasAltas", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv_notasAltas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btn_notasBajas_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("EXEC proc_promedioNotasBajas", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv_notasBajas.DataSource = dt;
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
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        private void FormularioPromedioNotas_Load(object sender, EventArgs e)
        {

        }
    }
    
}
