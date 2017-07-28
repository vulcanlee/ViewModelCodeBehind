using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFAttProp.AttatchedProperties
{
    public class ChangeBackgroundColor
    {
        #region ChangeAppColor 附加屬性 Attached Property
        public static readonly BindableProperty ChangeAppColorProperty =
               BindableProperty.CreateAttached(
                   propertyName: "ChangeAppColor",   // 屬性名稱 
                   returnType: typeof(bool), // 回傳類型 
                   declaringType: typeof(ContentPage), // 宣告類型 
                   defaultValue: false, // 預設值 
                   propertyChanged: OnChangeAppColorChanged  // 屬性值異動時，要執行的事件委派方法
               );

        public static void SetChangeAppColor(BindableObject bindable, bool entryType)
        {
            bindable.SetValue(ChangeAppColorProperty, entryType);
        }
        public static bool GetChangeAppColor(BindableObject bindable)
        {
            return (bool)bindable.GetValue(ChangeAppColorProperty);
        }

        private static void OnChangeAppColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var fooPage = bindable as ContentPage;
            if (fooPage == null)
            {
                return;
            }

            var fooValue = (bool)newValue;
            if (fooValue == true)
            {
                App.Current.Resources["DynamicResourceColor"] = Color.FromHex("#768ddb");
            }
        }
        #endregion

        #region ChangePageColor 附加屬性 Attached Property
        public static readonly BindableProperty ChangePageColorProperty =
               BindableProperty.CreateAttached(
                   propertyName: "ChangePageColor",   // 屬性名稱 
                   returnType: typeof(bool), // 回傳類型 
                   declaringType: typeof(Button), // 宣告類型 
                   defaultValue: false, // 預設值 
                   propertyChanged: OnChangePageColorChanged  // 屬性值異動時，要執行的事件委派方法
               );

        public static void SetChangePageColor(BindableObject bindable, bool entryType)
        {
            bindable.SetValue(ChangePageColorProperty, entryType);
        }
        public static bool GetChangePageColor(BindableObject bindable)
        {
            return (bool)bindable.GetValue(ChangePageColorProperty);
        }

        private static void OnChangePageColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // 取得這個按鈕的控制項
            var fooButton = bindable as Button;
            // 取得這個按鈕所在頁面的物件
            var fooPage = fooButton.Parent.Parent as ContentPage;

            var fooValue = (bool)newValue;

            if (fooValue == true)
            {
                fooPage.Resources["PageDynamicResourceColor"] = Color.FromHex("#e89a4c");
            }
        }
        #endregion

    }
}
