using System;
using System.Collections.Generic;
using System.Text;
using projCustomerSystemMobile.Models;

namespace projCustomerSystemMobile.ViewModels
{
    delegate void DDataChanges();

    class CCustormerViewModel
    {
        List<CCustomer> list = new List<CCustomer>();
        public int position = 0;

        //public INotify notifier { get; set; }

        //public DDataChanges showCustomerInfo { get; set; }
        public event DDataChanges showCustomerInfo;

        public CCustormerViewModel()
        {
            loadData();
        }

        private void loadData()
        {
            list.Add(new CCustomer() { fld = 1, fName = "Marco", fPhone = "0921445663", fEmail = "marco@gmail.com", fAddress = "台北" });
            list.Add(new CCustomer() { fld = 2, fName = "Selina", fPhone = "0965441256", fEmail = "selina@gmail.com", fAddress = "台中" });
            list.Add(new CCustomer() { fld = 8, fName = "Lydia", fPhone = "0933665223", fEmail = "lydia@gmail.com", fAddress = "台南" });
        }

        public void moveFirst()
        {
            position = 0;

            //if (this.notifier != null)
            //{
            //    this.notifier.afterDataMoved();
            //}
            if(this.showCustomerInfo!=null)
            {
                showCustomerInfo();
            }
        }
        public void movePrevious()
        {
            position --;
            if(position<0)
            {
                moveFirst();
            }
            else
            {
                //if (this.notifier != null)
                //{
                //    this.notifier.afterDataMoved();
                //}
                if (this.showCustomerInfo != null)
                {
                    showCustomerInfo();
                }
            }

        }
        public void moveLast()
        {
            position = list.Count-1;

            //if (this.notifier != null)
            //{
            //    this.notifier.afterDataMoved();
            //}
            if (this.showCustomerInfo != null)
            {
                showCustomerInfo();
            }
        }
        public void moveNext()
        {
            position++;
            if (position > list.Count - 1)
            {
                moveLast();
            }
            else
            {
                //if (this.notifier != null)
                //{
                //    this.notifier.afterDataMoved();
                //}
                if (this.showCustomerInfo != null)
                {
                    showCustomerInfo();
                }
            }

        }
        public void moveTo(int targetPosition)
        {
            if(targetPosition>=0 && targetPosition<=list.Count)
            {
                position = targetPosition;

                //if (this.notifier != null)
                //{
                //    this.notifier.afterDataMoved();
                //}
                if (this.showCustomerInfo != null)
                {
                    showCustomerInfo();
                }
            }
        }

        public CCustomer current
        {
            get { return list[position]; }
            set { list[position] = value; }
        }

        public List<CCustomer> all
        {
            get { return list; }
        }
    }
}
