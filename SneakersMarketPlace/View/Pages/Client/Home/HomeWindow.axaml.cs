using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SneakersMarketPlace.View.Pages.Client.Home;

public partial class HomeWindow : Window
{
    public HomeWindow()
    {
        this.InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}