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
    public partial class PageSearch : ContentPage
    {
        public PageSearch()
        {
            InitializeComponent();
        }

        private void btn_Search_Clicked(object sender, EventArgs e)
        {
            string s = Entry_UserInput.Text.ToUpper();
            var a = Application.Current as App;
            bool isFind = false;
            int cnt = 0;
            foreach(var item in a.customers)
            {
                if(item.fName.ToUpper().Contains(s) || item.fPhone.Contains(s) || item.fEmail.ToUpper().Contains(s) || item.fAddress.ToUpper().Contains(s) || item.fld.ToString().Contains(s))
                {
                    a.selectedIndex = cnt;
                    isFind = true;
                    break;
                }
                cnt++;
            }

            if(isFind)
            {
                Navigation.PopAsync();
            }
        }
    }
}