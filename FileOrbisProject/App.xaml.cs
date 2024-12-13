using FileOrbisProject.Services;

namespace FileOrbisProject
{
    public partial class App : Application
    {
        public static ClientService _clientService;

        public static ClientService ClientService
        {
            get
            {
                if (_clientService == null)
                {
                    _clientService = new ClientService(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProductDB.db3"));
                }
                return _clientService;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
