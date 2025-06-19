using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using курчас.Models;

namespace курчас;

public partial class adminHistory : Window
{
    public List<Order> Orders = DbHelper.context.Orders
        .Include(x => x.OrdersAddhardwareNavigation)
        .Include(x => x.OrdersHardware)
        .Include(x=> x.OrdersHardware.HardwareColor)
        .Include(x => x.OrdersHardware.HardwareType)
        .Include(x => x.OrdersAddhardwareNavigation.AddhardwareSize)
        .Include(x => x.OrdersAddhardwareNavigation.AddhardwareColor)
        .Include(x => x.OrdersTypeacrylic)
        .Include(x => x.AcrylicSizeNavigation)
        .ToList();
    public adminHistory()
    {
        InitializeComponent();
        AdminHistory_List.ItemsSource = Orders;
    }
    private void AdminHistoryBack_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
}