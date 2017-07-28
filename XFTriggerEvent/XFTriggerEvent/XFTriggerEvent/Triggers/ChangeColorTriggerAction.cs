using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFTriggerEvent.Triggers
{
    public class ChangeColorTriggerAction : TriggerAction<ContentPage>
    {
        protected override void Invoke(ContentPage sender)
        {
            App.Current.Resources["DynamicResourceColor"] = Color.FromHex("#768ddb");
        }
    }
}
