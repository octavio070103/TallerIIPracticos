using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Estas líneas son las directivas using, que permiten al programa acceder a diferentes clases
//y funcionalidades dentro de los espacios de nombres especificados.

//definimos un nuevo espacio llamado Practico2
namespace Practico2
{
    //creamos la clase llamada form2 que hereda de la clase Form(Clase base para formularios enh windows form
    public partial class Form2 : Form //public partial indica que esta clase se define en múltiples archivos
    {
        //El constructor public Form2() es el método que se llama cuando se crea un nuevo objeto de la clase Form2. InitializeComponent() es un método que inicializa
        //todos los componentes visuales (controles) en el formulario.
        public Form2()
        {
            InitializeComponent();
        }

        //se define el eventoi del clic para el boton guardar,es decir que cuando se realice el eventode hacer click sobre este boton se ejcutara este metodo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                // Crear la variable "ask" del tipo DialogoREsult ya que MsgBoxREsult es parte del lenguaje Basic y no de C#
                DialogResult ask;//se declara una variable llamada ask del tipo DialogResult, que se usará para almacenar el resultado del cuadro de diálogo.
                borrarMensajeError();
                validarCampos();
                ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente? ", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //como  Todos los msgbox devuelven un resultado lógico. podemos hacer el sig if
                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El cliente: " + txtNombre.Text + " " + txtApellido.Text + " se inserto correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("El cliente: " + txtNombre.Text + " " + txtApellido.Text + " No se inserto ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        private bool validarCampos()
        {
            bool validacion = true;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string dni = txtDni.Text;
            string nombreCompleto = nombre + " " + apellido;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(dni))
            {
                // MessageBox.Show("Debe de completar todos los campos");
                MessageBox.Show("debe de Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(lblNombre, "Ingrese su nombre");//El primer argumento es el control al que deseas asociar el mensaje de error..El segundo argumento es el mensaje de error que deseas mostrar.  
                errorProvider1.SetError(lblApellido, "Ingrese su DNI");
                errorProvider1.SetError(lblDni, "Ingrese su DNI");
                 validacion=false;
            }

            //validar que el campos Dni solo se ingresen numeros
            if (!int.TryParse(dni, out int num))
            {
                errorProvider1.SetError(lblDni, "Ingrese su DNI");
                MessageBox.Show("El Dni debe de contener solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false; 
            }

            // Validar que los campos Apellido y Nombre contengan solo letras
            if (!EsAlfabetico(apellido))
            {
                errorProvider1.SetError(lblApellido, "Ingrese su apellido");
                MessageBox.Show(" El apellido debe de contener solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 validacion = false; 
            }

            if (!EsAlfabetico(nombre))
            {
                errorProvider1.SetError(lblNombre, "Ingrese su nombre");
                MessageBox.Show(" El nombre debe de contener solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 validacion = false;
            }

            lblModificar.Text = nombreCompleto;
            return validacion;
        }

        // Función para verificar si una cadena contiene solo letras
        private bool EsAlfabetico(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        //limpia los mensajes de error que se muestran junto a los campos en caso de que hayan errores de validación.
        private void borrarMensajeError()
        {
            errorProvider1.SetError(lblNombre, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblDni, "");    // Limpiar mensaje de error
            errorProvider1.SetError(lblApellido, ""); // Limpiar mensaje de error
        }

        //evento de clic para el botón "Eliminar"
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            // Crear la variable "ask" del tipo DialogoREsult ya que MsgBoxREsult es parte del lenguaje Basic y no de C#
            DialogResult ask;

            //Usamos MessageBox.Show() para mostrar un mensaje de advertencia similar al caso del botón "Guardar", pero con un ícono de exclamación y con el enfoque en el botón "NO" (usando MessageBoxDefaultButton.Button2).
            ask = MessageBox.Show("Esta apunto de eliminar el Cliente " + txtNombre.Text + " " + txtApellido.Text, "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            //como  Todos los msgbox devuelven un resultado lógico. podemos hacer el sig if
            if (ask == DialogResult.Yes)
            {
                eliminarCliente();
                MessageBox.Show("El cliente: " + txtNombre.Text + " " + txtApellido.Text + " se elimino correctamente", "eliminar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        //Esta función eliminarCliente() borra el contenido de los campos txtApellido, txtNombre y txtDni, y también asigna una cadena vacía a la etiqueta lblNomyApe
        private void eliminarCliente()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtDni.Clear();
            lblNomyApe.Text = "";
        }


        //Un evento KeyPress se dispara cada vez que se presiona una tecla mientras un control, como un TextBox, tiene el foco
        //El objetivo de estos eventos es permitir que solo se ingresen letras en los TextBox y bloquear la entrada de otros caracteres
        //asegura que solo se puedan ingresar letras en los TextBox y evita que se ingresen caracteres no deseados como números o símbolos

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifica si la tecla presionada no es una tecla de control (teclas como Enter o Backspace) y no es una letra.
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {// Si la tecla presionada no es una letra y no es una tecla de control, se establece e.Handled en true. Esto significa que el evento se ha manejado y que no se procesará más. Como resultado, la tecla no se insertará en el TextBox.
                e.Handled = true;
            }
        }

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
