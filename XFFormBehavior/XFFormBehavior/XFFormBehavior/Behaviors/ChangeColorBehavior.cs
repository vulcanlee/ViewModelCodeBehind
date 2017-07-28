using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFFormBehavior.Behaviors
{
    public class ChangeColorBehavior : Behavior<ContentPage>
    {
        #region ChangeColor 附加屬性 Attached Property
        public static readonly BindableProperty ChangeColorProperty =
               BindableProperty.CreateAttached(
                   propertyName: "ChangeColor",   // 屬性名稱 
                   returnType: typeof(bool), // 回傳類型 
                   declaringType: typeof(ChangeColorBehavior), // 宣告類型 
                   defaultValue: false, // 預設值 
                   propertyChanged: OnChangeColorChanged  // 屬性值異動時，要執行的事件委派方法
               );

        public static void SetChangeColor(BindableObject bindable, bool entryType)
        {
            bindable.SetValue(ChangeColorProperty, entryType);
        }
        public static bool GetChangeColor(BindableObject bindable)
        {
            return (bool)bindable.GetValue(ChangeColorProperty);
        }

        private static void OnChangeColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var fooPage = bindable as ContentPage;
            if (fooPage == null)
            {
                return;
            }

            var fooValue = (bool)newValue;
            if (fooValue)
            {
                fooPage.Behaviors.Add(new ChangeColorBehavior());
            }
            else
            {
                var toRemove = fooPage.Behaviors.FirstOrDefault(b => b is ChangeColorBehavior);
                if (toRemove != null)
                {
                    fooPage.Behaviors.Remove(toRemove);
                }
            }
        }
        #endregion

        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            // 當這個行為被加入到 XAML 中，就會變更頁面背景顏色
            App.Current.Resources["DynamicResourceColor"] = Color.FromHex("#768ddb");
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
        }
    }
}
