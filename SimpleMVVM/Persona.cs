using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVVM
{
    class Persona : INotifyPropertyChanged
    {
        public double Altura { get; set; }

        public double Peso { get; set; }

        public double Imc
        {
            get { return (Altura == 0) ? 0 : Peso / Altura; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

