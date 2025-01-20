using Microsoft.Maui.Controls;

namespace PracticaWoW_MP;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }

    public static Task DataBaseService_MP { get; internal set; }
}