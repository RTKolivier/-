using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.ComponentModel.Design;

namespace курчас;

public partial class adminReg : Window
{
    public adminReg()
    {
        InitializeComponent();
    }
    private void Admin_Permit_OnClick(object? sender, RoutedEventArgs e)
    {
        const string adminLogin = "Артур";
        const string adminPassword = "ArtMastex";
        if (adminLogin == LoginAdmin.Text &&
            adminPassword == PasswordAdmin.Text)
        {
            adminHistory adminHistory = new adminHistory();
            adminHistory.Show();
            Close();
        }
        else
        {
            Error.Text = "ошибка ввода";
        }
    }
    
}