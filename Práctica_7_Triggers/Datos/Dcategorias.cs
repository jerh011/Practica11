
using Práctica_7_Triggers.VistaModelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Práctica_7_Triggers.Datos
{
    public class Dcategorias
    {

        public static ObservableCollection<Mcategorias> Mostrarcategorias()
        { 
        
        return new ObservableCollection<Mcategorias>() { 
            new Mcategorias()
            {  
                descripcion="Cena",
                numeroItem=4512,
                imagen="https://i.ibb.co/5TyBPqL/conejo.png",
                BackgroundColor="#EAEDF6",   
                TextColor="#000000"
                },
            new Mcategorias()
            {
                descripcion="Hotel",  
                numeroItem=4512,
                imagen="https://i.ibb.co/5TyBPqL/conejo.png",
                BackgroundColor="#EAEDF6",
                TextColor="#000000"
            },
            new Mcategorias()   
            {
                descripcion="Fiesta",
                numeroItem=4512,
                imagen="https://i.ibb.co/5TyBPqL/conejo.png",
                BackgroundColor="#EAEDF6",
                TextColor="#000000"
            },
            
            new Mcategorias()
            {
                descripcion="Flores", 
                numeroItem=4512,
                imagen="https://i.ibb.co/5TyBPqL/conejo.png",
                BackgroundColor="#EAEDF6",
                TextColor="#000000"
            }
           
        };
        }
    }
}
