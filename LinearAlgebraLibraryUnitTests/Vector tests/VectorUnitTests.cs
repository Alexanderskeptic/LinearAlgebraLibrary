using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearAlgebraLibrary;

namespace LinearAlgebraLibraryUnitTests
{
    [TestClass]
    public class VectorUnitTests
    {
        [TestMethod]
        public void VectorSizeTestMethod()
        {
            // arrange
            double[] coordinates = new double[3] { 1, 2, 3 };
            Vector vector = new Vector(coordinates);
            const int ExpectedVectorSize = 3;

            // act
            var result = vector.Size;

            // assert
            Assert.AreEqual(ExpectedVectorSize, result);
        }

        [TestMethod]
        public void VectorLengthTestMethod()
        {
            // arrange
            double[] coordinates = new double[3] { 1, 2, 3 };
            Vector vector = new Vector(coordinates);
            const double ExpectedVectorLength = 3.7416573867739413;

            // act
            var result = vector.Length;

            // assert
            Assert.AreEqual(ExpectedVectorLength, result);
        }

        #region Тесты перегруженных операторов

        [TestMethod]
        public void UnaryPlusTestMethod()
        {
            // arrange
            double[] coordinates = new double[3] { 1.9, 2.5, 3.334 };
            Vector vector = new Vector(coordinates);
            const int ExpectedVectorSize = 3;
            const double ExpectedVectorLength = 4.579907859335163;
            double[] ExpectedVectorCoordinates = new double[3] { 1.9, 2.5, 3.334 };

            // act
            vector = +vector;

            // assert
            Assert.AreEqual(ExpectedVectorCoordinates[0], vector[0]);
            Assert.AreEqual(ExpectedVectorCoordinates[1], vector[1]);
            Assert.AreEqual(ExpectedVectorCoordinates[2], vector[2]);

            Assert.AreEqual(ExpectedVectorSize, vector.Size);
            Assert.AreEqual(ExpectedVectorLength, vector.Length);
        }

        [TestMethod]
        public void UnaryMinusTestMethod()
        {
            // arrange
            double[] coordinates = new double[3] { 1.9, 2.5, 3.334 };
            Vector vector = new Vector(coordinates);
            const int ExpectedVectorSize = 3;
            const double ExpectedVectorLength = 4.579907859335163;
            double[] ExpectedVectorCoordinates = new double[3] { -1.9, -2.5, -3.334 };

            // act
            vector = -vector;

            // assert
            Assert.AreEqual(ExpectedVectorCoordinates[0], vector[0]);
            Assert.AreEqual(ExpectedVectorCoordinates[1], vector[1]);
            Assert.AreEqual(ExpectedVectorCoordinates[2], vector[2]);

            Assert.AreEqual(ExpectedVectorSize, vector.Size);
            Assert.AreEqual(ExpectedVectorLength, vector.Length);
        }

        [TestMethod]
        public void AdditionTestMethod()
        {
            // arrange
            double[] coordinates1 = new double[3] { 1.9, 2.5, 3.334 };
            double[] coordinates2 = new double[3] { 3.1, 2.5, 1.666 };
            Vector vector1 = new Vector(coordinates1);
            Vector vector2 = new Vector(coordinates2);
            const int ExpectedVectorSize = 3;
            const double ExpectedVectorLength = 8.660254037844387;
            double[] ExpectedVectorCoordinates = new double[3] { 5, 5, 5 };

            // act
            Vector vector3 = vector1 + vector2;

            // assert
            Assert.AreEqual(ExpectedVectorCoordinates[0], vector3[0]);
            Assert.AreEqual(ExpectedVectorCoordinates[1], vector3[1]);
            Assert.AreEqual(ExpectedVectorCoordinates[2], vector3[2]);

            Assert.AreEqual(ExpectedVectorSize, vector3.Size);
            Assert.AreEqual(ExpectedVectorLength, vector3.Length);
        }

        [TestMethod]
        public void SubtractionTestMethod()
        {
            // arrange
            double[] coordinates1 = new double[3] { 5, 5, 5 };
            double[] coordinates2 = new double[3] { 3.1, 2.5, 1.666 };
            Vector vector1 = new Vector(coordinates1);
            Vector vector2 = new Vector(coordinates2);
            const int ExpectedVectorSize = 3;
            const double ExpectedVectorLength = 4.579907859335163;
            double[] ExpectedVectorCoordinates = new double[3] { 1.9, 2.5, 3.334 };

            // act
            Vector vector3 = vector1 - vector2;

            // assert
            Assert.AreEqual(ExpectedVectorCoordinates[0], vector3[0]);
            Assert.AreEqual(ExpectedVectorCoordinates[1], vector3[1]);
            Assert.AreEqual(ExpectedVectorCoordinates[2], vector3[2]);

            Assert.AreEqual(ExpectedVectorSize, vector3.Size);
            Assert.AreEqual(ExpectedVectorLength, vector3.Length);
        }

        [TestMethod]
        public void ScalarMultiplicationTestMethod()
        {
            // arrange
            double[] coordinates1 = new double[3] { 1.911, 2.235, 3.334 }; ;
            double[] coordinates2 = new double[3] { 233.111, -2.5, 1.9912 };
            Vector vector1 = new Vector(coordinates1);
            Vector vector2 = new Vector(coordinates2);
            const double ExpectedScalarMultiplicationResult = 446.52628180000005;

            // act
            double result = vector1 * vector2;

            // assert
            Assert.AreEqual(ExpectedScalarMultiplicationResult, result);
        }

        [TestMethod]
        public void MultiplyingAVectorByADoubleConstantTestMethod()
        {
            // arrange
            double[] coordinates = new double[3] { 233.111111, -2.5, 1.9912 };
            Vector vector = new Vector(coordinates);
            const double constant = 1.12345678;
            const int ExpectedVectorSize = 3;
            const double ExpectedVectorLength = 261.91487180371496;
            double[] ExpectedVectorCoordinates = new double[3] { 261.8902581462826, -2.8086419499999997, 2.237027140336 };

            // act
            Vector result = vector * constant;

            // assert
            Assert.AreEqual(ExpectedVectorCoordinates[0], result[0]);
            Assert.AreEqual(ExpectedVectorCoordinates[1], result[1]);
            Assert.AreEqual(ExpectedVectorCoordinates[2], result[2]);

            Assert.AreEqual(ExpectedVectorSize, result.Size);
            Assert.AreEqual(ExpectedVectorLength, result.Length);
        }

        [TestMethod]
        public void MultiplyingADoubleConstantByAVectorTestMethod()
        {
            // arrange
            double[] coordinates = new double[3] { 233.111111, -2.5, 1.9912 };
            Vector vector = new Vector(coordinates);
            const double constant = 1.12345678;
            const int ExpectedVectorSize = 3;
            const double ExpectedVectorLength = 261.91487180371496;
            double[] ExpectedVectorCoordinates = new double[3] { 261.8902581462826, -2.8086419499999997, 2.237027140336 };


            // act
            Vector result = constant * vector;

            // assert
            Assert.AreEqual(ExpectedVectorCoordinates[0], result[0]);
            Assert.AreEqual(ExpectedVectorCoordinates[1], result[1]);
            Assert.AreEqual(ExpectedVectorCoordinates[2], result[2]);

            Assert.AreEqual(ExpectedVectorSize, result.Size);
            Assert.AreEqual(ExpectedVectorLength, result.Length);
        }

        [TestMethod]
        public void MultiplyingAVectorByAnIntegerConstantTestMethod()
        {
            // arrange
            double[] coordinates = new double[3] { 233.111111, -2.5, 1.9912 };
            Vector vector = new Vector(coordinates);
            const int constant = 1000;
            const int ExpectedVectorSize = 3;
            const double ExpectedVectorLength = 233133.01986010975;
            double[] ExpectedVectorCoordinates = new double[3] { 233111.111, -2500, 1991.2 };

            // act
            Vector result = vector * constant;

            // assert
            Assert.AreEqual(ExpectedVectorCoordinates[0], result[0]);
            Assert.AreEqual(ExpectedVectorCoordinates[1], result[1]);
            Assert.AreEqual(ExpectedVectorCoordinates[2], result[2]);

            Assert.AreEqual(ExpectedVectorSize, result.Size);
            Assert.AreEqual(ExpectedVectorLength, result.Length);
        }

        [TestMethod]
        public void MultiplyingAnIntegerConstantByAVectorTestMethod()
        {
            // arrange
            double[] coordinates = new double[3] { 233.111111, -2.5, 1.9912 };
            Vector vector = new Vector(coordinates);
            const int constant = 1000;
            const int ExpectedVectorSize = 3;
            const double ExpectedVectorLength = 233133.01986010975;
            double[] ExpectedVectorCoordinates = new double[3] { 233111.111, -2500, 1991.2 };


            // act
            Vector result = constant * vector;

            // assert
            Assert.AreEqual(ExpectedVectorCoordinates[0], result[0]);
            Assert.AreEqual(ExpectedVectorCoordinates[1], result[1]);
            Assert.AreEqual(ExpectedVectorCoordinates[2], result[2]);

            Assert.AreEqual(ExpectedVectorSize, result.Size);
            Assert.AreEqual(ExpectedVectorLength, result.Length);
        }

        #endregion

        #region Тесты перегруженных методов

        [TestMethod]
        public void VectorToStringTestMethod()
        {
            // arrange
            double[] coordinates = new double[3] { 01.123456789, -22222, -(-3.1 + 0.9) };
            Vector vector = new Vector(coordinates);
            const string ExpectedVectorString = "{1,123456789 ; -22222 ; 2,2}";

            // act
            var result = vector.ToString();

            // assert
            Assert.AreEqual(ExpectedVectorString, result);
        }

        #endregion

        #region Тесты методов

        [TestMethod]
        public void VectorGetCoordinatesMethod()
        {
            // arrange
            double[] coordinates = new double[3] { 01.123456789, -22222, -(-3.1 + 0.9) };
            Vector vector = new Vector(coordinates);
            double[] ExpectedVectorCoordinates = new double[3] { 01.123456789, -22222, -(-3.1 + 0.9) };

            // act
            double[] VectorCoordinates = vector.GetCoordinates();

            // assert
            Assert.AreEqual(ExpectedVectorCoordinates[0], VectorCoordinates[0]);
            Assert.AreEqual(ExpectedVectorCoordinates[1], VectorCoordinates[1]);
            Assert.AreEqual(ExpectedVectorCoordinates[2], VectorCoordinates[2]);
        }

        [TestMethod]
        public void VectorNormalizationTestMethod()
        {
            // arrange
            double[] coordinates = new double[3] { 9, 9, 9 };
            Vector vector = new Vector(coordinates);
            const int ExpectedVectorSize = 3;
            const double ExpectedVectorLength = 1;
            double[] ExpectedVectorCoordinates = new double[3] { 0.5773502691896257, 0.5773502691896257, 0.5773502691896257 };

            // act
            vector.Normalize();

            // assert
            Assert.AreEqual(ExpectedVectorCoordinates[0], vector[0]);
            Assert.AreEqual(ExpectedVectorCoordinates[1], vector[1]);
            Assert.AreEqual(ExpectedVectorCoordinates[2], vector[2]);

            Assert.AreEqual(ExpectedVectorSize, vector.Size);
            Assert.AreEqual(ExpectedVectorLength, vector.Length);
        }

        [TestMethod]
        public void VectorGetCoordinatesSliceTestMethod()
        {
            // arrange
            double[] coordinates = new double[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Vector vector = new Vector(coordinates);
            double[] ExpectedCoordinatesSlice = new double[5] { 3, 4, 5, 6, 7 };

            // act
            double[] CoordinatesSlice = vector.GetCoordinatesSlice(3, 8);

            // assert
            Assert.AreEqual(ExpectedCoordinatesSlice[0], CoordinatesSlice[0]);
            Assert.AreEqual(ExpectedCoordinatesSlice[1], CoordinatesSlice[1]);
            Assert.AreEqual(ExpectedCoordinatesSlice[2], CoordinatesSlice[2]);
            Assert.AreEqual(ExpectedCoordinatesSlice[3], CoordinatesSlice[3]);
            Assert.AreEqual(ExpectedCoordinatesSlice[4], CoordinatesSlice[4]);
        }

        [TestMethod]
        public void StaticGetCoordinatesSliceTestMethod()
        {
            // arrange
            double[] coordinates = new double[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Vector vector = new Vector(coordinates);
            double[] ExpectedCoordinatesSlice = new double[5] { 3, 4, 5, 6, 7 };

            // act
            double[] CoordinatesSlice = Vector.GetCoordinatesSlice(vector, 3, 8);

            // assert
            Assert.AreEqual(ExpectedCoordinatesSlice[0], CoordinatesSlice[0]);
            Assert.AreEqual(ExpectedCoordinatesSlice[1], CoordinatesSlice[1]);
            Assert.AreEqual(ExpectedCoordinatesSlice[2], CoordinatesSlice[2]);
            Assert.AreEqual(ExpectedCoordinatesSlice[3], CoordinatesSlice[3]);
            Assert.AreEqual(ExpectedCoordinatesSlice[4], CoordinatesSlice[4]);
        }

        [TestMethod]
        public void StaticGetZeroVectorTestMethod()
        {
            // arrange
            const int ExpectedVectorSize = 5;
            const double ExpectedVectorLength = 0;
            double[] ExpectedCoordinates = new double[5] { 0, 0, 0, 0, 0 };

            // act
            Vector vector = Vector.GetZeroVector(5);

            // assert
            Assert.AreEqual(ExpectedCoordinates[0], vector[0]);
            Assert.AreEqual(ExpectedCoordinates[1], vector[1]);
            Assert.AreEqual(ExpectedCoordinates[2], vector[2]);
            Assert.AreEqual(ExpectedCoordinates[3], vector[3]);
            Assert.AreEqual(ExpectedCoordinates[4], vector[4]);

            Assert.AreEqual(ExpectedVectorSize, vector.Size);
            Assert.AreEqual(ExpectedVectorLength, vector.Length);
        }

        [TestMethod]
        public void StaticGetVectorOfOnesTestMethod()
        {
            // arrange
            const int ExpectedVectorSize = 5;
            const double ExpectedVectorLength = 2.23606797749979;
            double[] ExpectedCoordinates = new double[5] { 1, 1, 1, 1, 1 };

            // act
            Vector vector = Vector.GetVectorOfOnes(5);

            // assert
            Assert.AreEqual(ExpectedCoordinates[0], vector[0]);
            Assert.AreEqual(ExpectedCoordinates[1], vector[1]);
            Assert.AreEqual(ExpectedCoordinates[2], vector[2]);
            Assert.AreEqual(ExpectedCoordinates[3], vector[3]);
            Assert.AreEqual(ExpectedCoordinates[4], vector[4]);

            Assert.AreEqual(ExpectedVectorSize, vector.Size);
            Assert.AreEqual(ExpectedVectorLength, vector.Length);
        }

        [TestMethod]
        public void StaticGetRandomVectorTestMethod()
        {
            // arrange
            const int ExpectedVectorSize = 5;

            // act
            Vector vector1 = Vector.GetRandomVector(5, 0, 1);
            Vector vector2 = Vector.GetRandomVector(5, 0, 1);

            // assert
            Assert.AreNotEqual(vector1[0], vector2[0]);
            Assert.AreNotEqual(vector1[1], vector2[1]);
            Assert.AreNotEqual(vector1[2], vector2[2]);
            Assert.AreNotEqual(vector1[3], vector2[3]);
            Assert.AreNotEqual(vector1[4], vector2[4]);

            Assert.AreEqual(ExpectedVectorSize, vector1.Size);
            Assert.AreEqual(ExpectedVectorSize, vector2.Size);
        }

        [TestMethod]
        public void StaticIsZeroTestMethod()
        {
            // arrange
            double[] coordinates = new double[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Vector zeroVector = new Vector(coordinates);

            // act
            bool result = Vector.IsZero(zeroVector);

            // assert
            Assert.IsTrue(result);
        }

        #endregion
    }
}
