using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void btnClick(object sender, EventArgs args)
        {
            string strName = textBox.Text;
            labelMsg.Text = strName;
            await DisplayAlert("My Name", strName, "ok");
        }
        void btnAdd(object sender, EventArgs args)
        {
            int v1 = int.Parse(num1.Text);
            int v2 = int.Parse(num2.Text);
            int v3 = v1 + v2;
            num3.Text = v3.ToString();
        }
        void btnSub(object sender, EventArgs args)
        {
            int v1 = int.Parse(num1.Text);
            int v2 = int.Parse(num2.Text);
            int v3 = v1 - v2;
            num3.Text = v3.ToString();
        }
        void btnMul(object sender, EventArgs args)
        {
            int v1 = int.Parse(num1.Text);
            int v2 = int.Parse(num2.Text);
            int v3 = v1 * v2;
            num3.Text = v3.ToString();
        }
        void btnDiv(object sender, EventArgs args)
        {
            int v1 = int.Parse(num1.Text);
            int v2 = int.Parse(num2.Text);
            float v3 = v1 / v2;
            num3.Text = v3.ToString();
        }
    }
}
