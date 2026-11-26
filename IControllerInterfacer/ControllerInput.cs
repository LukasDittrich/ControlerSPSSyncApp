using System;
using System.Collections.Generic;
using System.Text;

namespace ControllerInterfacer
{
    public readonly record struct ControllerInput(
    #region Fahrsteuerung // Beispiele PS4 Controller
    float Beschleunigen, // R2
    float Entschleunigen, // L2
    float Lenken, // L3
    bool Totmann1, // L1 
    bool Totmann2, // L2
    #endregion

    #region other controlls
    bool DPad_UP,
    bool DPad_DN,
    bool DPad_LT,
    bool DPad_RT,
    bool Button01Quadrat,
    bool Button02Kreuz,
    bool Button03Kreis,
    bool Button04Dreieck,
    bool Button09Share,
    bool Button10Options,
    bool Button11L3Press,
    bool Button12L4Press,
    bool Button13Ps,
    bool Button14TouchPad,
    bool Button15Shift_UP,
    bool Button16Shift_DW,
    bool Button17Roto_UP,
    bool Button18Roto_DN,
    bool Button19Roto_Press,
    bool Button20Plus,
    bool Button20Minus,
    float R3_X, // R3
    float R3_Y, // R3
    float L3_Y // L3
    #endregion
);
}
