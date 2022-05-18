namespace VP.DotNet.Assist.Extensions;

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// IComparableExtension class. See - https://docs.microsoft.com/en-us/dotnet/api/system.icomparable-1?view=net-6.0
/// Uses 'CompareTo(T)' for comparison
/// </summary>
public static class IComparableExtension
{
	/// <summary>
	/// Checks if <paramref name="left"/> operand is equal to <paramref name="right"/> operand.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	/// <param name="left">The <paramref name="left"/></param>
	/// <param name="right">The <paramref name="right"/></param>
	/// <returns>True if <paramref name="left"/> is equal to <paramref name="right"/>, false otherwise.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public static Boolean IsEqualTo<T>(this T left, T right)
		where T : IComparable<T>
	{
		ArgumentNullException.ThrowIfNull(left, nameof(left));
		ArgumentNullException.ThrowIfNull(right, nameof(right));

		return left.CompareTo(right) == 0;
	}

	/// <summary>
	/// Checks if the <paramref name="left"/> is greater than <paramref name="right"/>.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	/// <param name="left">The <paramref name="left"/></param>
	/// <param name="right">The <paramref name="right"/></param>
	/// <returns>True if <paramref name="left"/> is greater than <paramref name="right"/>, false otherwise.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public static Boolean IsGreaterThan<T>(this T left, T right)
		where T : IComparable<T>
	{
		ArgumentNullException.ThrowIfNull(left, nameof(left));
		ArgumentNullException.ThrowIfNull(right, nameof(right));

		return left.CompareTo(right) > 0;
	}

	/// <summary>
	/// Checks if the <paramref name="left"/> is greater than or equal to<paramref name="right"/>.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	/// <param name="left">The <paramref name="left"/></param>
	/// <param name="right">The <paramref name="right"/></param>
	/// <returns>True if <paramref name="left"/> is greater than or equal to <paramref name="right"/>, false otherwise.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public static Boolean IsGreaterThanEqualTo<T>(this T left, T right)
		where T : IComparable<T>
	{
		ArgumentNullException.ThrowIfNull(left, nameof(left));
		ArgumentNullException.ThrowIfNull(right, nameof(right));

		return left.IsGreaterThan(right) || left.IsEqualTo(right);
	}

	/// <summary>
	/// Checks if the <paramref name="left"/> is less than <paramref name="right"/>.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	/// <param name="left">The <paramref name="left"/></param>
	/// <param name="right">The <paramref name="right"/></param>
	/// <returns>True if <paramref name="left"/> is less than <paramref name="right"/>, false otherwise.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public static Boolean IsLessThan<T>([NotNull] this T left, [NotNull] T right)
		where T : IComparable<T>
	{
		ArgumentNullException.ThrowIfNull(left, nameof(left));
		ArgumentNullException.ThrowIfNull(right, nameof(right));

		return left.CompareTo(right) < 0;
	}

	/// <summary>
	/// Checks if the <paramref name="left"/> is less than equal to <paramref name="right"/>.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	/// <param name="left">The <paramref name="left"/></param>
	/// <param name="right">The <paramref name="right"/></param>
	/// <returns>True if <paramref name="left"/> is less than equal to <paramref name="right"/>, false otherwise.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public static Boolean IsLessThanEqualTo<T>(this T left, T right)
		where T : IComparable<T>
	{
		ArgumentNullException.ThrowIfNull(left, nameof(left));
		ArgumentNullException.ThrowIfNull(right, nameof(right));

		return left.IsLessThan(right) || left.IsEqualTo(right);
	}

	/// <summary>
	/// Checks if item exists between <paramref name="low"/> and <paramref name="high"/>, both inclusive.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	/// <param name="item">The item</param>
	/// <param name="low">The start value of the range.</param>
	/// <param name="high">The end value of the range.</param>
	/// <returns>True if item exists between <paramref name="low"/> and <paramref name="high"/>.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public static Boolean IsWithinRange<T>(this T item, T low, T high)
		where T : IComparable<T>
	{
		ArgumentNullException.ThrowIfNull(item, nameof(item));
		ArgumentNullException.ThrowIfNull(low, nameof(low));
		ArgumentNullException.ThrowIfNull(high, nameof(high));

		return item.IsGreaterThanEqualTo(low) && item.IsLessThanEqualTo(high);
	}

	/// <summary>
	/// Checks if item do not exists between <paramref name="low"/> and <paramref name="high"/>, both inclusive.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	/// <param name="item">The item</param>
	/// <param name="low">The start value of the range.</param>
	/// <param name="high">The end value of the range.</param>
	/// <returns>True if item does not exists between <paramref name="low"/> and <paramref name="high"/>, false otherwise</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public static Boolean IsOutOfRange<T>(this T item, T low, T high)
		where T : IComparable<T>
	{
		ArgumentNullException.ThrowIfNull(item, nameof(item));
		ArgumentNullException.ThrowIfNull(low, nameof(low));
		ArgumentNullException.ThrowIfNull(high, nameof(high));

		return !item.IsWithinRange(low, high);
	}
}
