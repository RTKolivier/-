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

public partial class createOrders : Window 
{
    public Data_Price price = new Data_Price();
    public Client lastclient = DbHelper.context.Clients.OrderBy(x => x.ClientsId).Last();
    public Order lastorder = DbHelper.context.Orders.OrderBy(x=> x.OrdersId).Last();
    public List<Hardware> hardwareforclient = DbHelper.context.Hardwares
        .Include(x => x.HardwareColor)
        .Include(x => x.HardwarePrice)
        .Include(x => x.HardwareType)
        .ToList();
    public List<AddHardware> addhardwareforclient = DbHelper.context.AddHardwares
        .Include(x => x.AddhardwareColor)
        .Include(x => x.AddhardwarePrice)
        .Include(x => x.AddhardwareSize)
        .ToList();
    public List<AcrylicSize> AcrylicSizes = DbHelper.context.AcrylicSizes.ToList();
    public List<TypeOfAcrylic> TypeOfAcrylics = DbHelper.context.TypeOfAcrylics.ToList();

    public int FinalPrice;
    Client Sessionclient = new Client();
    public createOrders(Client client)
    {
        InitializeComponent();
        Sessionclient = client;
        Thickness_Acrylic.ItemsSource = DbHelper.context.TypeOfAcrylics.Select(x => x.TypeofacrylicThickness).ToList();
        Size_Acrylic.ItemsSource = DbHelper.context.AcrylicSizes.Select(x => x.AcrylicsizeSize).ToList();
        Type_Hardware.ItemsSource = DbHelper.context.TypeOfHardwares.Select(x => x.TypeofhardwareType).ToList();
        Color_Hardware.ItemsSource = DbHelper.context.HardwareColors.Select(x => x.HardwarecolorColor).ToList();
        Size_AddHardware.ItemsSource = DbHelper.context.AddHardwareSizes.Select(x => x.AddhardwaresizeSize).ToList();
        Color_AddHardware.ItemsSource = DbHelper.context.HardwareColors.Select(x => x.HardwarecolorColor).ToList();
        
    }
    private void ClientOrdersBack_OnClick(object? sender, RoutedEventArgs e)
    {
        clientAdapterSec clientAdapterSec = new clientAdapterSec(Sessionclient);
        clientAdapterSec.Show();
        Close();
    }
    public void CreateOrder()
    {
        Order newOrders = new Order
        {
            OrdersId = lastorder.OrdersId + 1,
            OrdersFilesname = OrderName.Text,
            OrdersHardwareid = hardwareforclient
                .Where(h => h.HardwareColor.HardwarecolorColor == Color_Hardware.SelectedItem.ToString() 
                            && h.HardwareType.TypeofhardwareType == Type_Hardware.SelectedItem.ToString())
                .Select(x => x.HardwareId).FirstOrDefault(),
            OrdersAddhardware = addhardwareforclient
                .Where(h => h.AddhardwareColor.HardwarecolorColor == Color_AddHardware.SelectedItem.ToString() 
                            && h.AddhardwareSize.AddhardwaresizeSize == Size_AddHardware.SelectedItem.ToString())
                .Select(x => x.AddhardwareId).FirstOrDefault(),
            OrdersQuantity = int.Parse(Quantity_Acrylic.Text),
            OrdersQuantityhardware = int.Parse(Quantity_Hardware.Text),
            OrdersQuantityaddhardware = int.Parse(Quantity_AddHardware.Text),
            OrdersTypeacrylicid = TypeOfAcrylics
                .Where(h => h.TypeofacrylicThickness == Thickness_Acrylic.SelectedItem.ToString())
                .Select(x => x.TypeofacrylicId).FirstOrDefault(),
            AcrylicSize = AcrylicSizes
                .Where(h => h.AcrylicsizeSize == Size_Acrylic.SelectedItem.ToString())
                .Select(x => x.AcrylicsizeId).FirstOrDefault(),
            OrdersDate = DateOnly.FromDateTime(DateTime.Now),
            OrdersPrice = FinalPrice
        };
        DbHelper.context.Orders.Add(newOrders);
        DbHelper.context.SaveChanges();
    }
    private void SaveOrders_onClick(object? sender, RoutedEventArgs e)
    {
        CreateOrder();
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }

    private void CalculatePrice_OnClick(object? sender, RoutedEventArgs e)
    {
        FinalPrice = price.FindPrice(Thickness_Acrylic.SelectedItem.ToString(), Size_Acrylic.SelectedItem.ToString(), int.Parse(Quantity_Acrylic.Text));
        Console.WriteLine(FinalPrice);
        var selectedPriceHardware = hardwareforclient
            .Where(x => x.HardwareType.TypeofhardwareType == Type_Hardware.SelectionBoxItem.ToString())
            .Select(x => x.HardwarePrice.HardwarepricePrice).First();
        var hardwarePrice = int.Parse(Quantity_Hardware.Text) * selectedPriceHardware;
        var selectedAddPriceHArdware =  addhardwareforclient
            .Where(x => x.AddhardwareSize.AddhardwaresizeSize == Size_AddHardware.SelectionBoxItem.ToString())
            .Select(x => x.AddhardwarePrice.HardwarepricePrice).First();
        var addhardwarePrice = int.Parse(Quantity_AddHardware.Text) * selectedAddPriceHArdware;
        FinalPrice = FinalPrice * int.Parse(Quantity_Acrylic.Text)+ hardwarePrice + addhardwarePrice;
        Final_Price.Text = FinalPrice.ToString();
    }
}