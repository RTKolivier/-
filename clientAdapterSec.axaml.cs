using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using курчас.Models;

namespace курчас;

public partial class clientAdapterSec : Window
{
    Client Sessionclient = new Client();
    public clientAdapterSec(Client client)
    {
        InitializeComponent();
        Sessionclient = client;
    }
    private void Create_Order_OnClick(object? sender, RoutedEventArgs e)
    {
        createOrders createOrder = new createOrders(Sessionclient);
        createOrder.Show();
        Close();
    }
    private void Check_History_OnClick(object? sender, RoutedEventArgs e)
    {
        clientHistory clientHistory = new clientHistory(Sessionclient);
        clientHistory.Show();
        Close();
    }
    private void ClientAdapterSecBack_OnClick(object? sender, RoutedEventArgs e)
    {
        clientAdapter clientAdapter = new clientAdapter();
        clientAdapter.Show();
        Close();
    }
}