using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SneakersMarketPlace.View;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}