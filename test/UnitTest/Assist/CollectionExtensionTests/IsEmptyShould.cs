namespace VP.DotNet.Assist.UnitTest.CollectionExtensionTests;

using FluentAssertions;
using System;
using VP.DotNet.Assist.Extensions;
using Xunit;

public class IsEmptyShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var collection = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.EmptyEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		Action actWhenEnumerableIsEmpty = () => enumerable.IsEmpty();
		Action actWhenCollectionIsNull = () => collection.IsEmpty();
		Action actWhenListIsNull = () => list.IsEmpty();

		//Assert
		enumerable.Should().BeEmpty();
		collection.Should().BeNull();
		list.Should().BeNull();

		actWhenEnumerableIsEmpty.Should().NotThrow<NotImplementedException>();
		actWhenCollectionIsNull.Should().NotThrow<NotImplementedException>();
		actWhenListIsNull.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void Throw_ArgumentNullException_WhenCollectionIsNull()
	{
		//Arrange
		var collection = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.NullEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		Action actWhenEnumerableIsEmpty = () => enumerable.IsEmpty();
		Action actWhenCollectionIsEmpty = () => collection.IsEmpty();
		Action actWhenListIsEmpty = () => list.IsEmpty();

		//Assert
		enumerable.Should().BeNull();
		collection.Should().BeNull();
		list.Should().BeNull();

		actWhenEnumerableIsEmpty.Should()
			.ThrowExactly<ArgumentNullException>()
			.WithParameterName("collection")
			.WithMessage("Value cannot be null. (Parameter 'collection')");
		actWhenCollectionIsEmpty.Should()
			.ThrowExactly<ArgumentNullException>()
			.WithParameterName("collection")
			.WithMessage("Value cannot be null. (Parameter 'collection')");
		actWhenListIsEmpty.Should()
			.ThrowExactly<ArgumentNullException>()
			.WithParameterName("collection")
			.WithMessage("Value cannot be null. (Parameter 'collection')");
	}

	[Fact]
	public void ReturnFalse_WhenCollectionIsNotEmpty()
	{
		//Arrange
		var enumerable = Arrange.TestEnumerable(1, 2, 3);
		var collection = Arrange.TestCollection(-3, -2, -1);
		var list = Arrange.TestList(0);

		//Act
		var actualEnumerableIsEmpty = enumerable.IsEmpty();
		var actualCollectionIsEmpty = collection.IsEmpty();
		var actualListIsEmpty = list.IsEmpty();

		//Assert
		enumerable.Should().NotBeNullOrEmpty();
		collection.Should().NotBeNullOrEmpty();
		list.Should().NotBeNullOrEmpty();

		actualEnumerableIsEmpty.Should().BeFalse();
		actualCollectionIsEmpty.Should().BeFalse();
		actualListIsEmpty.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenCollectionIsEmpty()
	{
		//Arrange
		var enumerable = Arrange.EmptyEnumerable<Int32>();
		var collection = Arrange.EmptyCollection<Int32>();
		var list = Arrange.EmptyList<Int32>();

		//Act
		var actualEnumerableIsEmpty = enumerable.IsEmpty();
		var actualCollectionIsEmpty = collection.IsEmpty();
		var actualListIsEmpty = list.IsEmpty();

		//Assert
		enumerable.Should().NotBeNull();
		enumerable.Should().BeEmpty();
		collection.Should().NotBeNull();
		collection.Should().BeEmpty();
		list.Should().NotBeNull();
		list.Should().BeEmpty();

		actualEnumerableIsEmpty.Should().BeTrue();
		actualCollectionIsEmpty.Should().BeTrue();
		actualListIsEmpty.Should().BeTrue();
	}
}