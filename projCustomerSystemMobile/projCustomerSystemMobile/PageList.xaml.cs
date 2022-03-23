using projCustomerSystemMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projCustomerSystemMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageList : ContentPage
    {
        List<CCustomer> list;

        public PageList()
        {
            InitializeComponent();

            list = (Application.Current as App).customers;
            if(list!=null)
            {
                lvCustomer.ItemsSource = list;
            }
        }

        private void lvCustomer_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            (Application.Current as App).selectedIndex = e.SelectedItemIndex;
            Navigation.PopAsync();
        }
    }
}