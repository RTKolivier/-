using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Microsoft.EntityFrameworkCore;
using курчас.Models;
using курчас.Data;

namespace курчас;

public partial class createNonameOrders : Window
{
    public Data_Price price = new Data_Price();
    public NonameClient lastclient = DbHelper.context.NonameClients.OrderBy(x => x.NonameclientsId).Last();
    public List<Hardware> hardwarefornoname = DbHelper.context.Hardwares
        .Include(x => x.HardwareColor)
        .Include(x => x.HardwarePrice)
        .Include(x => x.HardwareType)
        .ToList();
    public List<AddHardware> addhardwarefornoname = DbHelper.context.AddHardwares
        .Include(x => x.AddhardwareColor)
        .Include(x => x.AddhardwarePrice)
        .Include(x => x.AddhardwareSize)
        .ToList();
    public List<AcrylicSize> AcrylicSizes = DbHelper.context.AcrylicSizes.ToList();
    public List<TypeOfAcrylic> TypeOfAcrylics = DbHelper.context.TypeOfAcrylics.ToList();

    public int FinalPrice;
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
        FinalPrice = price.FindPrice(Thickness_Acrylic.SelectedItem.ToString(), Size_Acrylic.SelectedItem.ToString(), int.Parse(Quantity_Acrylic.Text));
        Console.WriteLine(FinalPrice);
        var selectedPriceHardware = hardwarefornoname
            .Where(x => x.HardwareType.TypeofhardwareType == Type_Hardware.SelectionBoxItem.ToString())
            .Select(x => x.HardwarePrice.HardwarepricePrice).First();
        var hardwarePrice = int.Parse(Quantity_Hardware.Text) * selectedPriceHardware;
        var selectedAddPriceHArdware =  addhardwarefornoname
            .Where(x => x.AddhardwareSize.AddhardwaresizeSize == Size_AddHardware.SelectionBoxItem.ToString())
            .Select(x => x.AddhardwarePrice.HardwarepricePrice).First();
        var addhardwarePrice = int.Parse(Quantity_AddHardware.Text) * selectedAddPriceHArdware;
        FinalPrice = FinalPrice * int.Parse(Quantity_Acrylic.Text)+ hardwarePrice + addhardwarePrice;
        Final_Price.Text = FinalPrice.ToString();
        
        
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
         OrdersAddhardware = addhardwarefornoname
             .Where(h => h.AddhardwareColor.HardwarecolorColor == Color_AddHardware.SelectedItem 
                         && h.AddhardwareSize.AddhardwaresizeSize == Size_AddHardware.SelectedItem)
             .Select(x => x.AddhardwareId).First(),
         OrdersQuantity = int.Parse(Quantity_Acrylic.Text),
         OrdersQuantityhardware = int.Parse(Quantity_Hardware.Text),
         OrdersQuantityaddhardware = int.Parse(Quantity_AddHardware.Text),
         OrdersTypeacrylicid = TypeOfAcrylics
             .Where(h => h.TypeofacrylicThickness == Thickness_Acrylic.SelectedItem)
             .Select(x => x.TypeofacrylicId).First(),
         AcrylicSize = AcrylicSizes
             .Where(h => h.AcrylicsizeSize == Size_Acrylic.SelectedItem)
             .Select(x => x.AcrylicsizeId).First(),
        };
    }
}