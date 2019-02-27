using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void SimpleInterst(object sender, EventArgs args)
        {
            int age = int.Parse(textBox1.Text);
            double si = 30000 * 3;
            if (age >= 60)
                si = (si * 12) / 100;
            else
                si = (si * 15) / 100;

            lblName.Text = "Simple Interest is  " + si.ToString();
        }
    }
}
   
