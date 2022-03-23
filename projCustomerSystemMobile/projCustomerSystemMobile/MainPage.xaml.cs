using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using projCustomerSystemMobile.ViewModels;
using projCustomerSystemMobile.Models;

namespace projCustomerSystemMobile
{
    public partial class MainPage : ContentPage     //, INotify
    {
        //CCustormerViewModel viewModel = new CCustormerViewModel();
        CBindingViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();

            viewModel = this.BindingContext as CBindingViewModel;
        }

        private void btn_toFirst_Clicked(object sender, EventArgs e)
        {
            viewModel.moveFirst();
        }

        private void btn_previous_Clicked(object sender, EventArgs e)
        {
            viewModel.movePrevious();
        }

        private void btn_next_Clicked(object sender, EventArgs e)
        {
            viewModel.moveNext();
        }

        private void btn_toLast_Clicked(object sender, EventArgs e)
        {
            viewModel.moveLast();
        }

        private void btn_query_Clicked(object sender, EventArgs e)
        {
            (Application.Current as App).customers = viewModel.all;
            Navigation.PushAsync(new PageSearch());
        }

        private void btn_menu_Clicked(object sender, EventArgs e)
        {
            (Application.Current as App).customers = viewModel.all;
            Navigation.PushAsync(new PageList());
        }

        //void LoadtoEntry()
        //{
        //    CCustomer customer = viewModel.current;
        //    Entry_id.Text = "" + customer.fld;
        //    Entry_name.Text = customer.fName;
        //    Entry_phone.Text = customer.fPhone;
        //    Entry_email.Text = customer.fEmail;
        //    Entry_address.Text = customer.fAddress;
        //}

        protected override void OnAppearing()
        {
            int i = (Application.Current as App).selectedIndex;
            if (i >= 0)
            {
                viewModel.moveTo(i);
            }
        }
    }
}
