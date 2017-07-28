using System;
using Xamarin.Forms;

namespace XFCodeBehind.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Clicked(object sender, System.EventArgs e)
        {
            ChangePageColor();
        }

        private void ChangePageColor()
        {
            // 按下按鈕，將會即時變更背影顏色 (App.Current.Resources 是 VisualElement 內的一個屬性，因此，只能使用 Code Behind 才能夠存取這個屬性 )
            // 為什麼呢？ 因為 ViewModel 並不知道真正要使用的 View 是哪個，所以，也無從存取任何 View 中的控制項
            App.Current.Resources["DynamicResourceColor"] = Color.FromHex("#768ddb");
        }

        private void btnPageChangeColor_Clicked(object sender, System.EventArgs e)
        {
            ChangeButtonColor();
        }

        private void ChangeButtonColor()
        {
            this.Resources["PageDynamicResourceColor"] = Color.FromHex("#e89a4c");
        }
    }
}
