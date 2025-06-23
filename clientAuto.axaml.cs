using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using курчас.Models;

namespace курчас;

public partial class clientAuto : Window
{
    public List<Client> clients = DbHelper.context.Clients
        .ToList();
    public clientAuto()
    {
        InitializeComponent();
    }
    private void Client_Permit_OnClick(object? sender, RoutedEventArgs e)
    {
        var nameClient = clients.FirstOrDefault(x => x.ClientsNick == LoginClient.Text);
        var passwordClient = clients.FirstOrDefault(x => x.ClientsPassword == PasswordClient.Text);
        if (nameClient != null && passwordClient != null)
        {
            clientAdapterSec clientAdapterSec = new clientAdapterSec(nameClient);
            clientAdapterSec.Show();
            Close();
        }
        else {
            Error.Text = "Неправильный логин или пароль";
                }
    }
    private void ClientAutoBack_OnClick(object? sender, RoutedEventArgs e)
    {
        clientAdapter clientAdapter = new clientAdapter();
        clientAdapter.Show();
        Close();
    }
    
}