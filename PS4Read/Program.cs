using HidSharp;
using System.IO;
using System.Threading;

// Get Controller
IEnumerable<HidDevice> devices = DeviceList.Local.GetHidDevices();

foreach (var d in devices)
{
    if (d.VendorID == 0x054C) // Sony
    {
        Console.WriteLine($"Gefunden: {d.ProductID:X4} {d.ProductName}");
    }
}


//Open Controller 
HidDevice? device = DeviceList.Local
    .GetHidDevices(0x054C)
    .FirstOrDefault();

if (device == null)
{
    Console.WriteLine(" Kein PS4 Controller gefunden");
    return;
}

var stream = device.Open();
Console.WriteLine(" Controller geöffnet");



//Read Inputs

byte[] buffer = new byte[78];
while (true){
    // Read 
    int len = 0;

    try
    {
        len = stream.Read(buffer, 0, buffer.Length);// Lese aus Datenstream und Schreibe in buffer 

    }
    catch
    {
        // Stream kaputt → Ende oder Reopen
    }

    if (len <= 0)
    {
        // ignorieren oder break
    }

    // buffer enthält gültige Daten
    // → DIREKT an SPS / Netzwerk / Queue weiterreichen
    //Console.WriteLine(Convert.ToString(buffer[11],2).PadLeft(8, '0'));
    Console.WriteLine(
    string.Join(" ",
        buffer.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')))
);
}



