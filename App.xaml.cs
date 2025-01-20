using PracticaWoW_MP.Services;

namespace PracticaWoW_MP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        public static DatabaseService_MP DataBaseService_MP { get; private set; }

    }
}
