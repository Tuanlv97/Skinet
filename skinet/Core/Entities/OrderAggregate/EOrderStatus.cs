using System.Runtime.Serialization;

namespace Core.Entities.OrderAggregate
{
    public enum EOrderStatus : byte
    {
        [EnumMember(Value = "Pending")]
        Pending,

        [EnumMember(Value = "Payment Received")]
        PaymentReceived,

        [EnumMember(Value = "Payment Failed")]
        PaymentFailed
    }
}
