namespace Argus.Sync.Data.Models.SundaeSwap;

public record PriceByToken(
    ulong Slot,
    string TxHash,
    ulong TxIndex,
    string TokenXSubject,
    string TokenYSubject,
    ulong TokenXPrice,
    ulong TokenYPrice
) : IReducerModel;