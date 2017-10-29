using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDePersonas;
using InterfacesLaboratorio.Personas;
using InterfacesLaboratorio;
using InterfacesLaboratorio.Personas.Peticiones;
using System.ComponentModel;
using System.Collections.ObjectModel;
using InterfacesLaboratorio.Personas.Respuestas;
namespace WPFLaboratorio.vewModels
{
    public class MantenimientoDePersonasVM: INotifyPropertyChanged
    {
        private NuevaPersona _nuevaPersona = new NuevaPersona();
        public NuevaPersona nuevaPersona
        {
            get { return _nuevaPersona; }
            set
            {
                this._nuevaPersona = value;
                this.OnPropertyChanged("nuevaPersona");
            }

        }
        public void GrabarPersona()
        {
            PersonaRegistrada nuevaPersonaRegistrado = this._gestorDePersonas.CrearPersona(this.nuevaPersona);
            this.personasRegistradas.Add(nuevaPersonaRegistrado);
            this.nuevaPersona = new NuevaPersona();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
      
        public void cargarPersonas()
        {
            this.personasRegistradas = new ObservableCollection<PersonaRegistrada>();
            _gestorDePersonas.ListarTodasLasPersonas().ForEach(x => this.personasRegistradas.Add(x));
        }

        public ObservableCollection<PersonaRegistrada> personasRegistradas { get; set; }
        private IGestorDePersonas _gestorDePersonas = new GestorDePersonas();
    }
}
