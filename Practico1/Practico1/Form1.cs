using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;

            if (string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("No hay nada para Eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Estas seguro que desea eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    txtMulti.Clear();   //con el metodo clear podemos borrar el contenidod de un cuadro de texto es decir de ese textBox que llama al metodo
                    txtApellido.Clear();
                    txtNombre.Clear();
                }
            }
        }

        // Evento que se dispara cuando se presionan teclas mientras el formulario tiene el enfoque
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla Control (Ctrl) está presionada y si la tecla S también está presionada
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.Handled = true; // Evita que se realice la acción predeterminada (como guardar)

                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                {
                    // No hacer nada, ya que el usuario eligió no salir
                }
                else
                {
                    // Si se cumplen las condiciones, cerrar el formulario
                    this.Close();
                }
            }
        }

        // Método que se ejecuta cuando se hace clic en el botón "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();//con este metodo del propio objeto podemos cerrar el formulairo
        }

        //Un evento KeyPress se dispara cada vez que se presiona una tecla mientras un control, como un TextBox, tiene el foco
        //El objetivo de estos eventos es permitir que solo se ingresen letras en los TextBox y bloquear la entrada de otros caracteres
        //asegura que solo se puedan ingresar letras en los TextBox y evita que se ingresen caracteres no deseados como números o símbolos
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifica si la tecla presionada no es una tecla de control (teclas como Enter o Backspace) y no es una letra.
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {// Si la tecla presionada no es una letra y no es una tecla de control, se establece e.Handled en true. Esto significa que el evento se ha manejado y que no se procesará más. Como resultado, la tecla no se insertará en el TextBox.
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifica si la tecla presionada no es una tecla de control (teclas como Enter o Backspace) y no es una letra.
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {// Si la tecla presionada no es una letra y no es una tecla de control, se establece e.Handled en true. Esto significa que el evento se ha manejado y que no se procesará más. Como resultado, la tecla no se insertará en el TextBox.
                e.Handled = true;
            }
        }
    }
}
