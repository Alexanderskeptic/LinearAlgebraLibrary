using System;

namespace LinearAlgebraLibrary
{
    partial class Vector
    {
        #region Закрытые члены класса Vector

        #region Поля
        /// <summary>
        /// Координаты вектора
        /// </summary>
        private double[] Coordinates { get; set; }

        /// <summary>
        /// Рандомайзер
        /// </summary>
        private static readonly Random random = new System.Random();
        #endregion

        #region Методы
        /// <summary>
        /// Случайное число с плавающей точкой в заданном диапазоне
        /// </summary>
        /// <param name="a">Нижняя граница</param>
        /// <param name="b">Верхняя граница</param>
        /// <returns>Случайное число</returns>
        private static double GetRandomNumber(double a, double b) => random.NextDouble() * (b - a) + a;

        #endregion

        #endregion
    }
}
