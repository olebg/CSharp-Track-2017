﻿namespace CohesionAndCoupling.Contracts
{
    public interface IFigure3D
    {
        double Width { get; set; }

        double Height { get; set; }

        double Depth { get; set; }

        double Volume { get; set; }
    }
}
