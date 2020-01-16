using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVVM
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public Persona Usuario { get; set; }

        public MainWindowVM()
        {
            Usuario = new Persona();
        }

        public void Limpiar()
        {
            Usuario = new Persona();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

