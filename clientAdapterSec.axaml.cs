using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace курчас;

public partial class clientAdapterSec : Window
{
    public clientAdapterSec()
    {
        InitializeComponent();
    }
    private void Create_Order_OnClick(object? sender, RoutedEventArgs e)
    {
        createOrders createOrder = new createOrders();
        createOrder.Show();
        Close();
    }
    private void Check_History_OnClick(object? sender, RoutedEventArgs e)
    {
        clientHistory clientHistory = new clientHistory();
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