using System.ComponentModel;

namespace SnackService.Api.Enum
{ 
    public enum EnumActive
    {
        [Description("Ativo")]
        Active = 1,

        [Description("Inativo")]
        Inactive = 0
    } 
}
