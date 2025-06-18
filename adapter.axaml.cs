using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace курчас;

public partial class adapter : Window
{
    public adapter()
    {
        InitializeComponent();
    }
    private void Authorization_Client_OnClick(object? sender, RoutedEventArgs e)
    {
        clientReg authorization_client = new clientReg();
        authorization_client.Show();
        Close();
    }
    private void Authorization_Admin_OnClick(object? sender, RoutedEventArgs e)
    {
        adminReg authorization_Admin = new adminReg();
        authorization_Admin.Show();
        Close();
    }
}