using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace курчас;

public partial class clientAdapter : Window
{
    public clientAdapter()
    {
        InitializeComponent();
    }
    private void Authorization_Client_OnClick(object? sender, RoutedEventArgs e)
    {
        clientAuto clientAuto = new clientAuto();
        clientAuto.Show();
        Close();
    }
    private void Regisration_Client_OnClick(object? sender, RoutedEventArgs e)
    {
        clientReg clientReg = new clientReg();
        clientReg.Show();
        Close();
    }
    private void ClientAdapterBack_OnClick(object? sender, RoutedEventArgs e)
    {
        adapter adapter = new adapter();
        adapter.Show();
        Close();
    }
}