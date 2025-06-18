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
    private void Client_OnClick(object? sender, RoutedEventArgs e)
    {
        clientAdapter clientAdapter = new clientAdapter();
        clientAdapter.Show();
        Close();
    }
    private void Authorization_Admin_OnClick(object? sender, RoutedEventArgs e)
    {
        adminReg authorization_Admin = new adminReg();
        authorization_Admin.Show();
        Close();
    }
    private void AdapterBack_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
}