namespace VP.DotNet.Assist.Extensions;

using System;

public static class NumericExtension
{
	#region Byte Extensions
	/// <summary>
	/// Checks if the <paramref name="b8"/> is EVEN
	/// </summary>
	/// <param name="b8">The <see cref="Byte"/></param>
	/// <returns></returns>
	public static Boolean IsEven(this SByte b8) => (b8 & 1) == 0;

	/// <summary>
	/// Checks if the <paramref name="b8"/> is ODD
	/// </summary>
	/// <param name="b8">The <see cref="Byte"/></param>
	/// <returns></returns>
	public static Boolean IsOdd(this SByte b8) => (b8 & 1) == 1;

	/// <summary>
	/// Checks if the <paramref name="b8"/> is less than 0
	/// </summary>
	/// <param name="b8">The <see cref="Byte"/></param>
	/// <returns></returns>
	public static Boolean IsNegative(this SByte b8) => b8 < 0;

	/// <summary>
	/// Checks if the <paramref name="b8"/> is greater than 0
	/// </summary>
	/// <param name="b8">The <see cref="Byte"/></param>
	/// <returns></returns>
	public static Boolean IsPositive(this SByte b8) => b8 > 0;

	/// <summary>
	/// Checks if the <paramref name="b8"/> is 0
	/// </summary>
	/// <param name="b8">The <see cref="Byte"/></param>
	/// <returns></returns>
	public static Boolean IsZero(this SByte b8) => b8 == 0;
	#endregion Byte Extensions

	#region Int16 Extensions
	/// <summary>
	/// Checks if the Int16 is EVEN
	/// </summary>
	/// <param name="i16">The <see cref="Int16"/></param>
	/// <returns></returns>
	public static Boolean IsEven(this Int16 i16) => (i16 & 1) == 0;

	/// <summary>
	/// Checks if the Int16 is ODD
	/// </summary>
	/// <param name="i16">The <see cref="Int16"/></param>
	/// <returns></returns>
	public static Boolean IsOdd(this Int16 i16) => (i16 & 1) == 1;

	/// <summary>
	/// Checks if the Int16 is less than 0
	/// </summary>
	/// <param name="i16">The <see cref="Int16"/></param>
	/// <returns></returns>
	public static Boolean IsNegative(this Int16 i16) => i16 < 0;

	/// <summary>
	/// Checks if the Int16 is greater than 0
	/// </summary>
	/// <param name="i16">The <see cref="Int16"/></param>
	/// <returns></returns>
	public static Boolean IsPositive(this Int16 i16) => i16 > 0;

	/// <summary>
	/// Checks if the Int16 is 0
	/// </summary>
	/// <param name="i16">The <see cref="Int16"/></param>
	/// <returns></returns>
	public static Boolean IsZero(this Int16 i16) => i16 == 0;
	#endregion Int16 Extensions

	#region Int32 Extensions
	/// <summary>
	/// Checks if the Int32 is EVEN
	/// </summary>
	/// <param name="i32">The <see cref="Int32"/></param>
	/// <returns></returns>
	public static Boolean IsEven(this Int32 i32) => (i32 & 1) == 0;

	/// <summary>
	/// Checks if the Int32 is ODD
	/// </summary>
	/// <param name="i32">The <see cref="Int32"/></param>
	/// <returns></returns>
	public static Boolean IsOdd(this Int32 i32) => (i32 & 1) == 1;

	/// <summary>
	/// Checks if the Int32 is less than 0
	/// </summary>
	/// <param name="i32">The <see cref="Int32"/></param>
	/// <returns></returns>
	public static Boolean IsNegative(this Int32 i32) => i32 < 0;

	/// <summary>
	/// Checks if the Int32 is greater than 0
	/// </summary>
	/// <param name="i32">The <see cref="Int32"/></param>
	/// <returns></returns>
	public static Boolean IsPositive(this Int32 i32) => i32 > 0;

	/// <summary>
	/// Checks if the Int32 is 0
	/// </summary>
	/// <param name="i32">The <see cref="Int32"/></param>
	/// <returns></returns>
	public static Boolean IsZero(this Int32 i32) => i32 == 0;
	#endregion Int32 Extensions

	#region Int64 Extensions
	/// <summary>
	/// Checks if the Int64 is EVEN
	/// </summary>
	/// <param name="i64">The <see cref="Int64"/></param>
	/// <returns></returns>
	public static Boolean IsEven(this Int64 i64) => (i64 & 1) == 0;

	/// <summary>
	/// Checks if the Int64 is ODD
	/// </summary>
	/// <param name="i64">The <see cref="Int64"/></param>
	/// <returns></returns>
	public static Boolean IsOdd(this Int64 i64) => (i64 & 1) == 1;

	/// <summary>
	/// Checks if the Int64 is less than 0
	/// </summary>
	/// <param name="i64">The <see cref="Int64"/></param>
	/// <returns></returns>
	public static Boolean IsNegative(this Int64 i64) => i64 < 0;

	/// <summary>
	/// Checks if the Int64 is greater than 0
	/// </summary>
	/// <param name="i64">The <see cref="Int64"/></param>
	/// <returns></returns>
	public static Boolean IsPositive(this Int64 i64) => i64 > 0;

	/// <summary>
	/// Checks if the Int64 is 0
	/// </summary>
	/// <param name="i64">The <see cref="Int64"/></param>
	/// <returns></returns>
	public static Boolean IsZero(this Int64 i64) => i64 == 0;
	#endregion Int64 Extensions
}
