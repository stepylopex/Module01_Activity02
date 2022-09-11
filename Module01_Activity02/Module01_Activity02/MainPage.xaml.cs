using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Module01_Activity02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();



            CreateCommand = new Command<Type>((Type viewType) =>

            {
                View view = (View)Activator.CreateInstance(viewType);
                view.VerticalOptions = LayoutOptions.CenterAndExpand;
                stackLayout.Children.Add(view);
            });
            BindingContext = this;
        }

        public ICommand CreateCommand { private set; get; }


  

    }
}