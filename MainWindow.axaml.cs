using Avalonia.Controls;
using Avalonia.Interactivity;

namespace курчас;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void CreateOrder_OnClick(object? sender, RoutedEventArgs e)
    {
        createOrders createOrder = new createOrders();
        createOrder.Show();
        Close();
    }
    private void CreateAccount_OnClick(object? sender, RoutedEventArgs e)
    {
        adapter adapterWindow = new adapter();
        adapterWindow.Show();
        Close();
    }
}