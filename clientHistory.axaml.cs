using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using курчас.Models;

namespace курчас;

public partial class clientHistory : Window
{
    Client Sessionclient = new Client();
    public clientHistory(Client client)
    {
        InitializeComponent();
        Sessionclient = client;
    }
    private void ClientHistoryBack_OnClick(object? sender, RoutedEventArgs e)
    {
        clientAdapterSec clientAdapterSec = new clientAdapterSec(Sessionclient);
        clientAdapterSec.Show();
        Close();
    }
}