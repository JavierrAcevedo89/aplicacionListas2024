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
            string nuevoElemento = txtBoxIngresar.Text;
            elementos.Add(nuevoElemento);
            ActualizarListBox();
            txtBoxIngresar.Clear();
        }
    }
}
