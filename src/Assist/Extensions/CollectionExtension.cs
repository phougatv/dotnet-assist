namespace VP.DotNet.Assist.Extensions;

using System.Diagnostics.CodeAnalysis;

public static class CollectionExtension
{
	/// <summary>
	/// Checks if <paramref name="collection"/> is empty
	/// </summary>
	/// <exception cref="ArgumentNullException"></exception>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The <see cref="IEnumerable{T}"/></param>
	/// <returns>True if collection is empty, false if not empty</returns>
	public static Boolean IsEmpty<T>([NotNull] this IEnumerable<T> collection)
	{
		ArgumentNullException.ThrowIfNull(collection, nameof(collection));
		return !collection.Any();
	}

	/// <summary>
	/// Checks if <paramref name="collection"/> is not empty
	/// </summary>
	/// <exception cref="ArgumentNullException"></exception>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The <see cref="IEnumerable{T}"/></param>
	/// <returns>True if collection is not empty, false if empty</returns>
	public static Boolean IsNotEmpty<T>([NotNull] this IEnumerable<T> collection)
	{
		ArgumentNullException.ThrowIfNull(collection, nameof(collection));
		return collection.Any();
	}

	/// <summary>
	/// Checks if <paramref name="collection"/> is either null or empty
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The <see cref="IEnumerable{T}"/></param>
	/// <returns>True if collection is either null or empty, false if otherwise</returns>
	public static Boolean IsNullOrEmpty<T>(this IEnumerable<T> collection)
		=> (collection is null) || !collection.Any();

	/// <summary>
	/// Checks if <paramref name="collection"/> is not null and not empty.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The <see cref="IEnumerable{T}"/></param>
	/// <returns>True if collection is neither null and nor empty, false otherwise</returns>
	public static Boolean IsNotNullOrEmpty<T>(this IEnumerable<T> collection)
		=> (collection is not null) && collection.Any();
}
