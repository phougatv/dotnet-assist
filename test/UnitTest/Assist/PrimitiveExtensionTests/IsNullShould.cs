namespace VP.DotNet.Assist.UnitTest.PrimitiveExtensionTests;

using FluentAssertions;
using System;
using System.Collections.Generic;
using VP.DotNet.Assist.Extensions;
using VP.DotNet.Assist.UnitTest.CollectionExtensionTests;
using Xunit;

public class IsNullShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var comparable = Arrange.TestCollection(1, 2, 3);
		var enumerable = Arrange.TestEnumerable('a', 'b', 'c');
		var list = Arrange.TestList(100);

		//Act
		Action actWhenComparableIsNull = () => comparable.IsNull();
		Action actWhenEnumerableIsNull = () => enumerable.IsNull();
		Action actWhenListIsNull = () => list.IsNull();

		//Assert
		comparable.Should().NotBeNullOrEmpty().And.HaveCount(3)
			.And.Equal(new List<Int32> { 1, 2, 3 });
		enumerable.Should().NotBeNullOrEmpty().And.HaveCount(3)
			.And.Equal(new List<Char> { 'a', 'b', 'c' });
		list.Should().NotBeNullOrEmpty().And.HaveCount(1)
			.And.Equal(new List<Int32> { 100 });

		actWhenComparableIsNull.Should().NotThrow<NotImplementedException>();
		actWhenEnumerableIsNull.Should().NotThrow<NotImplementedException>();
		actWhenListIsNull.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void NotThrow_ArgumentNullException()
	{
		//Arrange
		var comparable = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.NullEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		Action actWhenComparableIsNotNull = () => comparable.IsNull();
		Action actWhenEnumerableIsNotNull = () => enumerable.IsNull();
		Action actWhenListIsNotNull = () => list.IsNull();

		//Assert
		comparable.Should().BeNull();
		enumerable.Should().BeNull();
		list.Should().BeNull();

		actWhenComparableIsNotNull.Should().NotThrow<ArgumentNullException>();
		actWhenEnumerableIsNotNull.Should().NotThrow<ArgumentNullException>();
		actWhenListIsNotNull.Should().NotThrow<ArgumentNullException>();
	}

	[Fact]
	public void ReturnFalse_WhenInstanceIsNeitherNullNorEmpty()
	{
		//Arrange
		var comparable = Arrange.TestCollection(1, 2, 3);
		var enumerable = Arrange.TestEnumerable('a', 'b', 'c');
		var list = Arrange.TestList(100);

		//Act
		var actualResultForCollection = comparable.IsNull();
		var actualResultForEnumerable = enumerable.IsNull();
		var actualResultForList = list.IsNull();

		//Assert

		comparable.Should().NotBeNullOrEmpty().And.HaveCount(3)
			.And.Equal(new List<Int32> { 1, 2, 3 });
		enumerable.Should().NotBeNullOrEmpty().And.HaveCount(3)
			.And.Equal(new List<Char> { 'a', 'b', 'c' });
		list.Should().NotBeNullOrEmpty().And.HaveCount(1)
			.And.Equal(new List<Int32> { 100 });

		actualResultForCollection.Should().BeFalse();
		actualResultForEnumerable.Should().BeFalse();
		actualResultForList.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenInstanceIsNotNullButEmpty()
	{
		//Arrange
		var comparable = Arrange.EmptyCollection<String>();
		var enumerable = Arrange.EmptyEnumerable<String>();
		var list = Arrange.EmptyList<String>();

		//Act
		var actualResultForCollection = comparable.IsNull();
		var actualResultForEnumerable = enumerable.IsNull();
		var actualResultForList = list.IsNull();

		//Assert
		comparable.Should().BeNullOrEmpty().And.HaveCount(0);
		enumerable.Should().BeNullOrEmpty().And.HaveCount(0);
		list.Should().BeNullOrEmpty().And.HaveCount(0);

		actualResultForCollection.Should().BeFalse();
		actualResultForEnumerable.Should().BeFalse();
		actualResultForList.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenInstanceIsNull()
	{
		//Arrange
		var comparable = Arrange.NullCollection<Int32>();
		var enumerable = Arrange.NullEnumerable<Int32>();
		var list = Arrange.NullList<Int32>();

		//Act
		var actualResultForCollection = comparable.IsNull();
		var actualResultForEnumerable = enumerable.IsNull();
		var actualResultForList = list.IsNull();

		//Assert
		comparable.Should().BeNull();
		enumerable.Should().BeNull();
		list.Should().BeNull();

		actualResultForCollection.Should().BeTrue();
		actualResultForEnumerable.Should().BeTrue();
		actualResultForList.Should().BeTrue();
	}
}
