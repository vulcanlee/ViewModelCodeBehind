using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFBindProp.CustomControls
{
    public class MyButton : Button
    {
        #region ChangeBackgroudColor 可綁定屬性 BindableProperty
        public static readonly BindableProperty ChangeBackgroudColorProperty =
            BindableProperty.Create("ChangeBackgroudColor", // 屬性名稱 
                typeof(bool), // 回傳類型 
                typeof(MyButton), // 宣告類型 
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
            // 取得這個按鈕的控制項
            var fooButton = bindable as MyButton;
            // 取得這個按鈕所在頁面的物件
            var fooPage = fooButton.Parent.Parent as MyContentPage;

            var fooValue = (bool)newValue;

            if (fooValue == true)
            {
                fooPage.Resources["PageDynamicResourceColor"] = Color.FromHex("#e89a4c");
            }
        }

        #endregion

    }
}
