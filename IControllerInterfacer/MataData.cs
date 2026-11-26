using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerInterfacer
{
    public readonly record struct MataData(
        int SequenceCounter, // byte 7 bits 2-7
        int Timestamp, // Bye 11&12
        byte BatterieLadung, // Byte 30usb//Byte 32 Bluetooth  Bits 0–3 (byte & 0x0F): Akkustand in Stufen von 0 bis 10 (über USB beim Laden 0 bis 11). Multipliziert mit 10 ergibt das den Prozentwert (0–100 %).
        bool WirdGeladen, // "" Bit 4 
        bool istVerbunden,
        long LetzteUpdateTicks,
        bool isBluetooth,
        uint DroppedPackets,

        byte SequenceZähler,
        long LetztesUpdateTicks,
        float PollingIntervallMs,
        float MaxJitterMs,
        byte ConnectionQuality



    );
}
