using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerInterfacer
{
    public readonly record struct StartupMataData(
       bool isBluetooth,
        ushort VendorId,
        ushort ProductId,
        string DevicePath
    )
    {

    }
}
