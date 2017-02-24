using CarsExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CarsExample.Views {

    public partial class CarsPage : ContentPage {

        public CarsPage() {

            InitializeComponent();

            // Connecting context of this page to the our View Model class
            BindingContext = new CarsViewModel();
        }
    }
}
