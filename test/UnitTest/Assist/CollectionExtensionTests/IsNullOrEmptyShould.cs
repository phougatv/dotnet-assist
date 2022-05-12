namespace VP.DotNet.Assist.UnitTest.CollectionExtensionTests;

using FluentAssertions;
using System;
using System.Linq;
using VP.DotNet.Assist.Extensions;
using Xunit;

public class IsNullOrEmptyShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var collection = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.EmptyEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		Action actWhenEnumerableIsNullOrEmpty = () => enumerable.IsNullOrEmpty();
		Action actWhenCollectionIsNullOrEmpty = () => collection.IsNullOrEmpty();
		Action actWhenListIsNullOrEmpty = () => list.IsNullOrEmpty();

		//Assert
		enumerable.Should().BeEmpty();
		collection.Should().BeNull();
		list.Should().BeNull();

		actWhenEnumerableIsNullOrEmpty.Should().NotThrow<NotImplementedException>();
		actWhenCollectionIsNullOrEmpty.Should().NotThrow<NotImplementedException>();
		actWhenListIsNullOrEmpty.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void NotThrow_ArgumentNullException()
	{
		//Arrange
		var collection = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.NullEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		Action actWhenEnumerableIsNullOrEmpty = () => enumerable.IsNullOrEmpty();
		Action actWhenCollectionIsNullOrEmpty = () => collection.IsNullOrEmpty();
		Action actWhenListIsNullOrEmpty = () => list.IsNullOrEmpty();

		//Assert
		enumerable.Should().BeNull();
		collection.Should().BeNull();
		list.Should().BeNull();

		actWhenEnumerableIsNullOrEmpty.Should().NotThrow<ArgumentNullException>();
		actWhenCollectionIsNullOrEmpty.Should().NotThrow<ArgumentNullException>();
		actWhenListIsNullOrEmpty.Should().NotThrow<ArgumentNullException>();
	}

	[Fact]
	public void NotThrow_AnyOtherException()
	{
		//Arrange
		var collection = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.EmptyEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		Action actWhenEnumerableIsNullOrEmpty = () => enumerable.IsNullOrEmpty();
		Action actWhenCollectionIsNullOrEmpty = () => collection.IsNullOrEmpty();
		Action actWhenListIsNullOrEmpty = () => list.IsNullOrEmpty();

		//Assert
		actWhenEnumerableIsNullOrEmpty.Should().NotThrow<Exception>();
		actWhenCollectionIsNullOrEmpty.Should().NotThrow<Exception>();
		actWhenListIsNullOrEmpty.Should().NotThrow<Exception>();
	}

	[Fact]
	public void ReturnsFalse_WhenCollectionHasAtLeastOneItem()
	{
		//Arrange
		var collection = Arrange.TestCollection(-100);
		var enumerable = Arrange.TestEnumerable(1, 2, 3, 4);
		var list = Arrange.TestList(Int32.MaxValue);

		//Act
		var actualEnumerableIsNullOrEmpty = enumerable.IsNullOrEmpty();
		var actualCollectionIsNullOrEmpty = collection.IsNullOrEmpty();
		var actualListIsNullOrEmpty = list.IsNullOrEmpty();

		//Assert
		enumerable.Should().NotBeNullOrEmpty();
		enumerable.Count().Should().Be(4);
		collection.Should().NotBeNullOrEmpty();
		collection.Count.Should().Be(1);
		list.Should().NotBeNullOrEmpty();
		list.Count.Should().Be(1);

		actualEnumerableIsNullOrEmpty.Should().BeFalse();
		actualCollectionIsNullOrEmpty.Should().BeFalse();
		actualListIsNullOrEmpty.Should().BeFalse();
	}

	[Fact]
	public void ReturnsTrue_WhenCollectionIsNull()
	{
		//Arrange
		var collection = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.NullEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		var actualEnumerableIsNullOrEmpty = enumerable.IsNullOrEmpty();
		var actualCollectionIsNullOrEmpty = collection.IsNullOrEmpty();
		var actualListIsNullOrEmpty = list.IsNullOrEmpty();

		//Assert
		enumerable.Should().BeNull();
		collection.Should().BeNull();
		list.Should().BeNull();

		actualEnumerableIsNullOrEmpty.Should().BeTrue();
		actualCollectionIsNullOrEmpty.Should().BeTrue();
		actualListIsNullOrEmpty.Should().BeTrue();
	}

	[Fact]
	public void ReturnsTrue_WhenCollectionIsEmpty()
	{
		//Arrange
		var collection = Arrange.EmptyCollection<Int32>();
		var enumerable = Arrange.EmptyEnumerable<Int32>();
		var list = Arrange.EmptyList<Int32>();

		//Act
		var actualEnumerableIsNullOrEmpty = enumerable.IsNullOrEmpty();
		var actualCollectionIsNullOrEmpty = collection.IsNullOrEmpty();
		var actualListIsNullOrEmpty = list.IsNullOrEmpty();

		//Assert
		enumerable.Should().NotBeNull().And.BeEmpty();
		enumerable.Count().Should().Be(0);
		collection.Should().NotBeNull().And.BeEmpty();
		collection.Count.Should().Be(0);
		list.Should().NotBeNull().And.BeEmpty();
		list.Count.Should().Be(0);

		actualEnumerableIsNullOrEmpty.Should().BeTrue();
		actualCollectionIsNullOrEmpty.Should().BeTrue();
		actualListIsNullOrEmpty.Should().BeTrue();
	}
}
