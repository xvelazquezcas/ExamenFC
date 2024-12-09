using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenFC.VistaModelo
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        private int _latidos;
        private int _frecuenciaCardiaca;
        private string _estado;
        #endregion

        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region PROPIEDADES
        public int Latidos
        {
            get { return _latidos; }
            set { SetValue(ref _latidos, value); }
        }

        public int FrecuenciaCardiaca
        {
            get { return _frecuenciaCardiaca; }
            set { SetValue(ref _frecuenciaCardiaca, value); }
        }

        public string Estado
        {
            get { return _estado; }
            set { SetValue(ref _estado, value); }
        }
        #endregion

        #region MÉTODOS
        public void CalcularFrecuencia()
        {
            FrecuenciaCardiaca = Latidos * 4;

            if (FrecuenciaCardiaca < 60)
                Estado = "Frecuencia cardiaca baja";
            else if (FrecuenciaCardiaca > 100)
                Estado = "Frecuencia cardiaca alta";
            else
                Estado = "Frecuencia cardiaca normal";
        }
        #endregion

        #region COMANDOS
        public ICommand CalcularFrecuenciaCommand => new Command(CalcularFrecuencia);
        #endregion
    }
}


