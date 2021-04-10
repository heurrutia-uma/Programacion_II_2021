using System.Windows.Forms;

namespace BaseDatos.Clases
{
    public class AdminFormulario
    {
        public static void MostrarFormulario(Form formulario)
        {
            Form formLocal = FormularioAbierto(formulario);

            if (formLocal == null)
            {
                formulario.MdiParent = FrmPrincipal.ActiveForm;
                formulario.Show();
            }
            else
            {
                formLocal.Activate();
            }
        }

        private static Form FormularioAbierto(Form formulario)
        {
            foreach (Form formularioAbierto in Application.OpenForms)
            {
                if (formularioAbierto.Name == formulario.Name)
                {
                    return formularioAbierto;
                }
            }

            return null;
        }
    }
}
