using System;
using System.Linq;
using static System.Math;

namespace LinearAlgebraLibrary
{
    /// <summary>
    /// Вектор из линейной алгебры
    /// </summary>
    public partial class Vector
    {
        #region Открытые члены класса Vector

        #region Поля
        /// <summary>
        /// Размерность вектора
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Длина вектора
        /// </summary>
        public double Length 
        { 
            get => Sqrt(Coordinates.Sum(x => x * x));
            private set { }
        }
        #endregion

        #region Перегруженные операторы

        /// <summary>
        /// Унарный плюс
        /// </summary>
        /// <param name="vector">Вектор</param>
        /// <returns> Унарный плюс возвращет сам вектор </returns>
        public static Vector operator +(Vector vector)
        {
            double[] new_c = new double[vector.Size];
            for (int i = 0; i < vector.Size; i++)
                new_c[i] = vector.Coordinates[i];

            return new Vector(new_c);
        }

        /// <summary>
        /// Унарный минус
        /// </summary>
        /// <param name="vector">Вектор</param>
        /// <returns> Унарный минус возвращает вектор * -1 </returns>
        public static Vector operator -(Vector vector)
        {
            double[] new_c = new double[vector.Size];
            for (int i = 0; i < vector.Size; i++)
                new_c[i] = -vector.Coordinates[i];

            return new Vector(new_c);
        }

        /// <summary>
        /// Сложение векторов
        /// </summary>
        /// <param name="vector1">Первый вектор</param>
        /// <param name="vector2">Второй вектор</param>
        /// <returns>Сумма двух векторов или null, если у них разная размерность</returns>
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            if (vector1.Size != vector2.Size)
                return null;

            double[] new_c = new double[vector1.Size];
            for (int i = 0; i < vector1.Size; i++)
                new_c[i] = vector1.Coordinates[i] + vector2.Coordinates[i];

            return new Vector(new_c);
        }

        /// <summary>
        /// Вычитание векторов
        /// </summary>
        /// <param name="vector1">Первый вектор</param>
        /// <param name="vector2">Второй вектор</param>
        /// <returns>Сумма двух векторов или null, если у них разная размерность</returns>
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            if (vector1.Size != vector2.Size)
                return null;

            double[] new_c = new double[vector1.Size];
            for (int i = 0; i < vector1.Size; i++)
                new_c[i] = vector1.Coordinates[i] - vector2.Coordinates[i];

            return new Vector(new_c);
        }

        /// <summary>
        /// Скалярное произведение векторов
        /// </summary>
        /// <param name="vector1">Первый вектор</param>
        /// <param name="vector2">Второй вектор</param>
        /// <returns>ЛК координат двух векторов или double.NaN, если у них разная размерность</returns>
        public static double operator *(Vector vector1, Vector vector2)
        {
            if (vector1.Size != vector2.Size)
                return double.NaN;

            double product = 0.0d;
            for (int i = 0; i < vector1.Size; i++)
                product += vector1.Coordinates[i] * vector2.Coordinates[i];

            return product;
        }

        /// <summary>
        /// Умножение вектора на дробную константу
        /// </summary>
        /// <param name="v">Вектор</param>
        /// <param name="c">Константа</param>
        /// <returns>Вектор с новыми координатами</returns>
        public static Vector operator *(Vector vector1, double constant)
        {
            double[] new_c = new double[vector1.Size];
            Array.Copy(vector1.Coordinates, new_c, vector1.Size);

            for (int i = 0; i < vector1.Size; i++)
                new_c[i] *= constant;

            return new Vector(new_c);
        }

        /// <summary>
        /// Умножение дробной константы на вектор
        /// </summary>
        /// <param name="constant">Константа</param>
        /// /// <param name="vector">Вектор</param>
        /// <returns>Вектор с новыми координатами</returns>
        public static Vector operator *(double constant, Vector vector)
        {
            double[] new_c = new double[vector.Size];
            Array.Copy(vector.Coordinates, new_c, vector.Size);

            for (int i = 0; i < vector.Size; i++)
                new_c[i] *= constant;

            return new Vector(new_c);
        }

        /// <summary>
        /// Умножение вектора на целочисленную константу
        /// </summary>
        /// <param name="vector">Вектор</param>
        /// <param name="constant">Константа</param>
        /// <returns>Вектор с новыми координатами</returns>
        public static Vector operator *(Vector vector, int constant)
        {
            double[] new_c = new double[vector.Size];
            Array.Copy(vector.Coordinates, new_c, vector.Size);

            for (int i = 0; i < vector.Size; i++)
                new_c[i] *= constant;

            return new Vector(new_c);
        }

        /// <summary>
        /// Умножение целочисленной константы на вектор
        /// </summary>
        /// <param name="constant">Константа</param>
        /// /// <param name="vector">Вектор</param>
        /// <returns>Вектор с новыми координатами</returns>
        public static Vector operator *(int constant, Vector vector)
        {
            double[] new_c = new double[vector.Size];
            Array.Copy(vector.Coordinates, new_c, vector.Size);

            for (int i = 0; i < vector.Size; i++)
                new_c[i] *= constant;

            return new Vector(new_c);
        }

        #endregion

        #region Перегруженные методы
        /// <summary>
        /// Преобразование в строку
        /// </summary>
        /// <returns>Строковое представление вектора</returns>
        public override string ToString()
        {
            string output = string.Empty;
            for (int i = 0; i < Size; i++)
                output += $" {Coordinates[i]} ;";
            output = output.Remove(0, 1);
            output = output.Remove(output.Length - 2, 2);
            return $"{{{output}}}";
        }
        #endregion

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="index">Индекс координаты</param>
        /// <returns>Координата вектора по индексу</returns>
        public double this[int index]
        {
            get => Coordinates[index];
            set
            {
                Coordinates[index] = value;
            }
        }

        #region Методы

        #region Обычные
        /// <summary>
        /// Получить координаты вектора
        /// </summary>
        /// <returns>Возвращает массив координат</returns>
        public double[] GetCoordinates()
        {
            return Coordinates;
        }

        /// <summary>
        /// Нормализация вектора
        /// Нормализация — приведение к единичному размеру; 
        /// Нормализация вектора — это преобразование заданного вектора в вектор в том же направлении, но с единичной длиной.
        /// Для нормализации вектора нужно каждую компоненту поделить на длину вектора, или умножить инверсию длины на данный вектор.
        /// </summary>
        public void Normalize()
        {
            if (!IsZero(this))
            {
                double inv_length = (1 / Length);
                for (int i = 0; i < Size; i++)
                    //Для нормализации вектора нужно каждую компоненту поделить на длину вектора.
                    Coordinates[i] *= inv_length;
            }
                
        }

        /// <summary>
        /// Получить срез координат вектора
        /// </summary>
        /// <param name="from">Начальный индекс среза</param>
        /// <param name="to">Конечный индекс среза</param>
        /// <returns>Возвращает массив координат, либо null (если индексы неккоректны)</returns>
        public double[] GetCoordinatesSlice(int from, int to)
        {
            if (from < 0 || from > to || to > Size)
                return null;
            int size = to - from + 1;
            double[] new_c = new double[size];
            for (int i = from; i <= to; i++)
                new_c[i - from] = Coordinates[i];
            return new_c;
        }
        #endregion

        #region Статические

        /// <summary>
        /// Получить срез координат вектора
        /// </summary>
        /// <param name="vector">Вектор, срез координат которого нужно получить</param>
        /// <param name="from">Начальный индекс среза</param>
        /// <param name="to">Конечный индекс среза</param>
        /// <returns>Возвращает вектор, либо null (если индексы неккоректны)</returns>
        public static double[] GetCoordinatesSlice(Vector vector, int from, int to)
        {
            if (from < 0 || from > to || to > vector.Size)
                return null;
            int size = to - from + 1;
            double[] new_c = new double[size];
            for (int i = from; i <= to; i++)
                new_c[i - from] = vector.Coordinates[i];
            return (new_c);
        }

        /// <summary>
        /// Получение нулевого вектора
        /// </summary>
        /// <param name="size">Размерность</param>
        /// <returns>Нулевой вектор</returns>
        public static Vector GetZeroVector(int size)
        {
            double[] c = new double[size];
            for (int i = 0; i < size; i++)
                c[i] = 0d;
            return new Vector(c);
        }

        /// <summary>
        /// Получение вектора со всеми единичными координатами
        /// </summary>
        /// <param name="size">Размерность</param>
        /// <returns>Вектор со всеми единичными координатами</returns>
        public static Vector GetVectorOfOnes(int size)
        {
            double[] c = new double[size];
            for (int i = 0; i < size; i++)
                c[i] = 1d;
            return new Vector(c);
        }

        /// <summary>
        /// Получение вектора со случайными координатами в заданном диапазоне
        /// </summary>
        /// <param name="size">Размерность</param>
        /// <param name="min">Нижняя граница</param>
        /// <param name="max">Верхняя граница</param>
        /// <returns>Вектор со случайными координатами</returns>
        public static Vector GetRandomVector(int size, double min, double max)
        {
            double[] c = new double[size];
            for (int i = 0; i < size; i++)
                c[i] = GetRandomNumber(min, max);
            return new Vector(c);
        }

        /// <summary>
        /// Нулевой ли вектор?
        /// </summary>
        /// <param name="vector">Вектор</param>
        /// <returns>Является ли вектор нулевым</returns>
        public static bool IsZero(Vector vector)
        {
            for (int i = 0; i < vector.Size; i++)
                if (vector.Coordinates[i] != 0)
                    return false;
            return true;
        }
        #endregion

        #endregion

        #endregion
    }
}
