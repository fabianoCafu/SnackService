namespace SnackService.Api.Enum
{
    public enum EnumStatusPedido
    {
        // Em Preparacao
        InPreparation = 1,
        // Aguardando Entregador
        WaitingDeliveryman = 2,
        // Em Deslocamento
        OnTheMove = 3,
        // Pedido Entregue
        OrderDelivered = 4,
        // Pedido Cancelado
        OrderCancelled = 5
    }
}

