using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using курчас.Models;

namespace курчас;

public partial class createOrders : Window 
{
    Client Sessionclient = new Client();
    public createOrders(Client client)
    {
        InitializeComponent();
        Sessionclient = client;
    }
    private void ClientOrdersBack_OnClick(object? sender, RoutedEventArgs e)
    {
        clientAdapterSec clientAdapterSec = new clientAdapterSec(Sessionclient);
        clientAdapterSec.Show();
        Close();
    }
}