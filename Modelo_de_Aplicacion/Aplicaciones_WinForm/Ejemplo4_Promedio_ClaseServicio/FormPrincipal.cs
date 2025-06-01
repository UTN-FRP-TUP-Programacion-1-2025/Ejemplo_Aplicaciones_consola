using Ejemplo2.Models;

namespace Ejemplo4
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double nota = Convert.ToDouble(tbNota.Text);
            servicio.RegistrarNota(nota);

            tbNota.Clear();
        }

        private void btnCalcularMostrarPromedio_Click(object sender, EventArgs e)
        {
            double promedio = servicio.CalcularPromedio();
            lbPromedio.Text = $"{promedio,10:f2}";
        }
    }
}
