namespace VP.DotNet.Assist.UnitTest.CollectionExtensionTests;

using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Arrange class is an internal class for arranging certain collections for unit tests.
/// </summary>
internal class Arrange
{
	internal static IEnumerable<T> TestEnumerable<T>(params T[] args) => new List<T>(args);
	internal static IEnumerable<T> EmptyEnumerable<T>() => Enumerable.Empty<T>();
	internal static IEnumerable<T> NullEnumerable<T>() => null!;

	internal static ICollection<T> TestCollection<T>(params T[] args) => new List<T>(args);
	internal static ICollection<T> EmptyCollection<T>() => Array.Empty<T>();
	internal static ICollection<T> NullCollection<T>() => null!;

	internal static IList<T> TestList<T>(params T[] args) => new List<T>(args);
	internal static IList<T> EmptyList<T>() => Array.Empty<T>();
	internal static IList<T> NullList<T>() => null!;
}
