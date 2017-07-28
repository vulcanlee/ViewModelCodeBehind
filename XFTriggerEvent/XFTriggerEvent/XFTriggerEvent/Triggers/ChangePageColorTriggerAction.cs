using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFTriggerEvent.Triggers
{
    public class ChangePageColorTriggerAction : TriggerAction<Button>
    {
        protected override void Invoke(Button sender)
        {
            // 取得這個按鈕的控制項
            var fooButton = sender;
            // 取得這個按鈕所在頁面的物件
            var fooPage = fooButton.Parent.Parent as ContentPage;

            fooPage.Resources["PageDynamicResourceColor"] = Color.FromHex("#e89a4c");
        }
    }
}
