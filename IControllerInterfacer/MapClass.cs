using ControllerInterfacer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerInterfacer
{
    public class MapClass
    {
        public Dictionary<InputEnum, HidBinding> InputAddress { get; set; } = new();
        public Dictionary<OutputEnum, HidBinding> OutputAddress { get; set; } = new();
        public Dictionary<MetaEnum, HidBinding> MetaAddress { get; set; } = new();

    }
    public enum HidInputType : byte
    {
        None = 0,
        DigitalBit,     // Einzelnes Bit im Byte (z. B. Kreuz = Byte 5, Maske 0x20)
        AnalogAxis,     // Stick-Achse: 0..255 -> -1.0f .. +1.0f
        AnalogTrigger,  // Trigger (L2/R2): 0..255 -> 0.0f .. +1.0f
        DpadDirection   // Hat-Switch (untere 4 Bits 0..7): inkl. Diagonalen!
    }

    public readonly record struct HidBinding(
        HidInputType Type,
        byte ByteIndex,
        byte MaskOrValue = 0
    );

}
