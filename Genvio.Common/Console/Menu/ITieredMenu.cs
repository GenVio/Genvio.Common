﻿namespace Genvio.Common.Console.Menu
{
    public interface ITieredMenu : IMenuItem
    {
        string MenuText { get; set; }
        TieredMenu TieredMenu { get; set; }
    }
}
