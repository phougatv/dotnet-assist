namespace VP.DotNet.Assist.UnitTest.PrimitiveExtensionTests;

using VP.DotNet.Assist.UnitTest;

public class IsNotNullShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var comparable = Arrange.TestCollection(1, 2, 3);
		var enumerable = Arrange.TestEnumerable('a', 'b', 'c');
		var list = Arrange.TestList(100);

		//Act
		Action actWhenComparableIsNotNull = () => comparable.IsNotNull();
		Action actWhenEnumerableIsNotNull = () => enumerable.IsNotNull();
		Action actWhenListIsNotNull = () => list.IsNotNull();

		//Assert
		comparable.Should().NotBeNullOrEmpty().And.HaveCount(3)
			.And.Equal(new List<Int32> { 1, 2, 3 });
		enumerable.Should().NotBeNullOrEmpty().And.HaveCount(3)
			.And.Equal(new List<Char> { 'a', 'b', 'c' });
		list.Should().NotBeNullOrEmpty().And.HaveCount(1)
			.And.Equal(new List<Int32> { 100 });

		actWhenComparableIsNotNull.Should().NotThrow<NotImplementedException>();
		actWhenEnumerableIsNotNull.Should().NotThrow<NotImplementedException>();
		actWhenListIsNotNull.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void NotThrow_ArgumentNullException()
	{
		//Arrange
		var comparable = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.NullEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		Action actWhenComparableIsNotNull = () => comparable.IsNotNull();
		Action actWhenEnumerableIsNotNull = () => enumerable.IsNotNull();
		Action actWhenListIsNotNull = () => list.IsNotNull();

		//Assert
		comparable.Should().BeNull();
		enumerable.Should().BeNull();
		list.Should().BeNull();

		actWhenComparableIsNotNull.Should().NotThrow<ArgumentNullException>();
		actWhenEnumerableIsNotNull.Should().NotThrow<ArgumentNullException>();
		actWhenListIsNotNull.Should().NotThrow<ArgumentNullException>();
	}

	[Fact]
	public void ReturnFalse_WhenCollectionIsNull()
	{
		//Arrange
		var comparable = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.NullEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		var actualWhenComparableIsNotNull = comparable.IsNotNull();
		var actualWhenEnumerableIsNotNull = enumerable.IsNotNull();
		var actualWhenListIsNotNull = list.IsNotNull();

		//Assert
		comparable.Should().BeNull();
		enumerable.Should().BeNull();
		list.Should().BeNull();

		actualWhenComparableIsNotNull.Should().BeFalse();
		actualWhenEnumerableIsNotNull.Should().BeFalse();
		actualWhenListIsNotNull.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenCollectionIsNotNullButEmpty()
	{
		//Arrange
		var comparable = Arrange.EmptyCollection<Int32>();
		var enumerable = Arrange.EmptyEnumerable<Int32>();
		var list = Arrange.EmptyList<Int32>();

		//Act
		var actualWhenComparableIsNotNull = comparable.IsNotNull();
		var actualWhenEnumerableIsNotNull = enumerable.IsNotNull();
		var actualWhenListIsNotNull = list.IsNotNull();

		//Assert
		comparable.Should().NotBeNull().And.BeEmpty().And.HaveCount(0);
		enumerable.Should().NotBeNull().And.BeEmpty().And.HaveCount(0);
		list.Should().NotBeNull().And.BeEmpty().And.HaveCount(0);

		actualWhenComparableIsNotNull.Should().BeTrue();
		actualWhenEnumerableIsNotNull.Should().BeTrue();
		actualWhenListIsNotNull.Should().BeTrue();
	}

	[Fact]
	public void ReturnTrue_WhenCollectionHaveAtLeastOneItem()
	{
		//Arrange
		var comparable = Arrange.TestCollection(1, 2, 3);
		var enumerable = Arrange.TestEnumerable(-99);
		var list = Arrange.TestList(45, 45);

		//Act
		var actualWhenComparableIsNotNull = comparable.IsNotNull();
		var actualWhenEnumerableIsNotNull = enumerable.IsNotNull();
		var actualWhenListIsNotNull = list.IsNotNull();

		//Assert
		comparable.Should().NotBeNullOrEmpty().And.HaveCount(3)
			.And.Equal(new List<Int32> { 1, 2, 3 });
		enumerable.Should().NotBeNullOrEmpty().And.HaveCount(1)
			.And.Equal(new List<Int32> { -99 });
		list.Should().NotBeNullOrEmpty().And.HaveCount(2)
			.And.Equal(new List<Int32> { 45, 45 });

		actualWhenComparableIsNotNull.Should().BeTrue();
		actualWhenEnumerableIsNotNull.Should().BeTrue();
		actualWhenListIsNotNull.Should().BeTrue();
	}
}
