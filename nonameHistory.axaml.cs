using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Microsoft.EntityFrameworkCore;
using курчас.Models;

namespace курчас;

public partial class nonameHistory : Window
{
    public List<Caononame> Caononames = DbHelper.context.Caononames
        .Include(x => x.CaononameNoname)
        .Include(X => X.CaononameOrder)
        .ToList();
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