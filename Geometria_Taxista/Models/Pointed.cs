
using Geometria_Taxista.Interfaces;
using System;
using System.Text;

namespace Geometria_Taxista.Models
{
     public class Pointed : IPointable
    {
        private int _point;


        public Pointed(int point)
        {
            _point = point;
        }

        public int ManhattanDistance(Pointed point)
        {
            int coord1 = this._point;
            int coord2 = point ;

            return 0;
        }

    }
}
