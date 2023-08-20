using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico4
{
    public partial class Form1 : Form
    {
        //El constructor public Form1() es el método que se llama cuando se crea un nuevo objeto de la clase Form2. InitializeComponent() es un método que inicializa
        //todos los componentes visuales (controles) en el formulario.
        public Form1()
        {
            InitializeComponent();
        }

        //se define el eventoi del clic para el boton guardar,es decir que cuando se realice el eventode hacer click sobre este boton se ejcutara este metodo
        private void btnFuncion_Click(object sender, EventArgs e)
        {
            if (validarCampos() ) {
            borrarMensajeError();
            generarFuncion();
            }
            
        }

        private bool validarCampos()
        {
            string numeroInicial = txtDesde.Text;
            string numeroFinal = txtHasta.Text;
            int numero = 0;
            bool validacion = true;

            if(string.IsNullOrWhiteSpace(numeroInicial) || string.IsNullOrWhiteSpace(numeroFinal))
            {
                MessageBox.Show("Debe de completar todos los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                errorProvider1.SetError(lblDesde,"Ingrese el numero inicial");
                errorProvider1.SetError(lblHasta,"Ingrese el numero final");
                return validacion = false;
            }

            /*, esta línea de código verifica si numeroFinal puede convertirse en un valor 
             * numérico entero (int) utilizando int.TryParse. Si la conversión es exitosa (es decir, si int.TryParse devuelve true),
             * el bloque dentro del if no se ejecutará, lo que significa que numeroFinal es un número válido. Si la conversión falla 
             * (es decir, si int.TryParse devuelve false), el bloque dentro del if se ejecutará, indicando que numeroFinal no es un número válido.
             * */
            if(!int.TryParse(numeroInicial,out numero))
            {
                errorProvider1.SetError(lblDesde, "ingrese el numero inicial");
                MessageBox.Show("Debe de ser solo numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 validacion = false;
            }

            if(!int.TryParse(numeroFinal,out numero))
            {
                errorProvider1.SetError(lblHasta, "ingrese el numero fianl");
                MessageBox.Show("Debe de ser solo numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            if (Int32.Parse(numeroInicial) > Int32.Parse(numeroFinal))
            {
                MessageBox.Show("El numero inicial debe de ser menor que el numero Final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            return validacion;
        }

        //limpia los mensajes de error que se muestran junto a los campos en caso de que hayan errores de validación.
        private void borrarMensajeError()
        {
            errorProvider1.SetError(lblDesde, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblHasta, "");    // Limpiar mensaje de error
        }

        private void generarFuncion()
        {
            int numeroInicial = Int32.Parse(txtDesde.Text);
            int numeroFinal = Int32.Parse(txtHasta.Text);

            while (numeroInicial <= numeroFinal)
            {
                listBoxNum.Items.Add(numeroInicial);//Esta función nos permite agregar ítem allistBox
                 numeroInicial = numeroInicial+1;

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDesde.Clear();
            txtHasta.Clear();
            listBoxNum.Items.Clear();//Para limpiar los elementos que se cargaron en un ListBox,elimina todos los elementos de la lsira
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                borrarMensajeError();
                generarPares();
            }
        }
        private void generarPares()
        {
            int numeroInicial = Int32.Parse(txtDesde.Text);
            int numeroFinal = Int32.Parse(txtHasta.Text);

            while (numeroInicial <= numeroFinal)
            {
                if(numeroInicial % 2 == 0)
                {
                    listBoxNum.Items.Add(numeroInicial);//Esta función nos permite agregar ítem allistBox
                }
              
                numeroInicial = numeroInicial + 1;

            }

        }

        private void btnImpares_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                borrarMensajeError();
                generarImpares();
            }
        }
        private void generarImpares()
        {
            int numeroInicial = Int32.Parse(txtDesde.Text);
            int numeroFinal = Int32.Parse(txtHasta.Text);

            while (numeroInicial <= numeroFinal)
            {
                if (numeroInicial % 2 != 0)
                {
                    listBoxNum.Items.Add(numeroInicial);//Esta función nos permite agregar ítem allistBox
                }

                numeroInicial = numeroInicial + 1;

            }

        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                borrarMensajeError();
                generarPrimos2();
            }
            
        }

        //esta funcion me permite obtener los numero primos 
        private void generarPrimos()
        {
            int numeroInicial = Int32.Parse(txtDesde.Text);
            int numeroFinal = Int32.Parse(txtHasta.Text);
            int divisores = 0;

            //inicio mi bulce while con la condicion que se ejecute mientras que numero inicial sea menor o igual a numeroFianl
            while (numeroInicial <= numeroFinal)
            {
                //aca hago un for para recorrer desde el 1er numero que es el 1 hasta el numero final para pdoer ir dividiendo el numeroInicial por el rango de numero que tengo y asi comprobar si es primo o no
                for (int i = 1; i <= numeroFinal; i++)
                {
                    //aca preugnto si el modulo de i con ese numeroInicial es == 0 es decir numInicial es divido por i entra en el if
                    if (numeroInicial % i == 0)
                    {

                        divisores=divisores+1;//con este contador voy a poder saber cuantos divisores tiene ese numero ya que los numPrimos solo tiene 2 dividores ellos mismo y el 1 
                    }
                }
                //aca pregunto una vez que termino el for y dividio por todos los numeros posibles ,si el divisor es ==2 es primo si es mayor no lo es y si es menor tampoco
                if (divisores ==2)
                {
                    listBoxNum.Items.Add(numeroInicial);//Esta función nos permite agregar ítem allistBox
                }
                divisores = 0;//aca reinicio el contador para el proxiumo numero que qiero saber si es primo
                numeroInicial = numeroInicial + 1;

            }

        }

        /*version mejorara para generar los numeros primos */
        private bool esPrimo(int numero)
        {
            //aca con este if determino que todos lso numeros que son igual o menor  1 que deirectamente me retorne que no son primos es decir que retorne un false
            if(numero <= 1)//aca tambien descarto los num negativos como primos ya que los primos son un subcojunto de los naturales y no tiene una aplicacion practica por l oque no se los considera a ese conjunto como numero Primo
            {
                return false;//retorno false es decir que NO es primo directamente
            }

            //aca voy a ahcer uso del bucle for para ver si ese numero es divisible por el resto de numero que sea menor o igual a su raiz cuadrada
            //ya que Esto se debe a que, si el número tiene algún divisor mayor a su raíz cuadrada, entonces el cociente entre éstos es otro divisor que es menor o igual a su raíz cuadrada.
            //es decir si un número es divisible por algún número mayor que su raíz cuadrada, entonces también debe ser divisible por un número menor que su raíz cuadrada. Dividir por un número mayor que la raíz cuadrada ya se habría detectado en iteraciones anteriores.
            for (int i = 2; i <= Math.Sqrt(numero); i++)//y el bucle empieza en 2 ya que todos los numeros son divisibles por 1 
            {
                /* se verifica si el número numero es divisible por i. Si el residuo de la división es cero, significa que numero es divisible por i, lo que implica que no es primo.*/
                if (numero % i == 0)
                {
                    return false;
                }
                   
            }
            return true;//Si el bucle completa todas las iteraciones sin encontrar ninguna división exacta, entonces se devuelve true, lo que indica que el número es primo.
        }

       private void generarPrimos2()
        {
            int numeroInicial = Int32.Parse(txtDesde.Text);
            int numeroFinal = Int32.Parse(txtHasta.Text);
            /*Se utiliza un bucle for para iterar desde numeroInicial hasta numeroFinal. En cada iteración, se verifica si el número actual es primo utilizando la función EsPrimo. Si es primo, se agrega al ListBox*/
            for (int num = numeroInicial; num <= numeroFinal; num++)
            {
                if (esPrimo(num))
                {
                    listBoxNum.Items.Add(num);
                }
            }
        }

    }
}
