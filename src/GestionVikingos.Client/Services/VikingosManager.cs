namespace GestionVikingos.Client.Services
{
    using GestionVikingos.Client.Models;
    using GestionVikingos.Client.State;

    public class VikingosManager
    {
        private readonly VikingoService _vikingoService;
        private readonly VikingosState _state;

        public VikingosManager(VikingoService vikingoService, VikingosState state)
        {
            _vikingoService = vikingoService;
            _state = state;
        }

        public async Task CargarVikingos()
        {
            try
            {
                _state.SetCargando(true);
                _state.SetError(null);
                var vikingos = await _vikingoService.ObtenerTodos();
                _state.SetVikingos(vikingos.ToList());
            }
            catch (Exception ex)
            {
                _state.SetError($"No se pudieron cargar los vikingos. Esto puede deberse a un problema de conexión o un error en el servidor. Detalles: {ex.Message}");
            }
            finally
            {
                _state.SetCargando(false);
            }
        }

        public async Task CrearVikingo(Vikingo vikingo)
        {
            try
            {
                _state.SetCargando(true);
                _state.SetError(null);
                await _vikingoService.Crear(vikingo);
                await CargarVikingos();
            }
            catch (Exception ex)
            {
                _state.SetError($"No se pudo crear el vikingo '{vikingo.Nombre}'. Verifica que los datos ingresados sean correctos. Detalles: {ex.Message}");
                throw;
            }
            finally
            {
                _state.SetCargando(false);
            }
        }

        public async Task ActualizarVikingo(int id, Vikingo vikingo)
        {
            try
            {
                _state.SetCargando(true);
                _state.SetError(null);
                await _vikingoService.Actualizar(id, vikingo);
                await CargarVikingos();
            }
            catch (Exception ex)
            {
                _state.SetError($"No se pudo actualizar el vikingo con ID {id}. Verifica que los datos ingresados sean correctos y que el vikingo exista. Detalles: {ex.Message}");
                throw;
            }
            finally
            {
                _state.SetCargando(false);
            }
        }

        public async Task EliminarVikingo(int id)
        {
            try
            {
                _state.SetCargando(true);
                _state.SetError(null);
                await _vikingoService.Eliminar(id);
                await CargarVikingos();
            }
            catch (Exception ex)
            {
                _state.SetError($"No se pudo eliminar el vikingo con ID {id}. Esto puede deberse a un problema de conexión o a que el vikingo ya no existe. Detalles: {ex.Message}");
                throw;
            }
            finally
            {
                _state.SetCargando(false);
            }
        }
    }
} 