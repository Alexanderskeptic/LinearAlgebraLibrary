# LinearAlgebraLibrary
Linear algebra library for use in C# projects
Linear algebra library is a simple assistant library for some vector space calculus.

Constructor.
You can construct a Vector object by sending a set of coordinates to Constructor.		
Vector(params double[] coordinates)

Fields.
The Vector class include several fields to:
1. Provide information of Vector size;				
Size
2. Provide information of Vector length;			
Length

Operators.
The Vector class defines following math operators of vector space:
1. Unary plus of vectors;							
Vector operator +(Vector v1)
2. Unary minus of vectors;							
Vector operator -(Vector v1)
3. Addition of vectors;								
Vector operator +(Vector v1, Vector v2)
4. Substraction of vectors;							
Vector operator -(Vector v1, Vector v2)
5. Scalar multiplication of vectors;				
double operator *(Vector v1, Vector v2)
6. Multiplying a vector by a constant;				
Vector operator *(Vector v1, double constant)										
Vector operator *(double constant, Vector v1)											
Vector operator *(Vector v1, int constant)											
Vector operator *(int constant, Vector v1)

Override Functions.
The Vector class include override function:
1. Converte Vector to a string representation;		
string ToString()

Indexator. 
Returns a Vector coordinate by index				
double this[int index]

Functions.
The Vector class include function to:
1. Normalize Vector;								
void Normalize()
2. Get double array of Vector coordinates;			
double[] GetCoordinates()
3. Get double array of Vector coordinates slice. Slice of coordinates is performed from initial index (from) to final index (to);					
double[] GetCoordinatesSlice(int from, int to)
4. Get double array of Vector coordinates slice. Slice of coordinates is performed from initial index (from) to final index (to);					
double[] GetCoordinatesSlice(Vector v1, int from, int to)
5. Get a zero vector;								
Vector GetZeroVector(int size)
6. Get a vector with all coordinates equal to one;	
Vector GetVectorOfOnes(int size)
7. Getting a vector with random coordinates. Random coordinates digits are produced in the specified range by minimum (min) and maximum (max);	
Vector GetRandomVector(int size, double min, double max)
8. Getting a boolean value, which specify is the object Vector zero vector;							
bool IsZero(Vector v)
