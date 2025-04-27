namespace GestionVikingos.Client.State
{
    using GestionVikingos.Client.Models;

    public class VikingosState
    {
        private List<Vikingo> _vikingos = new();
        private bool _cargando = true;
        private string _mensajeError;

        public IReadOnlyList<Vikingo> Vikingos => _vikingos;
        public bool Cargando => _cargando;
        public string MensajeError => _mensajeError;

        public event Action OnChange;

        public void SetVikingos(List<Vikingo> vikingos)
        {
            _vikingos = vikingos;
            _cargando = false;
            NotifyStateChanged();
        }

        public void SetCargando(bool cargando)
        {
            _cargando = cargando;
            NotifyStateChanged();
        }

        public void SetError(string mensaje)
        {
            _mensajeError = mensaje;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
} 