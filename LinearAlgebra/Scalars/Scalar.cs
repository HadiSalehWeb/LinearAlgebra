﻿using System;
using LinearAlgebra.Vectors;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// This file was automatically generated by 'Scalar.tt'. Make edits to the t4 file instead of this.

/* Note
 * Scalars are supposed to be elements of a field*, but some types (int, ushort etc.) can't form 
 * fields because a) they don't have an additive inverse or b) don't have a multiplicative inverse.
 * This means a lot of run-time type checking and exception throwing and rounding might happen if they're
 * used in the wrong context (eg. the magnitude of an integer vector will be rounded).
 * 
 * Field: https://en.wikipedia.org/wiki/Field_(mathematics)
 */

namespace LinearAlgebra.Scalars
{
    public enum AlgebraicStructure
    {
        Semiring = 1,
        Ring = 3,
        Field = 7
    }

    /// <summary>
    /// This is where the magic happens.
    /// The purpose of this struct is to replicate the behaviour of a union type in C by lining up all its
    /// fields in the same memory address, since only one of them will end up being used at a time.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    struct TypedValueContainer
    {
        [FieldOffset(0)]
        public readonly System.SByte sByteValue;
        [FieldOffset(0)]
        public readonly System.Byte byteValue;
        [FieldOffset(0)]
        public readonly System.Int16 int16Value;
        [FieldOffset(0)]
        public readonly System.UInt16 uInt16Value;
        [FieldOffset(0)]
        public readonly System.Int32 int32Value;
        [FieldOffset(0)]
        public readonly System.UInt32 uInt32Value;
        [FieldOffset(0)]
        public readonly System.Int64 int64Value;
        [FieldOffset(0)]
        public readonly System.UInt64 uInt64Value;
        [FieldOffset(0)]
        public readonly System.Single singleValue;
        [FieldOffset(0)]
        public readonly System.Double doubleValue;
        [FieldOffset(0)]
        public readonly System.Decimal decimalValue;

        public TypedValueContainer(System.SByte sByteValue, System.Byte byteValue, System.Int16 int16Value, System.UInt16 uInt16Value, System.Int32 int32Value, System.UInt32 uInt32Value, System.Int64 int64Value, System.UInt64 uInt64Value, System.Single singleValue, System.Double doubleValue, System.Decimal decimalValue)
        {
            //All values must be initialized to zero at first because they're readonly, and the actual value 
            //is assigned at the very end to ensure it's not overwritten (see FieldOffsetAttribute)
            if (sByteValue != default)
            {
                this.byteValue = default;
                this.int16Value = default;
                this.uInt16Value = default;
                this.int32Value = default;
                this.uInt32Value = default;
                this.int64Value = default;
                this.uInt64Value = default;
                this.singleValue = default;
                this.doubleValue = default;
                this.decimalValue = default;
                this.sByteValue = sByteValue;
            }
            else if (byteValue != default)
            {
                this.sByteValue = default;
                this.int16Value = default;
                this.uInt16Value = default;
                this.int32Value = default;
                this.uInt32Value = default;
                this.int64Value = default;
                this.uInt64Value = default;
                this.singleValue = default;
                this.doubleValue = default;
                this.decimalValue = default;
                this.byteValue = byteValue;
            }
            else if (int16Value != default)
            {
                this.sByteValue = default;
                this.byteValue = default;
                this.uInt16Value = default;
                this.int32Value = default;
                this.uInt32Value = default;
                this.int64Value = default;
                this.uInt64Value = default;
                this.singleValue = default;
                this.doubleValue = default;
                this.decimalValue = default;
                this.int16Value = int16Value;
            }
            else if (uInt16Value != default)
            {
                this.sByteValue = default;
                this.byteValue = default;
                this.int16Value = default;
                this.int32Value = default;
                this.uInt32Value = default;
                this.int64Value = default;
                this.uInt64Value = default;
                this.singleValue = default;
                this.doubleValue = default;
                this.decimalValue = default;
                this.uInt16Value = uInt16Value;
            }
            else if (int32Value != default)
            {
                this.sByteValue = default;
                this.byteValue = default;
                this.int16Value = default;
                this.uInt16Value = default;
                this.uInt32Value = default;
                this.int64Value = default;
                this.uInt64Value = default;
                this.singleValue = default;
                this.doubleValue = default;
                this.decimalValue = default;
                this.int32Value = int32Value;
            }
            else if (uInt32Value != default)
            {
                this.sByteValue = default;
                this.byteValue = default;
                this.int16Value = default;
                this.uInt16Value = default;
                this.int32Value = default;
                this.int64Value = default;
                this.uInt64Value = default;
                this.singleValue = default;
                this.doubleValue = default;
                this.decimalValue = default;
                this.uInt32Value = uInt32Value;
            }
            else if (int64Value != default)
            {
                this.sByteValue = default;
                this.byteValue = default;
                this.int16Value = default;
                this.uInt16Value = default;
                this.int32Value = default;
                this.uInt32Value = default;
                this.uInt64Value = default;
                this.singleValue = default;
                this.doubleValue = default;
                this.decimalValue = default;
                this.int64Value = int64Value;
            }
            else if (uInt64Value != default)
            {
                this.sByteValue = default;
                this.byteValue = default;
                this.int16Value = default;
                this.uInt16Value = default;
                this.int32Value = default;
                this.uInt32Value = default;
                this.int64Value = default;
                this.singleValue = default;
                this.doubleValue = default;
                this.decimalValue = default;
                this.uInt64Value = uInt64Value;
            }
            else if (singleValue != default)
            {
                this.sByteValue = default;
                this.byteValue = default;
                this.int16Value = default;
                this.uInt16Value = default;
                this.int32Value = default;
                this.uInt32Value = default;
                this.int64Value = default;
                this.uInt64Value = default;
                this.doubleValue = default;
                this.decimalValue = default;
                this.singleValue = singleValue;
            }
            else if (doubleValue != default)
            {
                this.sByteValue = default;
                this.byteValue = default;
                this.int16Value = default;
                this.uInt16Value = default;
                this.int32Value = default;
                this.uInt32Value = default;
                this.int64Value = default;
                this.uInt64Value = default;
                this.singleValue = default;
                this.decimalValue = default;
                this.doubleValue = doubleValue;
            }
            else if (decimalValue != default)
            {
                this.sByteValue = default;
                this.byteValue = default;
                this.int16Value = default;
                this.uInt16Value = default;
                this.int32Value = default;
                this.uInt32Value = default;
                this.int64Value = default;
                this.uInt64Value = default;
                this.singleValue = default;
                this.doubleValue = default;
                this.decimalValue = decimalValue;
            }
            else
            {
                this.sByteValue = default;
                this.byteValue = default;
                this.int16Value = default;
                this.uInt16Value = default;
                this.int32Value = default;
                this.uInt32Value = default;
                this.int64Value = default;
                this.uInt64Value = default;
                this.singleValue = default;
                this.doubleValue = default;
                this.decimalValue = default;
            }
        }
    }

    /// <typeparam name="T">SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double, Decimal</typeparam>
    [Serializable]
    public struct Scalar<T> : ITensor<T, Vector0<int>, Scalar<T>>
        where T : struct
    {
        #region Type Handling

        private enum ScalarType
        {
            SByte,
            Byte,
            Int16,
            UInt16,
            Int32,
            UInt32,
            Int64,
            UInt64,
            Single,
            Double,
            Decimal
        }

        private static readonly Dictionary<Type, ScalarType> TypeMap = new Dictionary<Type, ScalarType>
        {
            { typeof(System.SByte), ScalarType.SByte },
            { typeof(System.Byte), ScalarType.Byte },
            { typeof(System.Int16), ScalarType.Int16 },
            { typeof(System.UInt16), ScalarType.UInt16 },
            { typeof(System.Int32), ScalarType.Int32 },
            { typeof(System.UInt32), ScalarType.UInt32 },
            { typeof(System.Int64), ScalarType.Int64 },
            { typeof(System.UInt64), ScalarType.UInt64 },
            { typeof(System.Single), ScalarType.Single },
            { typeof(System.Double), ScalarType.Double },
            { typeof(System.Decimal), ScalarType.Decimal }
        };

        private static readonly ScalarType scalarType;

        public static readonly AlgebraicStructure algebraicStructure;

        #endregion

        #region Fields and Properties

        public static Scalar<int> Order => Scalar<int>.Zero;
        public Vector0<int> Dimension => Vector0<int>.zero;

        private readonly TypedValueContainer tvc;

        private System.SByte SByteValue => tvc.sByteValue;
        private System.Byte ByteValue => tvc.byteValue;
        private System.Int16 Int16Value => tvc.int16Value;
        private System.UInt16 UInt16Value => tvc.uInt16Value;
        private System.Int32 Int32Value => tvc.int32Value;
        private System.UInt32 UInt32Value => tvc.uInt32Value;
        private System.Int64 Int64Value => tvc.int64Value;
        private System.UInt64 UInt64Value => tvc.uInt64Value;
        private System.Single SingleValue => tvc.singleValue;
        private System.Double DoubleValue => tvc.doubleValue;
        private System.Decimal DecimalValue => tvc.decimalValue;

        public T Value { get; }

        #endregion

        #region Static

        public static Scalar<T> Zero { get; }
        public static Scalar<T> One { get; }
        public static Scalar<T> MinValue { get; }
        public static Scalar<T> MaxValue { get; }
        public static Scalar<T> NegativeOneOrZero => algebraicStructure == AlgebraicStructure.Semiring ? Zero : -One;

        static Scalar()
        {
            if (!TypeMap.TryGetValue(typeof(T), out scalarType))
                throw new ArgumentException($"Type <{ typeof(T).Name }> not supported for scalar values.");

            switch (scalarType)
            {
                case ScalarType.SByte:
                    Zero = (sbyte)0;
                    One = (sbyte)1;
                    MinValue = (sbyte)-128;
                    MaxValue = (sbyte)127;
                    algebraicStructure = AlgebraicStructure.Ring;
                    break;
                case ScalarType.Byte:
                    Zero = (byte)0;
                    One = (byte)1;
                    MinValue = (byte)0;
                    MaxValue = (byte)255;
                    algebraicStructure = AlgebraicStructure.Semiring;
                    break;
                case ScalarType.Int16:
                    Zero = (short)0;
                    One = (short)1;
                    MinValue = (short)-32768;
                    MaxValue = (short)32767;
                    algebraicStructure = AlgebraicStructure.Ring;
                    break;
                case ScalarType.UInt16:
                    Zero = (ushort)0;
                    One = (ushort)1;
                    MinValue = (ushort)0;
                    MaxValue = (ushort)65535;
                    algebraicStructure = AlgebraicStructure.Semiring;
                    break;
                case ScalarType.Int32:
                    Zero = 0;
                    One = 1;
                    MinValue = -2147483648;
                    MaxValue = 2147483647;
                    algebraicStructure = AlgebraicStructure.Ring;
                    break;
                case ScalarType.UInt32:
                    Zero = 0u;
                    One = 1u;
                    MinValue = 0u;
                    MaxValue = 4294967295u;
                    algebraicStructure = AlgebraicStructure.Semiring;
                    break;
                case ScalarType.Int64:
                    Zero = 0L;
                    One = 1L;
                    MinValue = -9223372036854775808L;
                    MaxValue = 9223372036854775807L;
                    algebraicStructure = AlgebraicStructure.Ring;
                    break;
                case ScalarType.UInt64:
                    Zero = 0uL;
                    One = 1uL;
                    MinValue = 0uL;
                    MaxValue = 18446744073709551615uL;
                    algebraicStructure = AlgebraicStructure.Semiring;
                    break;
                case ScalarType.Single:
                    Zero = 0f;
                    One = 1f;
                    MinValue = -3.40282347E+38f;
                    MaxValue = 3.40282347E+38f;
                    algebraicStructure = AlgebraicStructure.Field;
                    break;
                case ScalarType.Double:
                    Zero = 0d;
                    One = 1d;
                    MinValue = -1.7976931348623157E+308d;
                    MaxValue = 1.7976931348623157E+308d;
                    algebraicStructure = AlgebraicStructure.Field;
                    break;
                case ScalarType.Decimal:
                    Zero = 0m;
                    One = 1m;
                    MinValue = -79228162514264337593543950335m;
                    MaxValue = 79228162514264337593543950335m;
                    algebraicStructure = AlgebraicStructure.Field;
                    break;
                default:
                    throw new ArgumentException($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        #endregion

        #region Constructors

        public Scalar(T value)
        {
            Value = value;

            if (value is System.SByte sByteValueT)
                tvc = new TypedValueContainer(sByteValueT, default, default, default, default, default, default, default, default, default, default);
            else if (value is System.Byte byteValueT)
                tvc = new TypedValueContainer(default, byteValueT, default, default, default, default, default, default, default, default, default);
            else if (value is System.Int16 int16ValueT)
                tvc = new TypedValueContainer(default, default, int16ValueT, default, default, default, default, default, default, default, default);
            else if (value is System.UInt16 uInt16ValueT)
                tvc = new TypedValueContainer(default, default, default, uInt16ValueT, default, default, default, default, default, default, default);
            else if (value is System.Int32 int32ValueT)
                tvc = new TypedValueContainer(default, default, default, default, int32ValueT, default, default, default, default, default, default);
            else if (value is System.UInt32 uInt32ValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, uInt32ValueT, default, default, default, default, default);
            else if (value is System.Int64 int64ValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, default, int64ValueT, default, default, default, default);
            else if (value is System.UInt64 uInt64ValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, default, default, uInt64ValueT, default, default, default);
            else if (value is System.Single singleValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, default, default, default, singleValueT, default, default);
            else if (value is System.Double doubleValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, default, default, default, default, doubleValueT, default);
            else if (value is System.Decimal decimalValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, default, default, default, default, default, decimalValueT);
            else
                throw new ArgumentException($"Type <{ typeof(T).Name }> not supported for scalar values.");
        }

        static Scalar<T> From<U>(U u) where U : struct
        {
            if (u is T t)
                return new Scalar<T>(t);
            if (u is IConvertible ic)
                return new Scalar<T>((T)ic.ToType(typeof(T), null));

            else throw new ArgumentException($"Type <{ typeof(U).Name }> cannot be converted to type <{ typeof(T).Name }>.");
        }

        #endregion

        #region Functions

        public Scalar<U> Cast<U>()
            where U : struct
        {
            if (Value is U u)
                return new Scalar<U>(u);
            if (Value is IConvertible ic)
                return new Scalar<U>((U)ic.ToType(typeof(U), null));

            else throw new ArgumentException($"Type <{ typeof(U).Name }> cannot be converted to type <{ typeof(T).Name }>.");
        }

        #endregion

        #region Operators

        #region Arithmetic

        public Scalar<T> Add(Scalar<T> s)
        {
            switch (scalarType)
            {
                case ScalarType.SByte:
                    return From(SByteValue + s.SByteValue);
                case ScalarType.Byte:
                    return From(ByteValue + s.ByteValue);
                case ScalarType.Int16:
                    return From(Int16Value + s.Int16Value);
                case ScalarType.UInt16:
                    return From(UInt16Value + s.UInt16Value);
                case ScalarType.Int32:
                    return From(Int32Value + s.Int32Value);
                case ScalarType.UInt32:
                    return From(UInt32Value + s.UInt32Value);
                case ScalarType.Int64:
                    return From(Int64Value + s.Int64Value);
                case ScalarType.UInt64:
                    return From(UInt64Value + s.UInt64Value);
                case ScalarType.Single:
                    return From(SingleValue + s.SingleValue);
                case ScalarType.Double:
                    return From(DoubleValue + s.DoubleValue);
                case ScalarType.Decimal:
                    return From(DecimalValue + s.DecimalValue);
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public static Scalar<T> operator +(Scalar<T> left, Scalar<T> right)
        {
            return left.Add(right);
        }

        public Scalar<T> Substract(Scalar<T> s)
        {
            switch (scalarType)
            {
                case ScalarType.SByte:
                    return From(SByteValue - s.SByteValue);
                case ScalarType.Byte:
                    return From(ByteValue - s.ByteValue);
                case ScalarType.Int16:
                    return From(Int16Value - s.Int16Value);
                case ScalarType.UInt16:
                    return From(UInt16Value - s.UInt16Value);
                case ScalarType.Int32:
                    return From(Int32Value - s.Int32Value);
                case ScalarType.UInt32:
                    return From(UInt32Value - s.UInt32Value);
                case ScalarType.Int64:
                    return From(Int64Value - s.Int64Value);
                case ScalarType.UInt64:
                    return From(UInt64Value - s.UInt64Value);
                case ScalarType.Single:
                    return From(SingleValue - s.SingleValue);
                case ScalarType.Double:
                    return From(DoubleValue - s.DoubleValue);
                case ScalarType.Decimal:
                    return From(DecimalValue - s.DecimalValue);
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public static Scalar<T> operator -(Scalar<T> left, Scalar<T> right)
        {
            return left.Substract(right);
        }

        public Scalar<T> Multiply(Scalar<T> s)
        {
            switch (scalarType)
            {
                case ScalarType.SByte:
                    return From(SByteValue * s.SByteValue);
                case ScalarType.Byte:
                    return From(ByteValue * s.ByteValue);
                case ScalarType.Int16:
                    return From(Int16Value * s.Int16Value);
                case ScalarType.UInt16:
                    return From(UInt16Value * s.UInt16Value);
                case ScalarType.Int32:
                    return From(Int32Value * s.Int32Value);
                case ScalarType.UInt32:
                    return From(UInt32Value * s.UInt32Value);
                case ScalarType.Int64:
                    return From(Int64Value * s.Int64Value);
                case ScalarType.UInt64:
                    return From(UInt64Value * s.UInt64Value);
                case ScalarType.Single:
                    return From(SingleValue * s.SingleValue);
                case ScalarType.Double:
                    return From(DoubleValue * s.DoubleValue);
                case ScalarType.Decimal:
                    return From(DecimalValue * s.DecimalValue);
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public Scalar<T> Scale(Scalar<T> s)
        {
            return Multiply(s);
        }

        public static Scalar<T> operator *(Scalar<T> left, Scalar<T> right)
        {
            return left.Multiply(right);
        }

        public Scalar<T> Divide(Scalar<T> s)
        {
            switch (scalarType)
            {
                case ScalarType.SByte:
                    return From(SByteValue / s.SByteValue);
                case ScalarType.Byte:
                    return From(ByteValue / s.ByteValue);
                case ScalarType.Int16:
                    return From(Int16Value / s.Int16Value);
                case ScalarType.UInt16:
                    return From(UInt16Value / s.UInt16Value);
                case ScalarType.Int32:
                    return From(Int32Value / s.Int32Value);
                case ScalarType.UInt32:
                    return From(UInt32Value / s.UInt32Value);
                case ScalarType.Int64:
                    return From(Int64Value / s.Int64Value);
                case ScalarType.UInt64:
                    return From(UInt64Value / s.UInt64Value);
                case ScalarType.Single:
                    return From(SingleValue / s.SingleValue);
                case ScalarType.Double:
                    return From(DoubleValue / s.DoubleValue);
                case ScalarType.Decimal:
                    return From(DecimalValue / s.DecimalValue);
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public Scalar<T> GetDividedBy(Scalar<T> s)
        {
            switch (scalarType)
            {
                case ScalarType.SByte:
                    return From(s.SByteValue / SByteValue);
                case ScalarType.Byte:
                    return From(s.ByteValue / ByteValue);
                case ScalarType.Int16:
                    return From(s.Int16Value / Int16Value);
                case ScalarType.UInt16:
                    return From(s.UInt16Value / UInt16Value);
                case ScalarType.Int32:
                    return From(s.Int32Value / Int32Value);
                case ScalarType.UInt32:
                    return From(s.UInt32Value / UInt32Value);
                case ScalarType.Int64:
                    return From(s.Int64Value / Int64Value);
                case ScalarType.UInt64:
                    return From(s.UInt64Value / UInt64Value);
                case ScalarType.Single:
                    return From(s.SingleValue / SingleValue);
                case ScalarType.Double:
                    return From(s.DoubleValue / DoubleValue);
                case ScalarType.Decimal:
                    return From(s.DecimalValue / DecimalValue);
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public Scalar<T> Reciprocal()
        {
            switch (scalarType)
            {
                case ScalarType.SByte:
                    throw new Exception("Cannot take reciprocal of type <System.SByte>.");
                case ScalarType.Byte:
                    throw new Exception("Cannot take reciprocal of type <System.Byte>.");
                case ScalarType.Int16:
                    throw new Exception("Cannot take reciprocal of type <System.Int16>.");
                case ScalarType.UInt16:
                    throw new Exception("Cannot take reciprocal of type <System.UInt16>.");
                case ScalarType.Int32:
                    throw new Exception("Cannot take reciprocal of type <System.Int32>.");
                case ScalarType.UInt32:
                    throw new Exception("Cannot take reciprocal of type <System.UInt32>.");
                case ScalarType.Int64:
                    throw new Exception("Cannot take reciprocal of type <System.Int64>.");
                case ScalarType.UInt64:
                    throw new Exception("Cannot take reciprocal of type <System.UInt64>.");
                case ScalarType.Single:
                    return From(One.Divide(SingleValue));
                case ScalarType.Double:
                    return From(One.Divide(DoubleValue));
                case ScalarType.Decimal:
                    return From(One.Divide(DecimalValue));
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public static Scalar<T> operator /(Scalar<T> left, Scalar<T> right)
        {
            return left.Divide(right);
        }

        public Scalar<T> Negate()
        {
            switch (scalarType)
            {
                case ScalarType.SByte:
                    return From(-SByteValue);
                case ScalarType.Byte:
                    throw new Exception("Type <System.Byte> cannot be negated.");
                case ScalarType.Int16:
                    return From(-Int16Value);
                case ScalarType.UInt16:
                    throw new Exception("Type <System.UInt16> cannot be negated.");
                case ScalarType.Int32:
                    return From(-Int32Value);
                case ScalarType.UInt32:
                    throw new Exception("Type <System.UInt32> cannot be negated.");
                case ScalarType.Int64:
                    return From(-Int64Value);
                case ScalarType.UInt64:
                    throw new Exception("Type <System.UInt64> cannot be negated.");
                case ScalarType.Single:
                    return From(-SingleValue);
                case ScalarType.Double:
                    return From(-DoubleValue);
                case ScalarType.Decimal:
                    return From(-DecimalValue);
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public static Scalar<T> operator -(Scalar<T> t)
        {
            return t.Negate();
        }

        public static Scalar<T> operator %(Scalar<T> left, Scalar<T> right)
        {
            switch (scalarType)
            {
                case ScalarType.SByte:
                    return From(left.SByteValue % right.SByteValue);
                case ScalarType.Byte:
                    return From(left.ByteValue % right.ByteValue);
                case ScalarType.Int16:
                    return From(left.Int16Value % right.Int16Value);
                case ScalarType.UInt16:
                    return From(left.UInt16Value % right.UInt16Value);
                case ScalarType.Int32:
                    return From(left.Int32Value % right.Int32Value);
                case ScalarType.UInt32:
                    return From(left.UInt32Value % right.UInt32Value);
                case ScalarType.Int64:
                    return From(left.Int64Value % right.Int64Value);
                case ScalarType.UInt64:
                    return From(left.UInt64Value % right.UInt64Value);
                case ScalarType.Single:
                    return From(left.SingleValue % right.SingleValue);
                case ScalarType.Double:
                    return From(left.DoubleValue % right.DoubleValue);
                case ScalarType.Decimal:
                    return From(left.DecimalValue % right.DecimalValue);
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        #endregion

        #region Identity and Order

        public static bool operator ==(Scalar<T> left, Scalar<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Scalar<T> left, Scalar<T> right)
        {
            return !left.Equals(right);
        }

        public static bool operator <(Scalar<T> left, Scalar<T> right)
        {
            switch (scalarType)
            {
                case ScalarType.SByte:
                    return left.SByteValue.CompareTo(right.SByteValue) < 0;
                case ScalarType.Byte:
                    return left.ByteValue.CompareTo(right.ByteValue) < 0;
                case ScalarType.Int16:
                    return left.Int16Value.CompareTo(right.Int16Value) < 0;
                case ScalarType.UInt16:
                    return left.UInt16Value.CompareTo(right.UInt16Value) < 0;
                case ScalarType.Int32:
                    return left.Int32Value.CompareTo(right.Int32Value) < 0;
                case ScalarType.UInt32:
                    return left.UInt32Value.CompareTo(right.UInt32Value) < 0;
                case ScalarType.Int64:
                    return left.Int64Value.CompareTo(right.Int64Value) < 0;
                case ScalarType.UInt64:
                    return left.UInt64Value.CompareTo(right.UInt64Value) < 0;
                case ScalarType.Single:
                    return left.SingleValue.CompareTo(right.SingleValue) < 0;
                case ScalarType.Double:
                    return left.DoubleValue.CompareTo(right.DoubleValue) < 0;
                case ScalarType.Decimal:
                    return left.DecimalValue.CompareTo(right.DecimalValue) < 0;
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public static bool operator >(Scalar<T> left, Scalar<T> right)
        {
            switch (scalarType)
            {
                case ScalarType.SByte:
                    return left.SByteValue.CompareTo(right.SByteValue) > 0;
                case ScalarType.Byte:
                    return left.ByteValue.CompareTo(right.ByteValue) > 0;
                case ScalarType.Int16:
                    return left.Int16Value.CompareTo(right.Int16Value) > 0;
                case ScalarType.UInt16:
                    return left.UInt16Value.CompareTo(right.UInt16Value) > 0;
                case ScalarType.Int32:
                    return left.Int32Value.CompareTo(right.Int32Value) > 0;
                case ScalarType.UInt32:
                    return left.UInt32Value.CompareTo(right.UInt32Value) > 0;
                case ScalarType.Int64:
                    return left.Int64Value.CompareTo(right.Int64Value) > 0;
                case ScalarType.UInt64:
                    return left.UInt64Value.CompareTo(right.UInt64Value) > 0;
                case ScalarType.Single:
                    return left.SingleValue.CompareTo(right.SingleValue) > 0;
                case ScalarType.Double:
                    return left.DoubleValue.CompareTo(right.DoubleValue) > 0;
                case ScalarType.Decimal:
                    return left.DecimalValue.CompareTo(right.DecimalValue) > 0;
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public static bool operator <=(Scalar<T> left, Scalar<T> right)
        {
            return (left < right) || (left == right);
        }

        public static bool operator >=(Scalar<T> left, Scalar<T> right)
        {
            return (left > right) || (left == right);
        }

        #endregion

        #endregion

        #region Implicit Conversion

        public static implicit operator Scalar<T>(System.SByte value)
        {
            return From(value);
        }
        public static implicit operator System.SByte(Scalar<T> value)
        {
            if (scalarType == ScalarType.SByte)
                return value.SByteValue;
            return value.Cast<System.SByte>().Value;
        }

        public static implicit operator Scalar<T>(System.Byte value)
        {
            return From(value);
        }
        public static implicit operator System.Byte(Scalar<T> value)
        {
            if (scalarType == ScalarType.Byte)
                return value.ByteValue;
            return value.Cast<System.Byte>().Value;
        }

        public static implicit operator Scalar<T>(System.Int16 value)
        {
            return From(value);
        }
        public static implicit operator System.Int16(Scalar<T> value)
        {
            if (scalarType == ScalarType.Int16)
                return value.Int16Value;
            return value.Cast<System.Int16>().Value;
        }

        public static implicit operator Scalar<T>(System.UInt16 value)
        {
            return From(value);
        }
        public static implicit operator System.UInt16(Scalar<T> value)
        {
            if (scalarType == ScalarType.UInt16)
                return value.UInt16Value;
            return value.Cast<System.UInt16>().Value;
        }

        public static implicit operator Scalar<T>(System.Int32 value)
        {
            return From(value);
        }
        public static implicit operator System.Int32(Scalar<T> value)
        {
            if (scalarType == ScalarType.Int32)
                return value.Int32Value;
            return value.Cast<System.Int32>().Value;
        }

        public static implicit operator Scalar<T>(System.UInt32 value)
        {
            return From(value);
        }
        public static implicit operator System.UInt32(Scalar<T> value)
        {
            if (scalarType == ScalarType.UInt32)
                return value.UInt32Value;
            return value.Cast<System.UInt32>().Value;
        }

        public static implicit operator Scalar<T>(System.Int64 value)
        {
            return From(value);
        }
        public static implicit operator System.Int64(Scalar<T> value)
        {
            if (scalarType == ScalarType.Int64)
                return value.Int64Value;
            return value.Cast<System.Int64>().Value;
        }

        public static implicit operator Scalar<T>(System.UInt64 value)
        {
            return From(value);
        }
        public static implicit operator System.UInt64(Scalar<T> value)
        {
            if (scalarType == ScalarType.UInt64)
                return value.UInt64Value;
            return value.Cast<System.UInt64>().Value;
        }

        public static implicit operator Scalar<T>(System.Single value)
        {
            return From(value);
        }
        public static implicit operator System.Single(Scalar<T> value)
        {
            if (scalarType == ScalarType.Single)
                return value.SingleValue;
            return value.Cast<System.Single>().Value;
        }

        public static implicit operator Scalar<T>(System.Double value)
        {
            return From(value);
        }
        public static implicit operator System.Double(Scalar<T> value)
        {
            if (scalarType == ScalarType.Double)
                return value.DoubleValue;
            return value.Cast<System.Double>().Value;
        }

        public static implicit operator Scalar<T>(System.Decimal value)
        {
            return From(value);
        }
        public static implicit operator System.Decimal(Scalar<T> value)
        {
            if (scalarType == ScalarType.Decimal)
                return value.DecimalValue;
            return value.Cast<System.Decimal>().Value;
        }

        #endregion

        #region Interface Implementations

        public override string ToString()
        {
            return Value.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Scalar<T> sc)
                return Value.Equals(sc.Value);
            if (obj is T t)
                return Value.Equals(t);

            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public object Clone()
        {
            return new Scalar<T>(Value);
        }

        public bool Equals(Scalar<T> other)
        {
            return Value.Equals(other.Value);
        }

        #endregion
    }
}
