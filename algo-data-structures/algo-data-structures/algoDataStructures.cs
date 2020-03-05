﻿namespace algo_data_structures
{

    class generalSizes
    {
        public const int zeroSize = 0;
        public const int MATRIX_STD_LENGTH = 100;
        public const int STD_LENGTH = 10000;
    }

    class oneDimensionalArrayType <Type>
    {   

        public int Length = generalSizes.zeroSize;
        public int StartPoint = generalSizes.zeroSize;
        public int EndPoint = generalSizes.zeroSize;

        public Type[] oneDimensionalArray = new Type [generalSizes.STD_LENGTH];
    }

    class matrixType <Type>
    {
        public int Line = generalSizes.zeroSize;
        public int Column = generalSizes.zeroSize;

        public int StartLinePoint = generalSizes.zeroSize;
        public int EndLinePoint = generalSizes.zeroSize;
        public int StartColumnPoint = generalSizes.zeroSize;
        public int EndColumnPoint = generalSizes.zeroSize;

        public oneDimensionalArrayType <Type> mainDiagonal;
        public oneDimensionalArrayType <Type> aboveMainDiagonal;
        public oneDimensionalArrayType <Type> underMainDiagonal;
        public oneDimensionalArrayType <Type> secondaryDiagonal;
        public oneDimensionalArrayType <Type> aboveSecondaryDiagonal;
        public oneDimensionalArrayType <Type> underSecondaryDiagonal;
        public oneDimensionalArrayType <Type> northElements;
        public oneDimensionalArrayType <Type> southElements;
        public oneDimensionalArrayType <Type> eastElements;
        public oneDimensionalArrayType <Type> westElements;

        public Type[][] matrix = new Type [generalSizes.MATRIX_STD_LENGTH][];
    }
    
    class binaryTreeType <Type>
    {
        public Type value;
        public  binaryTreeType <Type> leftLeaf;
        public binaryTreeType <Type> rightLeaf;
    }

    class graphType <Type>
    {
        public graphType ()
        {
            adjacencyMatrix.Line = vertices;
            adjacencyMatrix.Column = adjacencyMatrix.Line;
            adjacencyMatrix.StartLinePoint = adjacencyMatrix.StartColumnPoint;
            adjacencyMatrix.EndLinePoint = adjacencyMatrix.EndColumnPoint;
        }

        public int vertices = generalSizes.zeroSize;
        public int edges = generalSizes.zeroSize;

        public matrixType <Type> adjacencyMatrix;
        public oneDimensionalArrayType <Type> verticesValency;
    }

    class limits <Type>
    {
        public Type minimLimit;
        public Type maximLimit;
    }

    class linearEquation
    {
        public float slope;
        public float y_intercept;
        public float root;
    }

    class quadraticEquation
    {
        public float coefficient_a;
        public float coefficient_b;
        public float coefficient_c;

        limits<float> roots;
    }

    class complexNumber
    {
        private const float StandardComplexNumber = 1;

        public float ComplexNumberLength = StandardComplexNumber;
        public float RealPart = StandardComplexNumber;
        public float ImaginaryPaty = StandardComplexNumber;
    }
}
