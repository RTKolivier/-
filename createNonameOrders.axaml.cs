using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Microsoft.EntityFrameworkCore;
using курчас.Models;

namespace курчас;

public partial class createNonameOrders : Window
{
    public NonameClient lastclient = DbHelper.context.NonameClients.OrderBy(x => x.NonameclientsId).Last();
    public List<Hardware> hardwarefornoname = DbHelper.context.Hardwares.Include(x => x.HardwareColor)
        .Include(x => x.HardwarePrice)
        .Include(x => x.HardwareType)
        .ToList();
    public createNonameOrders()
    {
        InitializeComponent();
        Thickness_Acrylic.ItemsSource = DbHelper.context.TypeOfAcrylics.Select(x => x.TypeofacrylicThickness).ToList();
        Size_Acrylic.ItemsSource = DbHelper.context.AcrylicSizes.Select(x => x.AcrylicsizeSize).ToList();
        Type_Hardware.ItemsSource = DbHelper.context.TypeOfHardwares.Select(x => x.TypeofhardwareType).ToList();
        Color_Hardware.ItemsSource = DbHelper.context.HardwareColors.Select(x => x.HardwarecolorColor).ToList();
        Size_AddHardware.ItemsSource = DbHelper.context.AddHardwareSizes.Select(x => x.AddhardwaresizeSize).ToList();
        Color_AddHardware.ItemsSource = DbHelper.context.HardwareColors.Select(x => x.HardwarecolorColor).ToList();
    }
    private void CreateNonameOrdersBack_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }

    private void CalculatePrice_OnClick(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    public void CreateNonameOrder()
    {
        NonameClient newNonameClient = new NonameClient
        {
            NonameclientsId = lastclient.NonameclientsId + 1,
            NonameclientsNick = NameNoname.Text,
            NonameclientsUsername = UserNoname.Text
        };
        DbHelper.context.NonameClients.Add(newNonameClient);
        DbHelper.context.SaveChanges();
        
        Order newNonameOrdrs = new Order
        {
         OrdersFilesname = OrderName.Text,
         OrdersHardwareid = hardwarefornoname
             .Where(h => h.HardwareColor.HardwarecolorColor == Color_Hardware.SelectedItem 
                         && h.HardwareType.TypeofhardwareType == Type_Hardware.SelectedItem)
             .Select(x => x.HardwareId).First(),
         
         
        };
    }
}