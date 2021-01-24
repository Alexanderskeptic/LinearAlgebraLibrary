using System;
using System.Linq;
using static System.Math;

namespace LinearAlgebraLibrary
{
    public partial class Vector
    {
        /// <summary>
        /// Конструктор вектора по набору координат
        /// </summary>
        /// <param name="coordinates"> Набор координат </param>
        public Vector(params double[] coordinates)
        {
            Coordinates = coordinates;
            Size = Coordinates.Length;
        }
    }
}
