using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

    }
}
