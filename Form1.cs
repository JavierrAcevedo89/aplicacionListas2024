namespace aplicacionListas
{
    public partial class Form1 : Form
    {
        private List<string> elementosPeliculas = new List<string>();
        private List<string> elementosUsuarios = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarListBox()
        {
            listBoxPeliculas.Items.Clear();
            foreach (string elemento in elementosPeliculas)
            {
                listBoxPeliculas.Items.Add(elemento);
            }
        }

        private void ActualizarListBoxUsuarios()
        {
            listBoxUsuarios.Items.Clear();
            foreach (string elemento in elementosUsuarios)
            {
                listBoxUsuarios.Items.Add(elemento);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevoElemento = txtBoxPelicula.Text;
            string nuevoElemento1 = txtBoxGenero.Text;
            string nuevoElemento2 = txtBoxDuracion.Text;
            string nuevoElemento3 = txtBoxClasi.Text; ;
            elementosPeliculas.Add(nuevoElemento);
            elementosPeliculas.Add(nuevoElemento1);
            elementosPeliculas.Add(nuevoElemento2);
            elementosPeliculas.Add(nuevoElemento3);
            ActualizarListBox();
            txtBoxPelicula.Clear();
            txtBoxGenero.Clear();
            txtBoxDuracion.Clear();
            txtBoxClasi.Clear();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            string nuevoElemento = txtBoxNombre.Text;
            elementosUsuarios.Add(nuevoElemento);
            ActualizarListBoxUsuarios();
            txtBoxNombre.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem != null && listBoxPeliculas.SelectedItem != null)
            {
                string usuarioSeleccionado = listBoxUsuarios.SelectedItem.ToString();
                string peliculaSeleccionada = listBoxPeliculas.SelectedItem.ToString();

                listBoxRentas.Items.Add($"{usuarioSeleccionado} - {peliculaSeleccionada}");
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario y una película antes de registrar la renta.");
            }
        }
    }
}
