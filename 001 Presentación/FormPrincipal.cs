using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_Presentación
{
    public partial class FormPrincipal : Form
    {
        Formulario_alumno FormAlumno;
        FormularioNotas FormNota;
        FormularioAsignatura FormAsignatura;
        FormularioSemestre FormSemestre;
        FormularioPromedioNotas FormPromedioNotas;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        void Alta_Form(object sender, EventArgs e)
        {
            FormAlumno = null;
            FormNota = null;
            FormAsignatura = null;
            FormSemestre = null;
            FormPromedioNotas = null;
        }

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FormAlumno == null) 
            {
                FormAlumno = new Formulario_alumno(); 
                FormAlumno.MdiParent = this;
                FormAlumno.FormClosed += new FormClosedEventHandler(Alta_Form); 
                FormAlumno.Show(); 
            }
            else
            {
                FormAlumno.Activate();
            }
        }

        private void formularioDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormNota == null) // cuando no está creado el formulario se procede a crearse
            {
                FormNota = new FormularioNotas(); //dar valor al contenido de la variable
                FormNota.MdiParent = this; //el contenedor va a ser el mdiparent del formulario
                FormNota.FormClosed += new FormClosedEventHandler(Alta_Form); //Cuando se cierra el formulario se procede a realizar el eevento
                FormNota.Show(); //mostrar el formulario
            }
            else
            {
                FormNota.Activate(); //Se enfoca en este formulario
            }
        }

        private void formularioDeAsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormAsignatura == null) // cuando no está creado el formulario se procede a crearse
            {
                FormAsignatura = new FormularioAsignatura(); //dar valor al contenido de la variable
                FormAsignatura.MdiParent = this; //el contenedor va a ser el mdiparent del formulario
                FormAsignatura.FormClosed += new FormClosedEventHandler(Alta_Form); //Cuando se cierra el formulario se procede a realizar el eevento
                FormAsignatura.Show(); //mostrar el formulario
            }
            else
            {
                FormAsignatura.Activate(); //Se enfoca en este formulario
            }
        }

        private void formularioDeSemestresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormSemestre == null) // cuando no está creado el formulario se procede a crearse
            {
                FormSemestre = new FormularioSemestre(); //dar valor al contenido de la variable
                FormSemestre.MdiParent = this; //el contenedor va a ser el mdiparent del formulario
                FormSemestre.FormClosed += new FormClosedEventHandler(Alta_Form); //Cuando se cierra el formulario se procede a realizar el eevento
                FormSemestre.Show(); //mostrar el formulario
            }
            else
            {
                FormAlumno.Activate(); //Se enfoca en este formulario
            }
        }

        private void formularioPromedioDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormPromedioNotas == null) // cuando no está creado el formulario se procede a crearse
            {
                FormPromedioNotas = new FormularioPromedioNotas(); //dar valor al contenido de la variable
                FormPromedioNotas.MdiParent = this; //el contenedor va a ser el mdiparent del formulario
                FormPromedioNotas.FormClosed += new FormClosedEventHandler(Alta_Form); //Cuando se cierra el formulario se procede a realizar el eevento
                FormPromedioNotas.Show(); //mostrar el formulario
            }
            else
            {
                FormPromedioNotas.Activate(); //Se enfoca en este formulario
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (FormAlumno == null) // cuando no está creado el formulario se procede a crearse
            {
                FormAlumno = new Formulario_alumno(); //dar valor al contenido de la variable
                FormAlumno.MdiParent = this; //el contenedor va a ser el mdiparent del formulario
                FormAlumno.FormClosed += new FormClosedEventHandler(Alta_Form); //Cuando se cierra el formulario se procede a realizar el eevento
                FormAlumno.Show(); //mostrar el formulario
            }
            else
            {
                FormAlumno.Activate(); //Se enfoca en este formulario
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (FormNota == null) // cuando no está creado el formulario se procede a crearse
            {
                FormNota = new FormularioNotas(); //dar valor al contenido de la variable
                FormNota.MdiParent = this; //el contenedor va a ser el mdiparent del formulario
                FormNota.FormClosed += new FormClosedEventHandler(Alta_Form); //Cuando se cierra el formulario se procede a realizar el eevento
                FormNota.Show(); //mostrar el formulario
            }
            else
            {
                FormNota.Activate(); //Se enfoca en este formulario
            }
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            if (FormAsignatura == null) // cuando no está creado el formulario se procede a crearse
            {
                FormAsignatura = new FormularioAsignatura(); //dar valor al contenido de la variable
                FormAsignatura.MdiParent = this; //el contenedor va a ser el mdiparent del formulario
                FormAsignatura.FormClosed += new FormClosedEventHandler(Alta_Form); //Cuando se cierra el formulario se procede a realizar el eevento
                FormAsignatura.Show(); //mostrar el formulario
            }
            else
            {
                FormAsignatura.Activate(); //Se enfoca en este formulario
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (FormAsignatura == null) // cuando no está creado el formulario se procede a crearse
            {
                FormSemestre = new FormularioSemestre(); //dar valor al contenido de la variable
                FormSemestre.MdiParent = this; //el contenedor va a ser el mdiparent del formulario
                FormSemestre.FormClosed += new FormClosedEventHandler(Alta_Form); //Cuando se cierra el formulario se procede a realizar el eevento
                FormSemestre.Show(); //mostrar el formulario
            }
            else
            {
                FormSemestre.Activate(); //Se enfoca en este formulario
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (FormPromedioNotas == null) // cuando no está creado el formulario se procede a crearse
            {
                FormPromedioNotas = new FormularioPromedioNotas(); //dar valor al contenido de la variable
                FormPromedioNotas.MdiParent = this; //el contenedor va a ser el mdiparent del formulario
                FormPromedioNotas.FormClosed += new FormClosedEventHandler(Alta_Form); //Cuando se cierra el formulario se procede a realizar el eevento
                FormPromedioNotas.Show(); //mostrar el formulario
            }
            else
            {
                FormPromedioNotas.Activate(); //Se enfoca en este formulario
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
