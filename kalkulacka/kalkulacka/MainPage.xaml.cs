using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace kalkulacka
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string text = btn.Text;
            if (btn.Text == "C")
                input.Text = "0";
            else if (btn.Text == "=")
                input.Text = new DataTable().Compute(input.Text, null).ToString();
            else 
            {
                if (input.Text == "0")
                    input.Text = text;
                else
                    input.Text += text;
            }


        }
    }
}
