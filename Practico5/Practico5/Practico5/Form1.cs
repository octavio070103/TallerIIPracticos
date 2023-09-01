using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        /*
         * el evento Click del botón "Foto" está configurado para mostrar el cuadro de diálogo OpenFileDialog. 
         * Después de que el usuario seleccione una imagen, la propiedad ImageLocation del PictureBox se establece 
         * en la ruta del archivo seleccionado, lo que hará que la imagen se muestre en el PictureBox. Además, 
         * la ruta del archivo seleccionado se muestra en el TextBox txtFoto.
         */
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establece el filtro para mostrar solo archivos de imagen
            openFileDialog.Filter = "Archivos de Imagen | *.jpg;*.png;*.bmp;*.gif|Todos los archivos|*.* " ;

            if(openFileDialog.ShowDialog() == DialogResult.OK )
            {
                string imagePath = openFileDialog.FileName;

                // Mostrar la imagen en el PictureBox
                pictureBox.ImageLocation = imagePath;

                // Mostrar la ruta del archivo en el TextBox
                txtFoto.Text = imagePath;
            }
        }
        /*definimos dos manejadores de eventos leave(se dispara cuando un control ,pierde el foco, es decir, cuando el usuario cambia su atención a otro control o área de la interfaz,es útil para controlar acciones que deben realizarse cuando el usuario ha terminado de interactuar con un control específico y está cambiando su atención a otro control o área de la interfaz.
         * par alos textBox txtNombre y txtA0pellido haciendo que cuandop el usuario abandone esos textBox se llame al metodo ConvertirAMayuscula para realizar el cambio de formato
         */
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;//la expresión (TextBox)sender se utiliza para obtener el objeto TextBox que desencadenó el evento.
                                              //sender es el objeto que generó el evento este dato es de tipo object por lo que aqui lo casteo a tipo TextBox para trabajr con el                          
            textBox.Text = ConvertirAMayuscula(textBox.Text);//llamo a mi funcion MAyuscula y le paso como argumento el contenido del textBox y luego digo que ese resultado me lo asigne al txtBox de nuevo
        }

        //El evento Leave se dispara cuando el control pierde el foco.
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;//la expresión (TextBox)sender se utiliza para obtener el objeto TextBox que desencadenó el evento.
                                              //sender es el objeto que generó el evento este dato es de tipo object por lo que aqui lo casteo a tipo TextBox para trabajr con el                          
            textBox.Text = ConvertirAMayuscula(textBox.Text);//llamo a mi funcion MAyuscula y le paso como argumento el contenido del textBox y luego digo que ese resultado me lo asigne al txtBox de nuevo

        }

        private string ConvertirAMayuscula(string input)
        {
            //El método MAsyucula toma una cadena de entrada (input) y verifica si está vacía o nula. Si es así, devuelve la entrada sin cambios
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
               

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;//creo un opbjeto TextInfo utilizando la cultura "en-US"   para realizar operaciones de formato de texto. Esto es útil para asegurarse de que las reglas de capitalización se apliquen correctamente en ese idioma.
            return textInfo.ToTitleCase(input.ToLower());//que capitaliza la primera letra de cada palabra en la cadena. El método también convierte el resto de las letras a minúsculas.
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
            string foto = txtFoto.Text;
            string saldo = txtSaldo.Text;
            string fechaDeNac = dateTimePicker1.Text;
            string sexo = "";

            if (radioButtonHombre.Checked)
            {
                sexo = "Hombre";
            }
            else if (radioButtonMujer.Checked)
            {
                sexo = "Mujer";
            }

            int numero = 0;

           
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(foto) || string.IsNullOrWhiteSpace(saldo) || string.IsNullOrWhiteSpace(fechaDeNac) || string.IsNullOrWhiteSpace(sexo))
            {
                // MessageBox.Show("Debe de completar todos los campos");
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(lblNombre, "Ingrese su nombre");//El primer argumento es el control al que deseas asociar el mensaje de error..El segundo argumento es el mensaje de error que deseas mostrar.  
                errorProvider1.SetError(lblApellido, "Ingrese su Apellido");
                errorProvider1.SetError(btnFoto, "Ingrese La imagen");
                errorProvider1.SetError(lblSexo, "Ingrese su sexo");
                errorProvider1.SetError(lblSaldo, "Ingrese su Saldo");
                errorProvider1.SetError(lblFechaNacimiento, "Ingrese su fecha de nacimiento");
                return validacion = false;
            }

            //validar que el campos saldo par que solo se ingresen numeros
            if (!int.TryParse(saldo, out numero))
            {
                errorProvider1.SetError(lblSaldo, "Ingrese su saldo");
                MessageBox.Show("El saldo debe de contener solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
          
            string extension = Path.GetExtension(foto).ToLower();
            //validar que el campos Dni solo se ingresen numeros
            if (extension != ".jpg" || extension != ".jpeg" || extension != ".png" || extension != ".PNG" || extension != ".gif" || extension != ".bmp")
            {
                errorProvider1.SetError(btnFoto, "Ingrese una imagen con un format valido");
                MessageBox.Show("El formato de imagen debe de ser valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

           
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
            errorProvider1.SetError(lblApellido, "");    // Limpiar mensaje de error
            errorProvider1.SetError(lblFechaNacimiento, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblSexo, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblSaldo, ""); // Limpiar mensaje de error
            errorProvider1.SetError(btnFoto, ""); // Limpiar mensaje de error
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            // Crear la variable "ask" del tipo DialogoREsult ya que MsgBoxREsult es parte del lenguaje Basic y no de C#
            DialogResult ask;

            //Usamos MessageBox.Show() para mostrar un mensaje de advertencia similar al caso del botón "Guardar", pero con un ícono de exclamación y con el enfoque en el botón "NO" (usando MessageBoxDefaultButton.Button2).
            ask = MessageBox.Show("Esta apunto de eliminar el registro " + txtNombre.Text + " " + txtApellido.Text, "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            //como  Todos los msgbox devuelven un resultado lógico. podemos hacer el sig if
            if (ask == DialogResult.Yes)
            {
                //eliminarCliente();
                MessageBox.Show("El cliente: " + txtNombre.Text + " " + txtApellido.Text + " se elimino correctamente", "eliminar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtSaldo.Clear();
            txtFoto.Clear();
            dateTimePicker1.ResetText();
        }
    }
}
