namespace GestionVikingos.API.Services
{
    using GestionVikingos.API.Models;
    using GestionVikingos.API.Models.Enums;

    public class VikingoService
    {
        private readonly List<Vikingo> _vikingos;
        private int _idSiguiente = 1;

        public VikingoService()
        {
            _vikingos = new List<Vikingo>();
        }

        public IEnumerable<Vikingo> ObtenerTodos()
        {
            return _vikingos;
        }

        public Vikingo ObtenerPorId(int id)
        {
            return _vikingos.FirstOrDefault(v => v.Id == id);
        }

        public Vikingo Crear(Vikingo vikingo)
        {
            vikingo.Id = _idSiguiente++;
            CalcularValhallaPoints(vikingo);
            DeterminarTipoGuerrero(vikingo);
            _vikingos.Add(vikingo);
            return vikingo;
        }

        public Vikingo Actualizar(int id, Vikingo vikingo)
        {
            var vikingoExistente = _vikingos.FirstOrDefault(v => v.Id == id);
            if (vikingoExistente == null)
                return null;

            vikingoExistente.Nombre = vikingo.Nombre;
            vikingoExistente.BatallasGanadas = vikingo.BatallasGanadas;
            vikingoExistente.ArmaFavorita = vikingo.ArmaFavorita;
            vikingoExistente.NivelHonor = vikingo.NivelHonor;
            vikingoExistente.CausaMuerteGloriosa = vikingo.CausaMuerteGloriosa;

            CalcularValhallaPoints(vikingoExistente);
            DeterminarTipoGuerrero(vikingoExistente);

            return vikingoExistente;
        }

        public bool Eliminar(int id)
        {
            var vikingo = _vikingos.FirstOrDefault(v => v.Id == id);
            if (vikingo == null)
                return false;

            _vikingos.Remove(vikingo);
            return true;
        }

        private void CalcularValhallaPoints(Vikingo vikingo)
        {
            int puntos = 0;
            
            // Puntos por batallas ganadas
            puntos += vikingo.BatallasGanadas * 10;

            // Puntos por nivel de honor
            puntos += vikingo.NivelHonor switch
            {
                NivelHonor.Bajo => 50,
                NivelHonor.Medio => 100,
                NivelHonor.Alto => 200,
                _ => 0
            };

            vikingo.ValhallaPoints = puntos;
        }

        private void DeterminarTipoGuerrero(Vikingo vikingo)
        {
            if (vikingo.BatallasGanadas >= 10 && vikingo.NivelHonor == NivelHonor.Alto)
            {
                vikingo.TipoGuerrero = TipoGuerrero.Thor;
            }
            else if (vikingo.BatallasGanadas >= 5 && vikingo.NivelHonor == NivelHonor.Medio)
            {
                vikingo.TipoGuerrero = TipoGuerrero.Freyja;
            }
            else
            {
                vikingo.TipoGuerrero = TipoGuerrero.Odin;
            }
        }
    }
} 