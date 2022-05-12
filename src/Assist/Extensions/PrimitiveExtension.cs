namespace VP.DotNet.Assist.Extensions;

using System.Diagnostics.CodeAnalysis;

public static class PrimitiveExtension
{
	public static Boolean IsNull<T>([NotNullWhen(false)] this T instance)
		=> instance is null;

	public static Boolean IsNotNull<T>([NotNullWhen(true)] this T instance)
		=> instance is not null;
}
