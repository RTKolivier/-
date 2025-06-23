using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using курчас.Models;

namespace курчас;

public partial class nonameHistory : Window
{
    // public List<Cao> NonameOrders = DbHelper.context.Caos
    //     .Include(x => x.)
    public nonameHistory()
    {
        InitializeComponent();
    }
    private void NonameHistoryBack_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
}