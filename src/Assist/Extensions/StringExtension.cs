namespace VP.DotNet.Assist.Extensions;

/// <summary>
/// String extension class.
/// Contains extension methods to perform operation on strings.
/// </summary>
public static class StringExtension
{
	/// <summary>
	/// Checks if the <paramref name="text"/> is empty.
	/// </summary>
	/// <param name="text"></param>
	/// <returns></returns>
	public static Boolean IsEmpty(this String text)
	{
		ArgumentNullException.ThrowIfNull(text, nameof(text));
		return text.Length == 0;
	}

	/// <summary>
	/// Checks if the <paramref name="text"/> is null.
	/// </summary>
	/// <param name="text"></param>
	/// <returns></returns>
	public static Boolean IsNull(this String text) => text is null;

	/// <summary>
	/// Checks if the <paramref name="text"/> is either null or empty.
	/// </summary>
	/// <param name="text">The string/text</param>
	/// <returns></returns>
	public static Boolean IsNullOrEmpty(this String text)
		=> String.IsNullOrEmpty(text);
}
