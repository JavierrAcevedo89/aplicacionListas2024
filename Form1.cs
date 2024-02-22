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

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            string nuevoElemento = elementoTextBox.Text;
            elementos.Add(nuevoElemento);
            ActualizarListBox();
            elementoTextBox.Clear();
        }

        private void ActualizarListBox()
        {
            elementosListBox.Items.Clear();
            foreach (string elemento in elementos)
            {
                elementosListBox.Items.Add(elemento);
            }
        }
    }
}
