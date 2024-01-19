using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7_Triggers.VistaModelo
{
    public class Mcategorias: BaseViewModel
    {
        public string descripcion { get; set; }
        public int  numeroItem { get; set;}
        public string imagen { get; set; }

        public string _backgroundColor;
        public string _textColor;
        public bool _selected;

        public string BackgroundColor
        {
            get { return _backgroundColor; }
            set { SetProperty(ref _backgroundColor , value); }
        }

        public string TextColor
        {
            get { return _textColor; }
            set { SetProperty(ref _textColor, value); }
        }

        public bool Selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }
    }
}
