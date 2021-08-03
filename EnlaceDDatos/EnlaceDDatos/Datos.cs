using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EnlaceDDatos
{
    public class Datos:NotificationObject
    {
        private ObservableCollection<Disco> _discos;

        public ObservableCollection<Disco> Discos   
        {
            get { return _discos; }
            set
            {
                _discos = value;
                OnPropertyChanged();
            }
        }

        public Datos()
        {
            Discos = new ObservableCollection<Disco>();
            Discos.Add(new Disco()
            {
                Banda = "The beatles", Titulo = "Help",
                Genero = "Rock and Roll",
                FechaLanzamiento = new DateTime(1965, 8, 6),
                Portada = "Help.jpg"
            });
            Discos.Add(new Disco()
            {
                Banda = "The beatles", Titulo = "Revolver",
                Genero = "Rock and Roll",
                FechaLanzamiento = new DateTime(1966, 8, 6),
                Portada = "Revolver.jpg"
            });
            Discos.Add(new Disco()
            {
                Banda = "The beatles", Titulo = "Let it be",
                Genero = "Rock and Roll",
                FechaLanzamiento = new DateTime(1970, 5, 8),
                Portada = "LetItBe.jpg"
            });
        }

        private Disco discoSeleccionado;

        public Disco DiscoSeleccionado
        {
            get { return discoSeleccionado; }
            set
            {
                discoSeleccionado = value;
                OnPropertyChanged();
            }
        }


    }
}
