using EnviarCorreo.Forms.Classes;
using System.Windows.Input;
using Xamarin.Forms;

namespace EnviarCorreo.Forms.ViewModel
{
    public class ViewModelBase : VMBase
    {
        public ICommand IdentificadorCommand { get; set; }

        public ViewModelBase(INavigation navigation)
        {
            IdentificadorCommand = new Command(async() =>
            {
                //Este é o lugar onde você colocar o seu endereço de e-mail
                string direccionCorreo = "vitor.lima@msn.com";
                string evento = "Acompanhando a Maratona da cidade de São José dos Campos/SP";

                ServiceHelper servicioApp = new ServiceHelper();
                await servicioApp.InsertarEntidad(direccionCorreo, evento);
                BtnText = "Teste enviado";
            });

            BtnText = "Enviar teste";

        }

        private string _btnText;

        public string BtnText
        {
            get { return _btnText; }
            set
            {
                _btnText = value;
                OnPropertyChanged();
            }
        }


    }
}
