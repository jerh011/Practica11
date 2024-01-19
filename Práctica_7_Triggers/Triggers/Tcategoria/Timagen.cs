using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Práctica_7_Triggers.Triggers.Tcategoria
{
    public class Timagen : TriggerAction<Image>
    {
        public bool Activacion { set; get; }
        protected override async void Invoke(Image sender)
        {
            if (Activacion == true)
            {
                sender.BackgroundColor = Color.Red;
                await sender.RelRotateTo(360, 5000, Easing.BounceOut);
            }
            if (Activacion == false) {
                sender.BackgroundColor = new Image().BackgroundColor;
                sender.Rotation = new Image().Rotation;  
            }
        }
    }
}
