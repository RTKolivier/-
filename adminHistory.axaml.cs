using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace курчас;

public partial class adminHistory : Window
{
    public adminHistory()
    {
        InitializeComponent();
    }
    private void AdminHistoryBack_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
}