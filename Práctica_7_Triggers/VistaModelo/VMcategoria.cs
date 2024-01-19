using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Práctica_7_Triggers.VistaModelo
{
    public class VMcategoria : BaseViewModel
    {
        #region Variables
        string _Texto;
        string _imagen;
        bool _activadorAnimacionImg;
        ObservableCollection<Mcategorias> _listaCategorias;

        #endregion

        #region CONTRUCTOR 
        public VMcategoria(INavigation navigation)
        {
            navigation = navigation;
            Mostrarcategorias();
        }

        #endregion

        #region OBJETOS

        public string Imagen
        {
            get { return _imagen; }
            set { SetValue(ref _imagen, value); }

        }

        public bool ActivadorAnimacionImg
        {
            get { return _activadorAnimacionImg; }
            set { SetValue(ref _activadorAnimacionImg, value); }

        }
        public ObservableCollection<Mcategorias> ListaCategorias {
            get { return _listaCategorias; }
            set { SetValue(ref _listaCategorias, value); }

        }
        #endregion Procesos
        public async Task ProcesoAsyncrono()
        {

        }
        public void Mostrarcategorias()
        {
            //Al hacer esti estamos jalando toda la data
            ListaCategorias= new ObservableCollection<Mcategorias>(Datos.Dcategorias.Mostrarcategorias());
        }

      
        public void Seleccionar(Mcategorias modelo) 
        {

            var index = ListaCategorias.ToList()
                .FindIndex(p => p.descripcion == modelo.descripcion);
            
            Imagen = modelo.imagen;
            if (index > -1)
            {
                Deseleccionar();
                ActivadorAnimacionImg= true;
                ListaCategorias[index].Selected=true;
                ListaCategorias[index].TextColor = "FFFFFF";
                ListaCategorias[index].BackgroundColor = "#FF506B";

            }
        }

        public void Deseleccionar()
        {

            ListaCategorias.ForEach((item) =>
            {
                ActivadorAnimacionImg = false;
                item.Selected = false;
                item.TextColor = "#000000";
                item.BackgroundColor = "#EAEDF6";
            });

           
        }



        public void MostrarCategorias() {
            ListaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.Mostrarcategorias());
        }

        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () =>await  ProcesoAsyncrono());
        public ICommand ProcesoSimpSeleccionar => new Command<Mcategorias>( (p) => Seleccionar(p));

        #endregion

    }
}
