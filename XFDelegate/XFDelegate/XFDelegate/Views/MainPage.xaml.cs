using Xamarin.Forms;
using XFDelegate.ViewModels;

namespace XFDelegate.Views
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel fooViewModel;
        public MainPage()
        {
            InitializeComponent();

            // 取得這個頁面當時綁定的 ViewMode
            fooViewModel = this.BindingContext as MainPageViewModel;
            // 將 ViewModel 的委派方法與頁面 Code Behind 的方法連結起來
            fooViewModel.ChangeColorDelegate = ChangePageColor;
            fooViewModel.ChangePageColorDelegate = ChangeButtonColor;
        }

        private void ChangePageColor()
        {
            App.Current.Resources["DynamicResourceColor"] = Color.FromHex("#768ddb");
        }

        private void ChangeButtonColor()
        {
            this.Resources["PageDynamicResourceColor"] = Color.FromHex("#e89a4c");
        }
    }
}
