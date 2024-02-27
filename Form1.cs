namespace aplicacionListas
{
    public partial class Form1 : Form
    {
        private List<string> elementos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarListBox()
        {
            listBoxMostrar.Items.Clear();
            foreach (string elemento in elementos)
            {
                listBoxMostrar.Items.Add(elemento);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevoElemento = txtBoxPelicula.Text;
            string nuevoElemento1 = txtBoxGenero.Text;
            string nuevoElemento2 = txtBoxDuracion.Text;
            string nuevoElemento3 = txtBoxClasi.Text; ;
            elementos.Add(nuevoElemento);
            elementos.Add(nuevoElemento1);
            elementos.Add(nuevoElemento2);
            elementos.Add(nuevoElemento3);
            ActualizarListBox();
            txtBoxPelicula.Clear();
            txtBoxGenero.Clear();
            txtBoxDuracion.Clear();
            txtBoxClasi.Clear();
        }
    }
}
