namespace VP.DotNet.Assist.UnitTest.CollectionExtensionTests;

using FluentAssertions;
using System;
using System.Linq;
using VP.DotNet.Assist.Extensions;
using Xunit;

public class IsNotEmptyShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var collection = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.EmptyEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		Action actWhenEnumerableIsNotEmpty = () => enumerable.IsNotEmpty();
		Action actWhenCollectionIsNull = () => collection.IsNotEmpty();
		Action actWhenListIsNull = () => list.IsNotEmpty();

		//Assert
		enumerable.Should().BeEmpty();
		collection.Should().BeNull();
		list.Should().BeNull();

		actWhenEnumerableIsNotEmpty.Should().NotThrow<NotImplementedException>();
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
		Action actWhenEnumerableIsNotEmpty = () => enumerable.IsNotEmpty();
		Action actWhenCollectionIsNotEmpty = () => collection.IsNotEmpty();
		Action actWhenListIsNotEmpty = () => list.IsNotEmpty();

		//Assert
		enumerable.Should().BeNull();
		collection.Should().BeNull();
		list.Should().BeNull();

		actWhenEnumerableIsNotEmpty.Should()
			.ThrowExactly<ArgumentNullException>()
			.WithParameterName("collection")
			.WithMessage("Value cannot be null. (Parameter 'collection')");
		actWhenCollectionIsNotEmpty.Should()
			.ThrowExactly<ArgumentNullException>()
			.WithParameterName("collection")
			.WithMessage("Value cannot be null. (Parameter 'collection')");
		actWhenListIsNotEmpty.Should()
			.ThrowExactly<ArgumentNullException>()
			.WithParameterName("collection")
			.WithMessage("Value cannot be null. (Parameter 'collection')");
	}

	[Fact]
	public void ReturnFalse_WhenCollectionIsEmpty()
	{
		//Arrange
		var enumerable = Arrange.EmptyEnumerable<Int32>();
		var collection = Arrange.EmptyCollection<Int32>();
		var list = Arrange.EmptyList<Int32>();

		//Act
		var actualEnumerableIsNotEmpty = enumerable.IsNotEmpty();
		var actualCollectionIsNotEmpty = collection.IsNotEmpty();
		var actualListIsNotEmpty = list.IsNotEmpty();

		//Assert
		enumerable.Should().NotBeNull().And.BeEmpty();
		enumerable.Count().Should().Be(0);
		collection.Should().NotBeNull().And.BeEmpty();
		collection.Count.Should().Be(0);
		list.Should().NotBeNull().And.BeEmpty();
		list.Count.Should().Be(0);

		actualEnumerableIsNotEmpty.Should().BeFalse();
		actualCollectionIsNotEmpty.Should().BeFalse();
		actualListIsNotEmpty.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenCollectionHasAtLeastOneItem()
	{
		//Arrange
		var enumerable = Arrange.TestEnumerable(1, 2, 3, 4);
		var collection = Arrange.TestCollection(-100);
		var list = Arrange.TestList(Int32.MaxValue);

		//Act
		var actualEnumerableIsNotEmpty = enumerable.IsNotEmpty();
		var actualCollectionIsNotEmpty = collection.IsNotEmpty();
		var actualListIsNotEmpty = list.IsNotEmpty();

		//Assert
		enumerable.Should().NotBeNullOrEmpty();
		enumerable.Count().Should().Be(4);
		collection.Should().NotBeNullOrEmpty();
		collection.Count.Should().Be(1);
		list.Should().NotBeNullOrEmpty();
		list.Count.Should().Be(1);

		actualEnumerableIsNotEmpty.Should().BeTrue();
		actualCollectionIsNotEmpty.Should().BeTrue();
		actualListIsNotEmpty.Should().BeTrue();
	}
}
