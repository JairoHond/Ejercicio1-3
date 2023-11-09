using Ejercicio1_3.Views;

namespace Ejercicio1_3
{
    public partial class App : Application
    {
        static Controladores.Personas databasePersona;

        public static Controladores.Personas DatabasePerson
        {
            get
            {
                if (databasePersona == null)
                {
                    databasePersona =
                        new Controladores.Personas(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Person.db3"));
                }
                return databasePersona;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}