using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Linq;
using курчас.Models;

namespace курчас;

public partial class clientReg : Window
{
    public Client lastclient = DbHelper.context.Clients.OrderBy(x => x.ClientsId).Last();
    public clientReg()
    {
        InitializeComponent();
    }
    private void Client_Permit_OnClick(object? sender, RoutedEventArgs e)
    {
        AddClient();
        clientAdapterSec clientAdapterSec = new clientAdapterSec();
        clientAdapterSec.Show();
        Close();
    }
    private void ClientRegBack_OnClick(object? sender, RoutedEventArgs e)
    {
        clientAdapter clientAdapter = new clientAdapter();
        clientAdapter.Show();
        Close();
    }
    public void AddClient()
    {
        Client newClients = new Client
        {
            ClientsId = lastclient.ClientsId + 1,
            ClientsNick = NameClient.Text,
            ClientsUsername = UserClient.Text,
            ClientsFio = FIOClient.Text,
            ClientsPhone = PhoneClient.Text,
            ClientsCity = CityClient.Text,
            ClientsOpp = OPPClient.Text,
            ClientsAddress = AddressClient.Text,
            ClientsPassword = PasswordClient.Text
        };
        DbHelper.context.Clients.Add(newClients);
        DbHelper.context.SaveChanges();

    }
}