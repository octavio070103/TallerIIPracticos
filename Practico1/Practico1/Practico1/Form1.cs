using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        // Método que se ejecuta cuando se hace clic en el botón "Guardar"

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;

            // Concatenar el apellido y el nombre con un espacio en blanco
            string nombreCompleto = nombre + " " + apellido;

            // Mostrar el nombre completo en el tercer TextBox
            txtMulti.Text = nombreCompleto;
        }

       private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();//con este metodo del propio objeto podemos cerrar el formulairo
        }

        // Método que se ejecuta cuando se hace clic en el botón "Eliminar"
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtMulti.Clear();   //con el metodo clear podemos borrar el contenidod de un cuadro de texto es decir de ese textBox que llama al metodo
            txtApellido.Clear();
            txtNombre.Clear();
        }

        // Evento que se dispara cuando se presionan teclas mientras el formulario tiene el enfoque
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla Control (Ctrl) está presionada y si la tecla S también está presionada
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Si se cumplen las condiciones, cerrar el formulario
                this.Close();
            }
        }

        // Método que se ejecuta cuando se hace clic en el botón "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();//con este metodo del propio objeto podemos cerrar el formulairo
        }
    }
}
