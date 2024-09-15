using System.Windows.Forms;

namespace Tienda_tacatra
{
    public partial class Wtienda : Form
    {
        public Wtienda()
        {
            InitializeComponent();

        }
        string[] productos;
        float minimovalor = float.MaxValue;
        int mejorvendido = int.MinValue;



        private void cmdagregarprod_Click(object sender, EventArgs e)
        {
            if (txtproducto.Text != "" && txtvaloruni.Text != "")
            {
                // Pasa el texto de txtproducto a minusculas y el txtvaloruni a tipo float
                string textoabase = txtproducto.Text.ToLower();
                float valorbase = float.Parse(txtvaloruni.Text);
                cboAProductos.Items.Add(textoabase);

                // Le aplica formato a la columna de valores
                dgvProductos.Columns[2].DefaultCellStyle.Format = "C";


                // Crea una nueva fila en el dgvProductos
                int rowIndex = dgvProductos.Rows.Add();
                DataGridViewRow nuevaFila = dgvProductos.Rows[rowIndex];


                // Asigna el valor de las textbox a las celdas de la nueva fila
                nuevaFila.Cells[0].Value = textoabase;
                nuevaFila.Cells[1].Value = 0;
                nuevaFila.Cells[2].Value = valorbase;

                // Limpia el textBox después de agregar el valor
                txtproducto.Clear();
                txtvaloruni.Clear();

            }
            else
            {
                MessageBox.Show("Porfavor llenar el campo de valor unitario o nombre del producto");
            }
            actualizarvalores();
        }

        

        private void cmdquitar_Click(object sender, EventArgs e)
        {
            //Comprobacion de que la combobox no este vacia
            if (cboAProductos.Text != "")
            {
                //Declarar la string del producto a buscar y la variable que almacena el valor de la fila donde esta
                string buscarproducto;
                int filab;
                buscarproducto = cboAProductos.Text;

                //Ciclo foreach para buscar la fila donde esta el producto
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    //Comprobacion de que la primera celda del fila coincida con el texto de "buscarproducto"
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(buscarproducto))
                    {
                        //Se obtiene el inde del fila y se remueve la fila usando dicho indice
                        filab = row.Index;
                        dgvProductos.Rows.RemoveAt(filab);

                        //Obtener el inde del texto en el cbo para despues limpiarla
                        int cboindex;
                        cboindex = cboAProductos.Text.IndexOf(cboAProductos.Text);
                        cboAProductos.Items.RemoveAt(cboindex);

                    }
                }
            }
            actualizarvalores();
        }

        private void cmdAgventa_Click(object sender, EventArgs e)
        {
            //Comprobacion de que la combobox no este vacia
            if (cboAProductos.Text != "")
            {
                //Declarar la string del producto a buscar
                string buscarproducto;
                buscarproducto = cboAProductos.Text;

                //Ciclo foreach para buscar la fila donde esta el producto
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    //Comprobacion de que la primera celda del fila coincida con el texto de "buscarproducto"
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(buscarproducto))
                    {
                        //Se convierte el texto de la textbox a entero y se le suma el valor a la celda de ventas
                        int venta = int.Parse(txtcantidadven.Text);
                        row.Cells[1].Value = int.Parse(row.Cells[1].Value.ToString()) + venta;


                        //Limpiar la textbox de ventas
                        txtcantidadven.Clear();
                        cboAProductos.Text = "";

                    }
                }
            }

            actualizarvalores();
        }
        public void actualizarvalores()
        {
            //declaracion de la estring que guardara el producto
            string productom = "";

            //Comprobacion de la existencia de mas de 2 columnas
            if (dgvProductos.Rows.Count != 1)
            {
                //Ciclo para recorrer el datagridview fila por fila
                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    //Comprobacion de valores validos tipos float en la ultima celda
                    if (fila.Cells[2].Value != null && float.TryParse(fila.Cells[2].Value.ToString(), out float valor))
                    {
                        ///Evualuar si el valor es menor al valor minimo (por defecto minimo valor tiene el maximo valor que puede tomar un float.
                        //por lo que valor siempre sera menor)
                        if (valor < minimovalor)
                        {
                            //Actualizar el producto con menores ingreso
                            minimovalor = valor;

                            //obtener el texto de la primera celda y actualizar el label del producto con menos ingresos
                            productom = fila.Cells[0].Value.ToString();
                            lblPRmenosvendido.Text = productom;

                        }
                    }


                }

                //Ciclo para recorrer el datagridview fila a fila
                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    //Evualuar si la segunda celda contiene un valor entero valido
                    if (fila.Cells[1].Value != null && int.TryParse(fila.Cells[1].Value.ToString(), out int ventas))
                    {
                        //Evulua si las ventas son mayores al valor maximo de ventas (por defecto mejor vendido tiene el minimo valor de un entero +
                        // por lo que el primer producto ingresado sera automaticamente el mas vendido)
                        if (ventas > mejorvendido)
                        {
                            //Actualizar la variable mejor vendido con las ventas del producto mas vendido
                            mejorvendido = ventas;

                            //Obtener el texto de la primera celda y usarlo para actualizar el label de los mas vendidos
                            productom = fila.Cells[0].Value.ToString();
                            lblPRmasvendido.Text = productom;

                        }
                    }


                }


            }

        }
        private void txtvaloruni_KeyPress(object sender, KeyPressEventArgs e)
        {
          // Comprobacion de si se esta presionando un numero o una , en el txtvaloruni
          if (char.IsLetter(e.KeyChar) || (char.IsPunctuation(e.KeyChar) && e.KeyChar != ',') || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
          {
            e.Handled = true;

          }
        }

        //Evitar que se pueda escribir texto en la combobox de productos
        private void cboAProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtcantidadven_KeyPress(object sender, KeyPressEventArgs a)
        {
            // Comprobacion de si se esta presionando un numero o una , en el txtvaloruni
            if (char.IsLetter(a.KeyChar) || (char.IsPunctuation(a.KeyChar) && a.KeyChar != ',') || char.IsSymbol(a.KeyChar) || char.IsWhiteSpace(a.KeyChar))
            {
                a.Handled = true;

            }
        }
    }
}
