using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnlaceDDatos
{
    public class Disco : NotificationObject
    {
        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set
            {
                titulo = value;
                OnPropertyChanged();
            }
        }

        private string banda;
        public string Banda
        {
            get { return banda; }
            set
            {
                banda = value;
                OnPropertyChanged();
            }
        }

        private string genero;

        public string Genero
        {
            get { return genero; }
            set
            {
                genero = value;
                OnPropertyChanged();
            }
        }

        private DateTime fechaLanzamiento;

        public DateTime FechaLanzamiento
        {
            get { return fechaLanzamiento; }
            set { fechaLanzamiento = value; }
        }

        private string portada;

        public string Portada
        {
            get { return portada; }
            set
            {
                portada = value;
                OnPropertyChanged();
            }
        }

        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set
            {
                precio = value;
                OnPropertyChanged();
            }
        }


        public override string ToString()
        {
            return $"{Titulo} {Banda}";
        }

    }
}
