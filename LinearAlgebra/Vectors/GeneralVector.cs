﻿using LinearAlgebra.Scalars;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LinearAlgebra.Vectors.Extensions;

namespace LinearAlgebra.Vectors
{
    [Serializable]
    public struct Vector<T> :
        IEnumerable,
        IEnumerable<Scalar<T>>,
        IEnumerable<T>,
        IVector<T, Vector<T>>
        where T : struct
    {
        #region Fields and Properties

        public static Scalar<int> Order => Scalar<int>.One;
        public Vector1<int> Dimension { get; }
        public int Length => Dimension.x.Value;

        public Scalar<T>[] Data { get; }
        public Scalar<T> this[int i] => Data[i];

        #endregion

        #region Static

        /// <summary>
        /// (1)
        /// </summary>
        public static readonly Vector<T> right = new Vector<T>(Scalar<T>.One);
        /// <summary>
        /// (-1)
        /// </summary>
        public static readonly Vector<T> left = new Vector<T>(-Scalar<T>.One);
        /// <summary>
        /// (0, 1)
        /// </summary>
        public static readonly Vector<T> up = new Vector<T>(Scalar<T>.Zero, Scalar<T>.One);
        /// <summary>
        /// (0, -1)
        /// </summary>
        public static readonly Vector<T> down = new Vector<T>(Scalar<T>.Zero, -Scalar<T>.One);
        /// <summary>
        /// (0, 0, 1)
        /// </summary>
        public static readonly Vector<T> forward = new Vector<T>(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One);
        /// <summary>
        /// (0, 0, -1)
        /// </summary>
        public static readonly Vector<T> backward = new Vector<T>(Scalar<T>.Zero, Scalar<T>.Zero, -Scalar<T>.One);
        /// <summary>
        /// (0, 0, 0, 1)
        /// </summary>
        public static readonly Vector<T> ana = new Vector<T>(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.One);
        /// <summary>
        /// (0, 0, 0, -1)
        /// </summary>
        public static readonly Vector<T> kata = new Vector<T>(Scalar<T>.Zero, Scalar<T>.Zero, Scalar<T>.Zero, -Scalar<T>.One);

        public static Vector<T> Zero(int dimension)
        {
            return new Vector<T>(Enumerable.Range(0, dimension).Select(_ => Scalar<T>.Zero).ToArray());
        }

        public static Vector<T> One(int dimension)
        {
            return new Vector<T>(Enumerable.Range(0, dimension).Select(_ => Scalar<T>.One).ToArray());
        }

        /// <summary>
        /// Retrurns an n-dimensional vector with the i-th element set to one
        /// </summary>
        /// <param name="dimension">the 'n' in n-dimensional, the dimension of the vector</param>
        /// <param name="basis">the 'i' in i-th element, the 1-indexed axis of the vector (1 for x, 2 for y etc.)</param>
        /// <returns></returns>
        public static Vector<T> Basis(int dimension, int basis)
        {
            return new Vector<T>(Enumerable.Range(0, dimension).Select(i => i == basis + 1 ? Scalar<T>.One : Scalar<T>.Zero).ToArray());
        }

        public static Vector<T> Repeat(T t, int dimension)
        {
            var arr = new Scalar<T>[dimension];

            for (int i = 0; i < dimension; i++)
                arr[i] = new Scalar<T>(t);

            return new Vector<T>(arr);
        }

        public static Vector<T> Range(T start, int dimension)
        {
            var arr = new Scalar<T>[dimension];
            arr[0] = new Scalar<T>(start);

            for (int i = 1; i < dimension; i++)
                arr[i - 1] = arr[i] + Scalar<T>.One;

            return new Vector<T>(arr);
        }

        #endregion

        #region Constructors

        public Vector(params Scalar<T>[] data)
        {
            Dimension = data.Length;
            Data = data;
        }

        public Vector(params T[] data) : this(data.Select(x => new Scalar<T>(x)).ToArray()) { }

        #endregion

        #region Functions

        public Scalar<T> SqrMagnitude => Dot(this);
        public Scalar<T> Magnitude => ScalarMath<T>.Sqrt(SqrMagnitude);
        public Vector<T> Normalized => this / Magnitude;

        public Scalar<T> Norm(int p)
        {
            if (p < 1) throw new ArgumentException("p must be greater than or equal to 1.", nameof(p));
            return Math.Pow(Data.Aggregate(Scalar<T>.Zero, (a, c) => a + Math.Pow(c, p)), 1d / p);
        }

        public Scalar<T> MaximumNorm()
        {
            return new Scalar<T>(Data.Max(x => x.Value));
        }

        public Vector<T> Subvector(int start, int count)
        {
            if (start < 0 || start >= Dimension || count < 0 || start + count > Dimension)
                throw new ArgumentException("Arguments outside vector bounds.");

            return new Vector<T>(Data.Skip(start).Take(count).ToArray());
        }

        public Vector<T> ExpandBy(int length)
        {
            return new Vector<T>(Data.Concat(Zero(length).Data).ToArray());
        }

        public Vector<T> ExpandTo(int targetLength)
        {
            if (targetLength <= Length)
                throw new ArgumentException($"{ nameof(targetLength) } must be greater than or equal to the length of this vector.");

            return new Vector<T>(Data.Concat(Zero(targetLength - Length).Data).ToArray());
        }

        public Scalar<T> Dot(Vector<T> vec)
        {
            if (Dimension != vec.Dimension)
                throw new DimensionMismatchException<Vector1<int>, Vector<T>>(nameof(vec), vec.Dimension, Dimension);

            Scalar<T> result = Scalar<T>.Zero;

            for (int i = 0; i < Dimension; i++)
                result += Data[i] * vec.Data[i];

            return result;
        }

        public Vector<T> Cross(Vector<T> vec)
        {
            if (Dimension != vec.Dimension)
                throw new DimensionMismatchException<Vector1<int>, Vector<T>>(nameof(vec), vec.Dimension, Dimension);

            if (Dimension == 0) return new Vector<T>(new Scalar<T>[0]);
            if (Dimension == 1) return new Vector<T>(Scalar<T>.Zero);
            if (Dimension == 3) return new Vector<T>(
                Data[1] * vec.Data[2] - Data[2] * vec.Data[1],
                Data[2] * vec.Data[0] - Data[0] * vec.Data[2],
                Data[0] * vec.Data[1] - Data[1] * vec.Data[0]
            );
            if (Dimension == 7) return new Vector<T>(
                Data[1] * vec.Data[3] - Data[3] * vec.Data[1] + Data[2] * vec.Data[6] - Data[6] * vec.Data[2] + Data[4] * vec.Data[5] - Data[5] * vec.Data[4],
                Data[2] * vec.Data[4] - Data[4] * vec.Data[2] + Data[3] * vec.Data[0] - Data[0] * vec.Data[3] + Data[5] * vec.Data[6] - Data[6] * vec.Data[5],
                Data[3] * vec.Data[5] - Data[5] * vec.Data[3] + Data[4] * vec.Data[1] - Data[1] * vec.Data[4] + Data[6] * vec.Data[0] - Data[0] * vec.Data[6],
                Data[4] * vec.Data[6] - Data[6] * vec.Data[4] + Data[5] * vec.Data[2] - Data[2] * vec.Data[5] + Data[0] * vec.Data[1] - Data[1] * vec.Data[0],
                Data[5] * vec.Data[0] - Data[0] * vec.Data[5] + Data[6] * vec.Data[3] - Data[3] * vec.Data[6] + Data[1] * vec.Data[2] - Data[2] * vec.Data[1],
                Data[6] * vec.Data[1] - Data[1] * vec.Data[6] + Data[0] * vec.Data[4] - Data[4] * vec.Data[0] + Data[2] * vec.Data[3] - Data[3] * vec.Data[2],
                Data[0] * vec.Data[2] - Data[2] * vec.Data[0] + Data[1] * vec.Data[5] - Data[5] * vec.Data[1] + Data[3] * vec.Data[4] - Data[4] * vec.Data[3]
            );

            throw new Exception("Cross product can only be performed on vectors of dimension 0, 1, 3 and 7.");
        }

        public Vector<T> Scale(Vector<T> vec)
        {
            if (Dimension != vec.Dimension)
                throw new DimensionMismatchException<Vector1<int>, Vector<T>>(nameof(vec), vec.Dimension, Dimension);

            Scalar<T>[] result = new Scalar<T>[Dimension];

            for (int i = 0; i < Dimension; i++)
                result[i] = Data[i] * vec.Data[i];

            return new Vector<T>(result);
        }

        public Scalar<T> AngleTo(Vector<T> vec)
        {
            return Math.Acos(Dot(vec) / (Magnitude * vec.Magnitude));
        }

        public Vector<T> ProjectionOnto(Vector<T> vec)
        {
            return vec.Multiply(Dot(vec) / vec.Dot(vec));
        }

        public Scalar<T> SquareDistanceTo(Vector<T> vec)
        {
            return Substract(vec).SqrMagnitude;
        }

        public Scalar<T> DistanceTo(Vector<T> vec)
        {
            return Substract(vec).Magnitude;
        }

        public Vector<T> Lerp(Vector<T> vec, Scalar<T> t)
        {
            return Add(vec.Substract(this).Multiply(t));
        }

        #endregion

        #region Operators

        #region Arithmetic

        public Vector<T> Add(Vector<T> vec)
        {
            if (Dimension != vec.Dimension) throw new ArgumentException("Parameter 'v' must be in the same dimension as the current vector.");

            return new Vector<T>(Data.Select((x, i) => x + vec.Data[i]).ToArray());
        }

        public static Vector<T> operator +(Vector<T> left, Vector<T> right)
        {
            return left.Add(right);
        }

        public Vector<T> Substract(Vector<T> vec)
        {
            if (Dimension != vec.Dimension) throw new ArgumentException("Parameter 'v' must be in the same dimension as the current vector.");

            return new Vector<T>(Data.Select((x, i) => x - vec.Data[i]).ToArray());
        }

        public static Vector<T> operator -(Vector<T> left, Vector<T> right)
        {
            return left.Substract(right);
        }

        public Vector<T> Multiply(Scalar<T> s)
        {
            return new Vector<T>(Data.Select((x, i) => x * s).ToArray());
        }

        public static Vector<T> operator *(Vector<T> left, Scalar<T> right)
        {
            return left.Multiply(right);
        }

        public static Vector<T> operator *(Scalar<T> left, Vector<T> right)
        {
            return right.Multiply(left);
        }

        public Vector<T> Divide(Scalar<T> s)
        {
            return new Vector<T>(Data.Select((x, i) => x / s).ToArray());
        }

        public static Vector<T> operator /(Vector<T> left, Scalar<T> right)
        {
            return left.Divide(right);
        }

        public Vector<T> GetDividedBy(Scalar<T> s)
        {
            return new Vector<T>(Data.Select((x, i) => s / x).ToArray());
        }

        public static Vector<T> operator /(Scalar<T> left, Vector<T> right)
        {
            return right.GetDividedBy(left);
        }

        public Vector<T> Negate()
        {
            return new Vector<T>(Data.Select(x => -x).ToArray());
        }

        public static Vector<T> operator -(Vector<T> v)
        {
            return v.Negate();
        }

        public Vector<T> Reciprocal()
        {
            return new Vector<T>(Data.Select(x => Scalar<T>.One / x).ToArray());
        }

        #endregion

        #region Identity

        public static bool operator ==(Vector<T> left, Vector<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector<T> left, Vector<T> right)
        {
            return !left.Equals(right);
        }

        #endregion

        #endregion

        #region Implicit Conversion

        public static implicit operator Vector<T>(T[] value)
        {
            return new Vector<T>(value);
        }

        #endregion

        #region Interface Implementations

        public object Clone()
        {
            return new Vector<T>(Data);
        }

        public bool Equals(Vector<T> other)
        {
            int i = 0;
            return Data.All(x => x == other.Data[i++]);
        }

        IEnumerator<Scalar<T>> IEnumerable<Scalar<T>>.GetEnumerator()
        {
            foreach (var d in Data)
                yield return d;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var d in Data)
                yield return d.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector<T> v)
                return Equals(v);

            return false;
        }

        public override string ToString()
        {
            return $"Vector{ Dimension }({ string.Join(", ", Data) })";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}