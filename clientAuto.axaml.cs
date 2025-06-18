using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace курчас;

public partial class clientAuto : Window
{
    public clientAuto()
    {
        InitializeComponent();
    }
    private void Client_Permit_OnClick(object? sender, RoutedEventArgs e)
    {
        clientAdapterSec clientAdapterSec = new clientAdapterSec();
        clientAdapterSec.Show();
        Close();
    }
    private void ClientAutoBack_OnClick(object? sender, RoutedEventArgs e)
    {
        clientAdapter clientAdapter = new clientAdapter();
        clientAdapter.Show();
        Close();
    }
}