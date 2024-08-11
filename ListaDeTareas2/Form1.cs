using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeTareas2
{
    /*Ejercicio 2: Lista de Tareas
       Objetivo: Crear una lista de tareas que permita añadir y eliminar tareas.

        1)Añade un TextBox para ingresar el nombre de la tarea. 
        2)un botón "Añadir" para agregar la tarea a un ListBox.
        3)Un botón "Eliminar" para eliminar la tarea seleccionada en el ListBox.

    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lswTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string agregarTareas = txtAgregar.Text;
            lswTareas.Items.Add(agregarTareas);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lswTareas.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lswTareas.SelectedItems)
                {
                    lswTareas.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Seleccion eliminada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
