using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace курчас;

public partial class clientHistory : Window
{
    public clientHistory()
    {
        InitializeComponent();
    }
    private void ClientHistoryBack_OnClick(object? sender, RoutedEventArgs e)
    {
        clientAdapterSec clientAdapterSec = new clientAdapterSec();
        clientAdapterSec.Show();
        Close();
    }
}