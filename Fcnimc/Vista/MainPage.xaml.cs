using Fcnimc.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Fcnimc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new VMcriticar(Navigation);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
