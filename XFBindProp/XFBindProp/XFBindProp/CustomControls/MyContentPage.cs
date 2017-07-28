using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFBindProp.CustomControls
{
    public class MyContentPage : ContentPage
    {
        #region ChangeBackgroudColor 可綁定屬性 BindableProperty
        public static readonly BindableProperty ChangeBackgroudColorProperty =
            BindableProperty.Create("ChangeBackgroudColor", // 屬性名稱 
                typeof(bool), // 回傳類型 
                typeof(MyContentPage), // 宣告類型 
                false, // 預設值 
                propertyChanged: OnChangeBackgroudColorChanged  // 屬性值異動時，要執行的事件委派方法
            );

        public bool ChangeBackgroudColor
        {
            set
            {
                SetValue(ChangeBackgroudColorProperty, value);
            }
            get
            {
                return (bool)GetValue(ChangeBackgroudColorProperty);
            }
        }

        private static void OnChangeBackgroudColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var fooPage = bindable as MyContentPage;

            var fooValue = (bool)newValue;

            if(fooValue == true)
            {
                App.Current.Resources["DynamicResourceColor"] = Color.FromHex("#768ddb");
            }
        }

        #endregion

    }
}
