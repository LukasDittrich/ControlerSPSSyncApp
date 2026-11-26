using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerInterfacer
{
    public readonly record struct ControllerOutput(
         float VibrirenLeicht, 
         float VibrirenViel, 
         float FFB,
         ColorSruct Color
    );
}
