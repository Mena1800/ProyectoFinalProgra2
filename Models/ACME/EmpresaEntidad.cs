using System.ComponentModel.DataAnnotations;

namespace Models.ACME
{
    public class EmpresaEntidad
    {
        [Range(0, int.MaxValue, ErrorMessage = "Debe seleccionar una empresa.")]
        [Display(Name = "Código")]


        public int IDEmpresa { get; set; }

        [Required(ErrorMessage = "Debe de selecionar un tipo de empresa.")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un tipo de empresa.")]
        [Display(Name ="Tipo Empresa")]

        public int? IDTipoEmpresa { get; set; }

        [Required(ErrorMessage ="El nombre de la empresa es obligatorio.")]
        [Display(Name ="Nombre Empresa")]

        public string Empresa { get; set; } =string.Empty;

        [Required(ErrorMessage = "El nombre de la empresa es obligatorio.")]
        [Display(Name = "Nombre Empresa")]

        public string Direccion { get; set; } = string.Empty;

        [Required(ErrorMessage = "La direccion de la empresa es obligatorio.")]
        [Display(Name = "Direccion")]

        public string RUC { get; set; } = string.Empty;

        [Required(ErrorMessage = "El RUC de la empresa es obligatorio.")]
        [Display(Name = "RUC")]

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Debe ingresar la fecha de creacion.")]
        [Display(Name = "Fecha creacion")]

        public decimal Presupuesto { get; set; }

        [Required(ErrorMessage = "El presupuesto de la empresa es obligatorio")]
        [Display(Name = "Presupuesto")]

        public bool Activo { get; set; } = true;

        // Propiedad de navegacion a TipoEmpresa

        public TipoEmpresaEntidad? TipoEmpresaEntidad { get; set; }


    }
}
