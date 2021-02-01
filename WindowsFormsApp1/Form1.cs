using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneraDatos();
        }

        /// <summary>
        /// Función que genera los datos
        /// </summary>
        private void GeneraDatos()
        {
            datos.Rows.Clear();
            datos.Columns.Clear();
            int c;
            int totalRegistros = int.Parse(this.totalRegistros.Text);

            int indiceReprobacionMateria = GeneraDato(indiceReprobacionMateriaMin.Value, indiceReprobacionMateriaMax.Value);
            int indiceReprobacionProfesor = GeneraDato(indiceReprobacionProfesorMin.Value, indiceReprobacionProfesorMax.Value);

            c = datos.Columns.Add("", "Índice de reprobación de la materia");
            c = datos.Columns.Add("", "Índice de reprobación del profesor");
            c = datos.Columns.Add("", "Número de veces inscrita EDII");
            c = datos.Columns.Add("", "Calificación Estructuras I");
            c = datos.Columns.Add("", "Número de veces inscritaEstructuras I");
            c = datos.Columns.Add("", "Calificación Pensamiento");
            c = datos.Columns.Add("", "Número de veces inscritaPensamiento");
            c = datos.Columns.Add("", "Promedio aprobatorio");
            c = datos.Columns.Add("", "Promedio general");
            c = datos.Columns.Add("", "Materias aprobadas semestre pasado");
            c = datos.Columns.Add("", "Materias reprobadas semestre pasado");
            c = datos.Columns.Add("", "Faltas por semestre");
            c = datos.Columns.Add("", "Nivel de semestre que va");
            c = datos.Columns.Add("", "Pensamiento aprobado en");
            c = datos.Columns.Add("", "Estructuras aprobado en");

            var r = 0;

            for (int i = 0; i < totalRegistros; i++)
            {
                r = datos.Rows.Add();
                datos.Rows[r].Cells[0].Value = indiceReprobacionMateria;
                datos.Rows[r].Cells[1].Value = indiceReprobacionProfesor;
                datos.Rows[r].Cells[2].Value = GeneraDato(vecesInscritaEDIIMin.Value, vecesInscritaEDIIMax.Value);
            }
        }
        /// <summary>
        /// Función que retorna el valor del dato
        /// </summary>
        /// <param name="minimo">Valor minimo que puede tomar el dato</param>
        /// <param name="maximo">Valor maximo que puede tomar el dato</param>
        /// <returns></returns>
        private int GeneraDato(int minimo, int maximo)
        {
            int r = 0;

            var rand = new Random((new DateTime().Millisecond * new DateTime().Second) * new Random().Next(new DateTime().Millisecond));
            r = rand.Next(minimo, maximo+1);

            return r;
        }
        private int GeneraDato(Decimal minimo, Decimal maximo)
        {
            int r = 0;

            var rand = new Random((new DateTime().Millisecond * new DateTime().Second) * new Random().Next(new DateTime().Millisecond));
            r = rand.Next(Convert.ToInt32(minimo), Convert.ToInt32(maximo)+1);
            return r;
        }
    }
}
