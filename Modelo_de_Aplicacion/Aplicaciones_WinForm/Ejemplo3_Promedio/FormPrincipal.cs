namespace Ejemplo3
{
    public partial class FormPrincipal : Form
    {
        #region variables y  métodos del dominio del problema
        double acum;
        int contador;

        double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
                promedio = acum / contador;
            return promedio;
        }

        void RegistrarNota(double nota)
        {
            acum += nota;
            contador++;
        }
        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double nota = Convert.ToDouble(tbNota.Text);
            RegistrarNota(nota);

            tbNota.Clear();
        }

        private void btnCalcularMostrarPromedio_Click(object sender, EventArgs e)
        {
            double promedio = CalcularPromedio();
            lbPromedio.Text = $"{promedio,10:f2}";
        }
    }
}
