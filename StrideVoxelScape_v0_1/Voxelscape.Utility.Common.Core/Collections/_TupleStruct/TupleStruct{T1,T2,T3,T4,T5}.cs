﻿using System;
using Voxelscape.Utility.Common.Core.Hashing;
using Voxelscape.Utility.Common.Core.Types;
using HashCode = Voxelscape.Utility.Common.Core.Hashing.HashCode;

namespace Voxelscape.Utility.Common.Core.Collections
{
	/// <summary>
	/// Represents an 8-tuple, or octuple.
	/// </summary>
	/// <typeparam name="T1">The type of the first value.</typeparam>
	/// <typeparam name="T2">The type of the second value.</typeparam>
	/// <typeparam name="T3">The type of the third value.</typeparam>
	/// <typeparam name="T4">The type of the forth value.</typeparam>
	/// <typeparam name="T5">The type of the fifth value.</typeparam>
	public struct TupleStruct<T1, T2, T3, T4, T5> : IEquatable<TupleStruct<T1, T2, T3, T4, T5>>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TupleStruct{T1,T2,T3,T4,T5}"/> struct.
		/// </summary>
		/// <param name="item1">The first value.</param>
		/// <param name="item2">The second value.</param>
		/// <param name="item3">The third value.</param>
		/// <param name="item4">The forth value.</param>
		/// <param name="item5">The fifth value.</param>
		public TupleStruct(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
		}

		#region Properties

		/// <summary>
		/// Gets the first value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		public T1 Item1 { get; }

		/// <summary>
		/// Gets the second value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		public T2 Item2 { get; }

		/// <summary>
		/// Gets the third value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		public T3 Item3 { get; }

		/// <summary>
		/// Gets the forth value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		public T4 Item4 { get; }

		/// <summary>
		/// Gets the fifth value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		public T5 Item5 { get; }

		#endregion

		#region Equality Operators

		public static bool operator ==(
			TupleStruct<T1, T2, T3, T4, T5> lhs, TupleStruct<T1, T2, T3, T4, T5> rhs) => lhs.Equals(rhs);

		public static bool operator !=(
			TupleStruct<T1, T2, T3, T4, T5> lhs, TupleStruct<T1, T2, T3, T4, T5> rhs) => !lhs.Equals(rhs);

		#endregion

		#region IEquatable<TupleStruct<T1, T2, T3, T4, T5>> Members

		/// <inheritdoc />
		public bool Equals(TupleStruct<T1, T2, T3, T4, T5> other) =>
			this.Item1.EqualsNullSafe(other.Item1) &&
			this.Item2.EqualsNullSafe(other.Item2) &&
			this.Item3.EqualsNullSafe(other.Item3) &&
			this.Item4.EqualsNullSafe(other.Item4) &&
			this.Item5.EqualsNullSafe(other.Item5);

		#endregion

		#region Object Overrides

		/// <inheritdoc />
		public override bool Equals(object obj) => StructUtilities.Equals(this, obj);

		/// <inheritdoc />
		public override int GetHashCode() => HashCode.Start
			.And(this.Item1).And(this.Item2).And(this.Item3).And(this.Item4).And(this.Item5);

		/// <inheritdoc />
		public override string ToString() => string.Format(
			"({0}, {1}, {2}, {3}, {4})",
			this.Item1.ToStringNullSafe(),
			this.Item2.ToStringNullSafe(),
			this.Item3.ToStringNullSafe(),
			this.Item4.ToStringNullSafe(),
			this.Item5.ToStringNullSafe());

		#endregion
	}
}
