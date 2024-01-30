using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Fcnimc.ViewModels
{
    public class VMcriticar : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        double _peso;
        double _altura;
        int _latidos;
        double _resultado;

        #endregion
        #region CONSTRUCTOR
        public VMcriticar(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        public double Peso
        {
            get { return _peso; }
            set { SetValue(ref _peso, value); }
        }
        public double Altura
        {
            get { return _altura; }
            set { SetValue(ref _altura, value); }
        }
        public int Latidos
        {
            get { return _latidos; }
            set { SetValue(ref _latidos, value); }
        }
        public double Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {
            if(_peso!=null)
            {
                if(_peso < 18.5)
                {
                    Console.WriteLine("Peso Insuficiente");
                }
                else if(_peso ==18.5 ||  _peso == 24.9)
                {
                    Console.WriteLine("Peso Normal");
                }
                else
                {
                    Console.WriteLine("Peso obeso");
                }
            }
            else
            {
                if (_latidos<60)
                {
                    Console.WriteLine("Frecuencia cardiaca baja");
                }
                else if (_latidos==60 || _latidos == 100)
                {
                    Console.WriteLine("Frecuencia cardiaca normal");
                }
                else
                {
                    Console.WriteLine("Frecuencia cardiaca alta");
                }
            }
        }
        public void procesoSimple()
        {
        }

        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(procesoSimple);
        #endregion
    }
}
