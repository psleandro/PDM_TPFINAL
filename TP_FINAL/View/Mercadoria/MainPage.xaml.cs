using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TP_FINAL.ViewModel;
using TP_FINAL.Model;


namespace TP_FINAL.View.Mercadoria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        MercadoriaViewModel vmMercadoria;
        public MainPage()
        {
            vmMercadoria = new MercadoriaViewModel();
            BindingContext = vmMercadoria;
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            vmMercadoria = new MercadoriaViewModel();
            BindingContext = vmMercadoria;
            base.OnAppearing();
        }
        private void OnNovo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovaMercadoriaView());
        }

        private void OnMercadoriaTapped(object sender, ItemTappedEventArgs args)
        {
            var selecionado = args.Item as TP_FINAL.Model.Mercadoria;
            DisplayAlert("Mercadoria selecionada", "Nome: " + selecionado.Nome + "\nPeso: " + selecionado.Peso + "\nProdutor: " + selecionado.NomeProd + "\nEmail: " + selecionado.Email + "\nNCM: " + selecionado.NCM, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs args)
        {
            try
            {
                Button buttondel = (Button)sender;
                int comdPar = (int)buttondel.CommandParameter;
                Model.Mercadoria merc = new TP_FINAL.Model.Mercadoria();
                merc.RemoverMercadoria(comdPar);
                Navigation.PushAsync(new MainPage());
                Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error occurred", ex.Message.ToString(), "Ok");
            }
        }
        private void Update_Clicked(object sender, EventArgs args)
        {
            Button buttondel = (Button)sender;
            int comdPar = (int)buttondel.CommandParameter;
            Navigation.PushAsync(new NovaMercadoriaView(comdPar));
        }
    }
}