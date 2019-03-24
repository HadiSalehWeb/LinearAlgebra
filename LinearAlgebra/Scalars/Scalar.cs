﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LinearAlgebra.Scalars
{
    [StructLayout(LayoutKind.Explicit)]
    struct TypedValueContainer
    {
        [FieldOffset(0)]
        public readonly System.Boolean booleanValue;
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

        public TypedValueContainer(System.Boolean booleanValue, System.SByte sByteValue, System.Byte byteValue, System.Int16 int16Value, System.UInt16 uInt16Value, System.Int32 int32Value, System.UInt32 uInt32Value, System.Int64 int64Value, System.UInt64 uInt64Value, System.Single singleValue, System.Double doubleValue, System.Decimal decimalValue)
        {
            if (booleanValue != default)
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
                this.booleanValue = booleanValue;
            }
            else if (sByteValue != default)
            {
                this.booleanValue = default;
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
                this.booleanValue = default;
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
                this.booleanValue = default;
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
                this.booleanValue = default;
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
                this.booleanValue = default;
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
                this.booleanValue = default;
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
                this.booleanValue = default;
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
                this.booleanValue = default;
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
                this.booleanValue = default;
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
                this.booleanValue = default;
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
                this.booleanValue = default;
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
                this.booleanValue = default;
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

    public struct Scalar<T> : ICloneable, IEquatable<Scalar<T>>, IComparable, IComparable<T>, IComparable<Scalar<T>>
        where T : struct, IComparable
    {
        private enum ScalarType
        {
            Boolean,
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

        private static Dictionary<Type, ScalarType> TypeMap = new Dictionary<Type, ScalarType>
        {
            { typeof(System.Boolean), ScalarType.Boolean },
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

        private readonly TypedValueContainer tvc;

        private System.Boolean BooleanValue => tvc.booleanValue;
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

        public static Scalar<T> Zero { get; }
        public static Scalar<T> One { get; }

        static Scalar()
        {
            if (!TypeMap.TryGetValue(typeof(T), out scalarType))
                throw new ArgumentException($"Type <{ typeof(T).Name }> not supported for scalar values.");

            switch (scalarType)
            {
                case ScalarType.Boolean:
                    Zero = false;
                    One = true;
                    break;
                case ScalarType.SByte:
                    Zero = (sbyte)0;
                    One = (sbyte)1;
                    break;
                case ScalarType.Byte:
                    Zero = (byte)0;
                    One = (byte)1;
                    break;
                case ScalarType.Int16:
                    Zero = (short)0;
                    One = (short)1;
                    break;
                case ScalarType.UInt16:
                    Zero = (ushort)0;
                    One = (ushort)1;
                    break;
                case ScalarType.Int32:
                    Zero = 0;
                    One = 1;
                    break;
                case ScalarType.UInt32:
                    Zero = 0u;
                    One = 1u;
                    break;
                case ScalarType.Int64:
                    Zero = 0L;
                    One = 1L;
                    break;
                case ScalarType.UInt64:
                    Zero = 0uL;
                    One = 1uL;
                    break;
                case ScalarType.Single:
                    Zero = 0f;
                    One = 1f;
                    break;
                case ScalarType.Double:
                    Zero = 0d;
                    One = 1d;
                    break;
                case ScalarType.Decimal:
                    Zero = 0m;
                    One = 1m;
                    break;
                default:
                    throw new ArgumentException($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public Scalar(T value)
        {
            Value = value;

            if (value is System.Boolean booleanValueT)
                tvc = new TypedValueContainer(booleanValueT, default, default, default, default, default, default, default, default, default, default, default);
            else if (value is System.SByte sByteValueT)
                tvc = new TypedValueContainer(default, sByteValueT, default, default, default, default, default, default, default, default, default, default);
            else if (value is System.Byte byteValueT)
                tvc = new TypedValueContainer(default, default, byteValueT, default, default, default, default, default, default, default, default, default);
            else if (value is System.Int16 int16ValueT)
                tvc = new TypedValueContainer(default, default, default, int16ValueT, default, default, default, default, default, default, default, default);
            else if (value is System.UInt16 uInt16ValueT)
                tvc = new TypedValueContainer(default, default, default, default, uInt16ValueT, default, default, default, default, default, default, default);
            else if (value is System.Int32 int32ValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, int32ValueT, default, default, default, default, default, default);
            else if (value is System.UInt32 uInt32ValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, default, uInt32ValueT, default, default, default, default, default);
            else if (value is System.Int64 int64ValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, default, default, int64ValueT, default, default, default, default);
            else if (value is System.UInt64 uInt64ValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, default, default, default, uInt64ValueT, default, default, default);
            else if (value is System.Single singleValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, default, default, default, default, singleValueT, default, default);
            else if (value is System.Double doubleValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, default, default, default, default, default, doubleValueT, default);
            else if (value is System.Decimal decimalValueT)
                tvc = new TypedValueContainer(default, default, default, default, default, default, default, default, default, default, default, decimalValueT);
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

        public static Scalar<T> operator +(Scalar<T> t1, Scalar<T> t2)
        {
            switch (scalarType)
            {
                case ScalarType.Boolean:
                    return From(t1.BooleanValue || t2.BooleanValue);
                case ScalarType.SByte:
                    return From(t1.SByteValue + t2.SByteValue);
                case ScalarType.Byte:
                    return From(t1.ByteValue + t2.ByteValue);
                case ScalarType.Int16:
                    return From(t1.Int16Value + t2.Int16Value);
                case ScalarType.UInt16:
                    return From(t1.UInt16Value + t2.UInt16Value);
                case ScalarType.Int32:
                    return From(t1.Int32Value + t2.Int32Value);
                case ScalarType.UInt32:
                    return From(t1.UInt32Value + t2.UInt32Value);
                case ScalarType.Int64:
                    return From(t1.Int64Value + t2.Int64Value);
                case ScalarType.UInt64:
                    return From(t1.UInt64Value + t2.UInt64Value);
                case ScalarType.Single:
                    return From(t1.SingleValue + t2.SingleValue);
                case ScalarType.Double:
                    return From(t1.DoubleValue + t2.DoubleValue);
                case ScalarType.Decimal:
                    return From(t1.DecimalValue + t2.DecimalValue);
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public static Scalar<T> operator -(Scalar<T> t1, Scalar<T> t2)
        {
            switch (scalarType)
            {
                case ScalarType.Boolean:
                    throw new Exception($"Substraction can't be performed on type System.Boolean.");
                case ScalarType.SByte:
                    return From(t1.SByteValue - t2.SByteValue);
                case ScalarType.Byte:
                    return From(t1.ByteValue - t2.ByteValue);
                case ScalarType.Int16:
                    return From(t1.Int16Value - t2.Int16Value);
                case ScalarType.UInt16:
                    return From(t1.UInt16Value - t2.UInt16Value);
                case ScalarType.Int32:
                    return From(t1.Int32Value - t2.Int32Value);
                case ScalarType.UInt32:
                    return From(t1.UInt32Value - t2.UInt32Value);
                case ScalarType.Int64:
                    return From(t1.Int64Value - t2.Int64Value);
                case ScalarType.UInt64:
                    return From(t1.UInt64Value - t2.UInt64Value);
                case ScalarType.Single:
                    return From(t1.SingleValue - t2.SingleValue);
                case ScalarType.Double:
                    return From(t1.DoubleValue - t2.DoubleValue);
                case ScalarType.Decimal:
                    return From(t1.DecimalValue - t2.DecimalValue);
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public static Scalar<T> operator *(Scalar<T> t1, Scalar<T> t2)
        {
            switch (scalarType)
            {
                case ScalarType.Boolean:
                    return From(t1.BooleanValue && t2.BooleanValue);
                case ScalarType.SByte:
                    return From(t1.SByteValue * t2.SByteValue);
                case ScalarType.Byte:
                    return From(t1.ByteValue * t2.ByteValue);
                case ScalarType.Int16:
                    return From(t1.Int16Value * t2.Int16Value);
                case ScalarType.UInt16:
                    return From(t1.UInt16Value * t2.UInt16Value);
                case ScalarType.Int32:
                    return From(t1.Int32Value * t2.Int32Value);
                case ScalarType.UInt32:
                    return From(t1.UInt32Value * t2.UInt32Value);
                case ScalarType.Int64:
                    return From(t1.Int64Value * t2.Int64Value);
                case ScalarType.UInt64:
                    return From(t1.UInt64Value * t2.UInt64Value);
                case ScalarType.Single:
                    return From(t1.SingleValue * t2.SingleValue);
                case ScalarType.Double:
                    return From(t1.DoubleValue * t2.DoubleValue);
                case ScalarType.Decimal:
                    return From(t1.DecimalValue * t2.DecimalValue);
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public static Scalar<T> operator /(Scalar<T> t1, Scalar<T> t2)
        {
            switch (scalarType)
            {
                case ScalarType.Boolean:
                    throw new Exception($"Division can't be performed on type System.Boolean.");
                case ScalarType.SByte:
                    return From(t1.SByteValue / t2.SByteValue);
                case ScalarType.Byte:
                    return From(t1.ByteValue / t2.ByteValue);
                case ScalarType.Int16:
                    return From(t1.Int16Value / t2.Int16Value);
                case ScalarType.UInt16:
                    return From(t1.UInt16Value / t2.UInt16Value);
                case ScalarType.Int32:
                    return From(t1.Int32Value / t2.Int32Value);
                case ScalarType.UInt32:
                    return From(t1.UInt32Value / t2.UInt32Value);
                case ScalarType.Int64:
                    return From(t1.Int64Value / t2.Int64Value);
                case ScalarType.UInt64:
                    return From(t1.UInt64Value / t2.UInt64Value);
                case ScalarType.Single:
                    return From(t1.SingleValue / t2.SingleValue);
                case ScalarType.Double:
                    return From(t1.DoubleValue / t2.DoubleValue);
                case ScalarType.Decimal:
                    return From(t1.DecimalValue / t2.DecimalValue);
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public static Scalar<T> operator -(Scalar<T> t)
        {
            switch (scalarType)
            {
                case ScalarType.Boolean:
                    throw new Exception("Type <System.Boolean> cannot be negated.");
                case ScalarType.SByte:
                    return From(-t.SByteValue);
                case ScalarType.Byte:
                    throw new Exception("Type <System.Byte> cannot be negated.");
                case ScalarType.Int16:
                    return From(-t.Int16Value);
                case ScalarType.UInt16:
                    throw new Exception("Type <System.UInt16> cannot be negated.");
                case ScalarType.Int32:
                    return From(-t.Int32Value);
                case ScalarType.UInt32:
                    throw new Exception("Type <System.UInt32> cannot be negated.");
                case ScalarType.Int64:
                    return From(-t.Int64Value);
                case ScalarType.UInt64:
                    throw new Exception("Type <System.UInt64> cannot be negated.");
                case ScalarType.Single:
                    return From(-t.SingleValue);
                case ScalarType.Double:
                    return From(-t.DoubleValue);
                case ScalarType.Decimal:
                    return From(-t.DecimalValue);
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

        public static Scalar<T> operator ~(Scalar<T> t)
        {
            switch (scalarType)
            {
                case ScalarType.Boolean:
                    return From(!t.BooleanValue);
                case ScalarType.SByte:
                    return From(~t.SByteValue);
                case ScalarType.Byte:
                    return From(~t.ByteValue);
                case ScalarType.Int16:
                    return From(~t.Int16Value);
                case ScalarType.UInt16:
                    return From(~t.UInt16Value);
                case ScalarType.Int32:
                    return From(~t.Int32Value);
                case ScalarType.UInt32:
                    return From(~t.UInt32Value);
                case ScalarType.Int64:
                    return From(~t.Int64Value);
                case ScalarType.UInt64:
                    return From(~t.UInt64Value);
                case ScalarType.Single:
                    throw new Exception("Bitwise complement cannot be performed on type System.Single.");
                case ScalarType.Double:
                    throw new Exception("Bitwise complement cannot be performed on type System.Double.");
                case ScalarType.Decimal:
                    throw new Exception("Bitwise complement cannot be performed on type System.Decimal.");
                default:
                    throw new Exception($"Unrecognized scalar type <{ scalarType }>");
            }
        }

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
            return left.CompareTo(right) < 0;
        }
        public static bool operator >(Scalar<T> left, Scalar<T> right)
        {
            return left.CompareTo(right) > 0;
        }
        public static bool operator <=(Scalar<T> left, Scalar<T> right)
        {
            return (left < right) || (left == right);
        }
        public static bool operator >=(Scalar<T> left, Scalar<T> right)
        {
            return (left > right) || (left == right);
        }

        public static implicit operator Scalar<T>(System.Boolean value)
        {
            return From(value);
        }
        public static implicit operator System.Boolean(Scalar<T> value)
        {
            return value.BooleanValue;
        }

        public static implicit operator Scalar<T>(System.SByte value)
        {
            return From(value);
        }
        public static implicit operator System.SByte(Scalar<T> value)
        {
            return value.SByteValue;
        }

        public static implicit operator Scalar<T>(System.Byte value)
        {
            return From(value);
        }
        public static implicit operator System.Byte(Scalar<T> value)
        {
            return value.ByteValue;
        }

        public static implicit operator Scalar<T>(System.Int16 value)
        {
            return From(value);
        }
        public static implicit operator System.Int16(Scalar<T> value)
        {
            return value.Int16Value;
        }

        public static implicit operator Scalar<T>(System.UInt16 value)
        {
            return From(value);
        }
        public static implicit operator System.UInt16(Scalar<T> value)
        {
            return value.UInt16Value;
        }

        public static implicit operator Scalar<T>(System.Int32 value)
        {
            return From(value);
        }
        public static implicit operator System.Int32(Scalar<T> value)
        {
            return value.Int32Value;
        }

        public static implicit operator Scalar<T>(System.UInt32 value)
        {
            return From(value);
        }
        public static implicit operator System.UInt32(Scalar<T> value)
        {
            return value.UInt32Value;
        }

        public static implicit operator Scalar<T>(System.Int64 value)
        {
            return From(value);
        }
        public static implicit operator System.Int64(Scalar<T> value)
        {
            return value.Int64Value;
        }

        public static implicit operator Scalar<T>(System.UInt64 value)
        {
            return From(value);
        }
        public static implicit operator System.UInt64(Scalar<T> value)
        {
            return value.UInt64Value;
        }

        public static implicit operator Scalar<T>(System.Single value)
        {
            return From(value);
        }
        public static implicit operator System.Single(Scalar<T> value)
        {
            return value.SingleValue;
        }

        public static implicit operator Scalar<T>(System.Double value)
        {
            return From(value);
        }
        public static implicit operator System.Double(Scalar<T> value)
        {
            return value.DoubleValue;
        }

        public static implicit operator Scalar<T>(System.Decimal value)
        {
            return From(value);
        }
        public static implicit operator System.Decimal(Scalar<T> value)
        {
            return value.DecimalValue;
        }

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

        public int CompareTo(object obj)
        {
            if (obj is Scalar<T> sc)
                return sc.Value.CompareTo(Value);
            if (obj is T t)
                return t.CompareTo(Value);

            throw new Exception($"Cannot compare type <{ obj.GetType().Name }> to  Scalar<{ typeof(T).Name }>");
        }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }

        public int CompareTo(Scalar<T> other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}