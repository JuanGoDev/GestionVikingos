namespace GestionVikingos.API.Models
{
    using GestionVikingos.API.Models.Enums;

    public class Vikingo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int BatallasGanadas { get; set; }
        public string ArmaFavorita { get; set; }
        public NivelHonor NivelHonor { get; set; }
        public string CausaMuerteGloriosa { get; set; }
        public int ValhallaPoints { get; set; }
        public TipoGuerrero TipoGuerrero { get; set; }
    }
}