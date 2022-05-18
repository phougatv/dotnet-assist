namespace VP.DotNet.Assist.Extensions;

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// PrimitiveExtension class
/// </summary>
public static class PrimitiveExtension
{
	/// <summary>
	/// Checks if the <paramref name="instance"/> of type T is null.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	/// <param name="instance">The instance.</param>
	/// <returns>True if <paramref name="instance"/> is null, false otherwise.</returns>
	public static Boolean IsNull<T>([NotNullWhen(false)] this T instance)
		=> instance is null;

	/// <summary>
	/// Checks if the <paramref name="instance"/> of type T is not null.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	/// <param name="instance">The instance.</param>
	/// <returns>True if the <paramref name="instance"/> is not null, false otherwise</returns>
	public static Boolean IsNotNull<T>([NotNullWhen(true)] this T instance)
		=> instance is not null;
}
