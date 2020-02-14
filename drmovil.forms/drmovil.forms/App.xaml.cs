
using drmovil.forms.Data.SqliteService;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace drmovil.forms
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            var sqlite = new SqliteService();
            sqlite.CreateTables();

            MainPage = new AppShell();

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
