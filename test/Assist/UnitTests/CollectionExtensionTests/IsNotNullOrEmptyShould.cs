namespace VP.DotNet.Assist.UnitTest.CollectionExtensionTests;

using VP.DotNet.Assist.UnitTest;

public class IsNotNullOrEmptyShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var enumerable = Arrange.EmptyEnumerable<Int32>();
		var collection = Arrange.NullCollection<Int32>();
		var list = Arrange.NullList<String>();

		//Act
		Action actWhenEnumerableIsNotNullOrEmpty = () => enumerable.IsNotNullOrEmpty();
		Action actWhenCollectionIsNotNullOrEmpty = () => collection.IsNotNullOrEmpty();
		Action actWhenListIsNotNullOrEmpty = () => list.IsNotNullOrEmpty();

		//Assert
		enumerable.Should().BeEmpty().And.NotBeNull();
		collection.Should().BeNull();
		list.Should().BeNull();

		actWhenEnumerableIsNotNullOrEmpty.Should().NotThrow<NotImplementedException>();
		actWhenCollectionIsNotNullOrEmpty.Should().NotThrow<NotImplementedException>();
		actWhenListIsNotNullOrEmpty.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void NotThrow_ArgumentNullException()
	{
		//Arrange
		var collection = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.NullEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		Action actWhenEnumerableIsNotNullOrEmpty = () => enumerable.IsNotNullOrEmpty();
		Action actWhenCollectionIsNotNullOrEmpty = () => collection.IsNotNullOrEmpty();
		Action actWhenListIsNotNullOrEmpty = () => list.IsNotNullOrEmpty();

		//Assert
		enumerable.Should().BeNull();
		collection.Should().BeNull();
		list.Should().BeNull();

		actWhenEnumerableIsNotNullOrEmpty.Should().NotThrow<ArgumentNullException>();
		actWhenCollectionIsNotNullOrEmpty.Should().NotThrow<ArgumentNullException>();
		actWhenListIsNotNullOrEmpty.Should().NotThrow<ArgumentNullException>();
	}

	[Fact]
	public void NotThrow_AnyOtherException()
	{
		//Arrange
		var enumerable = Arrange.EmptyEnumerable<Int32>();
		var collection = Arrange.NullCollection<Int32>();
		var list = Arrange.TestList(1, 2, 3, 4);

		//Act
		Action actWhenEnumerableIsNotNullOrEmpty = () => enumerable.IsNotNullOrEmpty();
		Action actWhenCollectionIsNotNullOrEmpty = () => collection.IsNotNullOrEmpty();
		Action actWhenListIsNotNullOrEmpty = () => list.IsNotNullOrEmpty();

		//Assert
		actWhenEnumerableIsNotNullOrEmpty.Should().NotThrow<Exception>();
		actWhenCollectionIsNotNullOrEmpty.Should().NotThrow<Exception>();
		actWhenListIsNotNullOrEmpty.Should().NotThrow<Exception>();
	}

	[Fact]
	public void ReturnFalse_WhenCollectionIsNull()
	{
		//Arrange
		var collection = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.NullEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		var actualWhenEnumerableIsNotNullOrEmpty = enumerable.IsNotNullOrEmpty();
		var actualWhenCollectionIsNotNullOrEmpty = collection.IsNotNullOrEmpty();
		var actualWhenListIsNotNullOrEmpty = list.IsNotNullOrEmpty();

		//Assert
		enumerable.Should().BeNull();
		collection.Should().BeNull();
		list.Should().BeNull();

		actualWhenEnumerableIsNotNullOrEmpty.Should().BeFalse();
		actualWhenCollectionIsNotNullOrEmpty.Should().BeFalse();
		actualWhenListIsNotNullOrEmpty.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenCollectionIsNotNullButEmpty()
	{
		//Arrange
		var collection = Arrange.EmptyCollection<Int32>();
		var enumerable = Arrange.EmptyEnumerable<Int32>();
		var list = Arrange.EmptyList<Int32>();

		//Act
		var actualWhenEnumerableIsNotNullOrEmpty = enumerable.IsNotNullOrEmpty();
		var actualWhenCollectionIsNotNullOrEmpty = collection.IsNotNullOrEmpty();
		var actualWhenListIsNotNullOrEmpty = list.IsNotNullOrEmpty();

		//Assert
		enumerable.Should().BeEmpty().And.NotBeNull();
		collection.Should().BeEmpty().And.NotBeNull();
		list.Should().BeEmpty().And.NotBeNull();

		actualWhenEnumerableIsNotNullOrEmpty.Should().BeFalse();
		actualWhenCollectionIsNotNullOrEmpty.Should().BeFalse();
		actualWhenListIsNotNullOrEmpty.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenCollectionHasOneOrMoreItems()
	{
		//Arrange
		var collection = Arrange.TestCollection(Int32.MaxValue);
		var enumerable = Arrange.TestEnumerable(1, 2, 3, 4);
		var list = Arrange.TestList(Int32.MinValue);

		//Act
		var actualWhenEnumerableIsNotNullOrEmpty = enumerable.IsNotNullOrEmpty();
		var actualWhenCollectionIsNotNullOrEmpty = collection.IsNotNullOrEmpty();
		var actualWhenListIsNotNullOrEmpty = list.IsNotNullOrEmpty();

		//Assert
		enumerable.Should().NotBeNullOrEmpty();
		collection.Should().NotBeNullOrEmpty();
		list.Should().NotBeNullOrEmpty();

		actualWhenEnumerableIsNotNullOrEmpty.Should().BeTrue();
		actualWhenCollectionIsNotNullOrEmpty.Should().BeTrue();
		actualWhenListIsNotNullOrEmpty.Should().BeTrue();
	}
}
