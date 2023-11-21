using System.ComponentModel;

namespace SnackService.Api.Enum
{
    public enum EnumStatusPedido
    {
        // Em Preparacao
        [Description("Em Preparação")]
        InPreparation = 1,
        // Aguardando Entregador
        [Description("Aguardando Entregador")]
        WaitingDeliveryman = 2,
        // Em Deslocamento
        [Description("Em Deslocamento")]
        OnTheMove = 3,
        // Pedido Entregue
        [Description("Entregue")]
        OrderDelivered = 4,
        // Pedido Cancelado
        [Description("Cancelado")]
        OrderCancelled = 5
    }
}

