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

        private void txtvaloruni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Comprobacion de si se esta presionando un numero o una , en el txtvaloruni
            if (char.IsLetter(e.KeyChar) || (char.IsPunctuation(e.KeyChar) && e.KeyChar != ',') || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void cmdquitar_Click(object sender, EventArgs e)
        {

        }

        private void cmdAgventa_Click(object sender, EventArgs e)
        {

        }
        public void actualizarvalores()
        {
            string productom = "";


            if (dgvProductos.Rows.Count != 1)
            {
                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    if (fila.Cells[2].Value != null && float.TryParse(fila.Cells[2].Value.ToString(), out float valor))
                    {
                        if (valor < minimovalor)
                        {
                            minimovalor = valor;
                            productom = fila.Cells[0].Value.ToString();
                            lblPRmenosvendido.Text = productom;

                        }
                    }


                }
                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    if (fila.Cells[1].Value != null && int.TryParse(fila.Cells[1].Value.ToString(), out int valor))
                    {
                        if (valor < mejorvendido)
                        {
                            minimovalor = valor;
                            productom = fila.Cells[0].Value.ToString();
                            lblPRmenosvendido.Text = productom;

                        }
                    }


                }


            }

        }

        private void cboAProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
