using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFFormBehavior.Behaviors
{
    public class ChangePageColorBehavior : Behavior<Button>
    {

        #region ChangePageColor 附加屬性 Attached Property
        public static readonly BindableProperty ChangePageColorProperty =
               BindableProperty.CreateAttached(
                   propertyName: "ChangePageColor",   // 屬性名稱 
                   returnType: typeof(bool), // 回傳類型 
                   declaringType: typeof(ChangePageColorBehavior), // 宣告類型 
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

            var fooValue = (bool)newValue;

            if (fooValue)
            {
                fooButton.Behaviors.Add(new ChangePageColorBehavior());
            }
            else
            {
                var toRemove = fooButton.Behaviors.FirstOrDefault(b => b is ChangePageColorBehavior);
                if (toRemove != null)
                {
                    fooButton.Behaviors.Remove(toRemove);
                }
            }
        }
        #endregion


        protected override void OnAttachedTo(Button bindable)
        {
            base.OnAttachedTo(bindable);
            // 當這個行為被加入到 XAML 中，就會變更按鈕背景顏色
            // 取得這個按鈕的控制項
            var fooButton = bindable;
            // 取得這個按鈕所在頁面的物件
            var fooPage = fooButton.Parent.Parent as ContentPage;

            fooPage.Resources["PageDynamicResourceColor"] = Color.FromHex("#e89a4c");
        }

        protected override void OnDetachingFrom(Button bindable)
        {
            base.OnDetachingFrom(bindable);
        }
    }
}
