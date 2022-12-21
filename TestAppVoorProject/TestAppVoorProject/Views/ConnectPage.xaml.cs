using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestAppVoorProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnectPage : ContentPage
    {
        public ConnectPage()
        {
            InitializeComponent();
        }
        public static string data = null;
        private void Verbinden_Clicked(object sender, EventArgs e)
        {
            //TODO De verbinding verzorgen met de arduino


            //IPAddress serverAddr = IPAddress.Parse("141.252.226.139"); //ip adress van de arduino
            //IPEndPoint endPoint = new IPEndPoint(serverAddr, 80);

            ////opstarten verbinding
            //Socket sock = new Socket(serverAddr.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
            //sock.Bind(endPoint);
            //sock.Listen(10);
            //Socket handler = sock.Accept();



            ////ontvangen
            //byte[] recieve_byte = new byte[1024];
            //int bytesec = sock.Receive(recieve_byte);

            //data = Encoding.ASCII.GetString(recieve_byte, 0, bytesec);


            ////versturen
            //string testmessage = "Verbinding";
            //byte[] send_buffer = Encoding.ASCII.GetBytes(testmessage);

            //sock.Send(send_buffer);

            ////afsluiten verbinding
            //handler.Shutdown(SocketShutdown.Both);
            //handler.Close();



            //if (send_buffer == recieve_byte)
            //{
            //    status.Text = "Verbonden";
            //    status.TextColor = Color.Green;

            //}

            App.Current.MainPage = new AppShell();

            //TODO Als de verbinding werkt dan doorgaan naar de volgende pagina
            //if (true)
            //{
            //    App.Current.MainPage = new AppShell();
            //}

        }
    }
}