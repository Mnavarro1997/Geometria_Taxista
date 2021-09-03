
using Geometria_Taxista.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria_Taxista.Interfaces
{
    public interface IPointable
    {
        public int ManhattanDistance(Pointed point);
    }
}
