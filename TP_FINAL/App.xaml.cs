using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TP_FINAL.Model;

namespace TP_FINAL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.Mercadoria.MainPage());
        }

        static Mercadoria mercadoriaModel;

        public static Mercadoria MercadoriaModel
        {
            get
            {
                if (mercadoriaModel == null)
                {
                    mercadoriaModel = new Mercadoria();
                }
                return mercadoriaModel;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
