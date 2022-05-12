namespace VP.DotNet.Assist.UnitTest.IComparableExtensionTests;

using System;
using Xunit;
using FluentAssertions;
using VP.DotNet.Assist.Extensions;

public class IsGreaterThanShould
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
		Action actWhenBothOperandsAreEmpty = () => emptyLeft.IsGreaterThan(emptyRight);
		Action act = () => left.IsGreaterThan(right);

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
		Action actWhenLeftIsNull = () => nullLeft.IsGreaterThan(right);

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
		Action actWhenRightIsNull = () => left.IsGreaterThan(nullRight);

		//Assert
		actWhenRightIsNull.Should().ThrowExactly<ArgumentNullException>()
			.WithMessage("Value cannot be null. (Parameter 'right')")
			.WithParameterName("right");
	}

	/// <summary>
	/// By smaller, it means where does value of one operand lies in the sorted order
	/// compared to the value of another operand.
	/// Any word starting with "B" will come before the word starting with "C".
	/// </summary>
	[Fact]
	public void ReturnFalse_WhenLeftOperandIsSmallerThanRightOperand()
	{
		//Arrange
		var left = "Bruce Wayne";
		var right = "Clark Kent";

		//Act
		var actualWhenLeftIsGreaterThanRight = left.IsGreaterThan(right);

		//Assert
		left.Should().Be("Bruce Wayne");
		right.Should().Be("Clark Kent");
		actualWhenLeftIsGreaterThanRight.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenBothOperandsAreEmpty()
	{
		//Arrange
		var emptyLeft = Arrange.EmptyString;
		var emptyRight = Arrange.EmptyString;

		//Act
		var actualWhenBothOperandsAreEmpty = emptyLeft.IsGreaterThan(emptyRight);

		//Assert
		emptyLeft.Should().BeEmpty();
		emptyRight.Should().BeEmpty();
		actualWhenBothOperandsAreEmpty.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenBothOperandsAreEqual()
	{
		//Arrange
		var left = "Bruce Wayne";
		var right = "Bruce Wayne";

		//Act
		var actualWhenBothOperandsAreEqual = left.IsGreaterThan(right);

		//Assert
		left.Should().Be(right).And.Be("Bruce Wayne");
		actualWhenBothOperandsAreEqual.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenLeftOperandIsGreaterThanRightOperand()
	{
		//Arrange
		var left = "Krypton";
		var right = "Clark Kent";

		//Act
		var actualWhenLeftIsGreaterThanRight = left.IsGreaterThan(right);

		//Assert
		left.Should().Be("Krypton");
		right.Should().Be("Clark Kent");
		actualWhenLeftIsGreaterThanRight.Should().BeTrue();
	}
}
