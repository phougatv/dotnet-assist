namespace VP.DotNet.Assist.UnitTest.IComparableExtensionTests;

using FluentAssertions;
using System;
using VP.DotNet.Assist.Extensions;
using Xunit;

public class HaveSamePositionShould
{
	[Fact]
	public void NotThrow_NotImpelmentedException()
	{
		//Arrange
		var emptyLeft = Arrange.EmptyString;
		var emptyRight = Arrange.EmptyString;
		var left = "Bruce Wayne";
		var right = "Clark Kent";

		//Act
		Action actWhenBothOperandsAreEmpty = () => emptyLeft.HaveSamePosition(emptyRight);
		Action act = () => left.HaveSamePosition(right);

		//Assert
		actWhenBothOperandsAreEmpty.Should().NotThrow<NotImplementedException>();
		act.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void Throw_ArgumentNullException_WhenOnlyLeftOperandIsNull()
	{
		//Arrange
		var nullLeft = Arrange.NullString;
		var right = "Bruce Wayne";

		//Act
		Action actWhenLeftIsNull = () => nullLeft.HaveSamePosition(right);

		//Assert
		actWhenLeftIsNull.Should().ThrowExactly<ArgumentNullException>()
			.WithMessage("Value cannot be null. (Parameter 'left')")
			.WithParameterName("left");
	}

	[Fact]
	public void Throw_ArgumentNullException_WhenOnlyRightOperandIsNull()
	{
		//Arrange
		var left = "Bruce Wayne";
		var nullRight = Arrange.NullString;

		//Act
		Action actWhenRightIsNull = () => left.HaveSamePosition(nullRight);

		//Assert
		actWhenRightIsNull.Should().ThrowExactly<ArgumentNullException>()
			.WithMessage("Value cannot be null. (Parameter 'right')")
			.WithParameterName("right");
	}

	[Fact]
	public void ReturnFalse_WhenLeftOperandIsNotEqualToRightOperand()
	{
		//Arrange
		var left = "Bruce Wayne";
		var right = "Clark Kent";

		//Act
		var actualWhenLeftIsNotEqualToRight = left.HaveSamePosition(right);

		//Assert
		left.Should().Be("Bruce Wayne");
		right.Should().Be("Clark Kent");
		actualWhenLeftIsNotEqualToRight.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenBothOperandsAreEmpty()
	{
		//Arrange
		var emptyLeft = Arrange.EmptyString;
		var emptyRight = Arrange.EmptyString;

		//Act
		var actualWhenBothOperandsAreEmpty = emptyLeft.HaveSamePosition(emptyRight);

		//Assert
		emptyLeft.Should().BeEmpty();
		emptyRight.Should().BeEmpty();
		actualWhenBothOperandsAreEmpty.Should().BeTrue();
	}

	[Fact]
	public void ReturnTrue_WhenBothOperandsAreEqual()
	{
		//Arrange
		var left = "Bruce Wayne";
		var right = "Bruce Wayne";

		//Act
		var actualWhenBothOperandsAreEqual = left.HaveSamePosition(right);

		//Assert
		left.Should().NotBeEmpty();
		right.Should().NotBeEmpty();
		actualWhenBothOperandsAreEqual.Should().BeTrue();
	}
}
