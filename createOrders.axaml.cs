using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace курчас;

public partial class createOrders : Window
{
    public createOrders()
    {
        InitializeComponent();
    }
    private void ClientOrdersBack_OnClick(object? sender, RoutedEventArgs e)
    {
        clientAdapterSec clientAdapterSec = new clientAdapterSec();
        clientAdapterSec.Show();
        Close();
    }
}