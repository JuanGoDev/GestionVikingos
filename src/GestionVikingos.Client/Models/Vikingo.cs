namespace GestionVikingos.Client.Models
{
    using GestionVikingos.Client.Models.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Vikingo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del vikingo es obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El número de batallas ganadas es obligatorio")]
        [Range(0, 1000, ErrorMessage = "El número de batallas debe estar entre 0 y 1000")]
        public int BatallasGanadas { get; set; }

        [Required(ErrorMessage = "El arma favorita es obligatoria")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El arma favorita debe tener entre 3 y 30 caracteres")]
        public string ArmaFavorita { get; set; }

        [Required(ErrorMessage = "El nivel de honor es obligatorio")]
        public NivelHonor NivelHonor { get; set; }

        [Required(ErrorMessage = "La causa de muerte gloriosa es obligatoria")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "La causa de muerte debe tener entre 10 y 100 caracteres")]
        public string CausaMuerteGloriosa { get; set; }

        public int ValhallaPoints { get; set; }
        public TipoGuerrero TipoGuerrero { get; set; }
    }
} 