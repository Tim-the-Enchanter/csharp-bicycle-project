﻿namespace CSharpBicycleProject;

internal interface IBicycle
{
    IWheelInterface Wheel { get; }
    BikeColor FrameColor {  get; set; }
    decimal Price { get; }
    string Model { get; }
    string Style { get; }
    int StartNumber { get; }

    void Paint(BikeColor color);


} // End Interface
