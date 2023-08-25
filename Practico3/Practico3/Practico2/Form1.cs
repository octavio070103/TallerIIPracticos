using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Estas líneas son las directivas using, que permiten al programa acceder a diferentes clases
//y funcionalidades dentro de los espacios de nombres especificados.

//definimos un nuevo espacio llamado Practico2
namespace Practico2
{
    //creamos la clase llamada form2 que hereda de la clase Form(Clase base para formularios enh windows form
    public partial class Form1 : Form //public partial indica que esta clase se define en múltiples archivos
    {
        //El constructor public Form2() es el método que se llama cuando se crea un nuevo objeto de la clase Form2. InitializeComponent() es un método que inicializa
        //todos los componentes visuales (controles) en el formulario.
        public Form1()
        {
            InitializeComponent();
        
            //selecciono po rdefecto que este selecionado el raddioButton Varon
            rbtnVaron.Checked = true;
        }

        //se define el eventoi del clic para el boton guardar,es decir que cuando se realice el eventode hacer click sobre este boton se ejcutara este metodo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                // Crear la variable "ask" del tipo DialogoREsult ya que MsgBoxREsult es parte del lenguaje Basic y no de C#
                DialogResult ask;//se declara una variable llamada ask del tipo DialogResult, que se usará para almacenar el resultado del cuadro de diálogo.
                borrarMensajeError();
               // validarCampos();

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
          
           

        }

        private bool validarCampos()
        {
            bool validacion = true;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string dni = txtDni.Text;
            string telefono = txtTelefono.Text;
            int numero = 0;

            string nombreCompleto = nombre + " " + apellido;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(dni) ||string.IsNullOrWhiteSpace(telefono) || validarTarjeta() == false )
            {
                // MessageBox.Show("Debe de completar todos los campos");
                MessageBox.Show("Por favor, complete todos los campos correctamente.",  "Campos Incompletos",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(lblNombre, "Ingrese su nombre");//El primer argumento es el control al que deseas asociar el mensaje de error..El segundo argumento es el mensaje de error que deseas mostrar.  
                errorProvider1.SetError(lblApellido, "Ingrese su Apellido");
                errorProvider1.SetError(lblDni, "Ingrese su DNI");
                errorProvider1.SetError(lblTelefono, "Ingrese su Telefono");
                return validacion =false;
            }

            //validar que el campos Dni solo se ingresen numeros
            if (!int.TryParse(dni, out  numero))
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

            //validar que el campos Dni solo se ingresen numeros
            if (!int.TryParse(telefono, out numero))
            {
                errorProvider1.SetError(lblTelefono, "Ingrese su Telefono");
                MessageBox.Show("El Telefono debe de contener solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            errorProvider1.SetError(lblTelefono, ""); // Limpiar mensaje de error

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

        //aca como nos dice el tp usamos la instruccion Me.Close donde ME hace referencia a la isntacnia actual del form es decir al mismo objeto 
        //entonces es this.Close this se refiere al formulario actual, y Close() es un método que pertenece al formulario y se usa para cerrarlo.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();//aca hacemos que la ventana actual se cierra y se destruye, lo que significa que la ventana y todos sus recursos asociados se liberan de la memoria.
        }

        //maneja el evento CheckedChanged de los RadioButtons para cambiar la imagen del PictureBox según la selección
        private void rbtnVaron_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnVaron.Checked)
            {
                //cambiar la imagen del PictureBox al icono Hombre,para hacer esto debo de tener las imagenes importadas en mis proyecto con pictureBox tasks
                pictureBox1.Image = Practico2.Properties.Resources.jefe;

            }
        }

        //maneja el evento CheckedChanged de los RadioButtons para cambiar la imagen del PictureBox según la selección
        private void rbtnMujer_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnMujer.Checked)
            {
                //cambiar la imagen del PictureBox al icono Mujer,para hacer esto debo de tener las imagenes importadas en mis proyecto con pictureBox tasks
                pictureBox1.Image = Practico2.Properties.Resources.mujer_de_negocios;

            }
        }

        //aca se valida que un ade las opciones de tarjeta tenga el estado de marcado es decir que este check
        private bool validarTarjeta()
        {
            bool validacion = false;

            if(checkBoxNaranja.Checked == true)
            {
                validacion = true;
            }
            if (checkBoxVisa.Checked == true)
            {
                validacion = true;
            }
            if (checkBoxMaster.Checked == true)
            {
                validacion = true;
            }

            return validacion;
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
