using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Services.Interfaces
{
    public interface IDataService
    {
        Item[] Load();
    }
}
