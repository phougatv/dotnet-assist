namespace VP.DotNet.Assist.UnitTest.IComparableExtensionTests;

using System;
using Xunit;
using FluentAssertions;
using VP.DotNet.Assist.Extensions;

public class IsGreaterThanEqualToShould
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
		Action actWhenBothOperandsAreEmpty = () => emptyLeft.IsGreaterThanEqualTo(emptyRight);
		Action act = () => left.IsGreaterThanEqualTo(right);

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
		Action actWhenLeftIsNull = () => nullLeft.IsGreaterThanEqualTo(right);

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
		Action actWhenRightIsNull = () => left.IsGreaterThanEqualTo(nullRight);

		//Assert
		actWhenRightIsNull.Should().ThrowExactly<ArgumentNullException>()
			.WithMessage("Value cannot be null. (Parameter 'right')")
			.WithParameterName("right");
	}

	/// <summary>
	/// By less, it means, where does value of one operand lies in the sorted order
	/// compared to the value of another operand.
	/// Any word starting with "B" will come before the word starting with "C".
	/// </summary>
	[Fact]
	public void ReturnFalse_WhenLeftOperandIsLessThanRightOperand()
	{
		//Arrange
		var left = "Bruce Wayne";
		var right = "Clark Kent";

		//Act
		var actualWhenLeftIsGreaterThanEqualToRight = left.IsGreaterThanEqualTo(right);

		//Assert
		left.Should().Be("Bruce Wayne");
		right.Should().Be("Clark Kent");
		actualWhenLeftIsGreaterThanEqualToRight.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenBothOperandsAreEmpty()
	{
		//Arrange
		var emptyLeft = Arrange.EmptyString;
		var emptyRight = Arrange.EmptyString;

		//Act
		var actualWhenBothOperandsAreEmpty = emptyLeft.IsGreaterThanEqualTo(emptyRight);

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
		var actualWhenBothOperandsAreEqual = left.IsGreaterThanEqualTo(right);

		//Assert
		left.Should().Be(right).And.Be("Bruce Wayne");
		actualWhenBothOperandsAreEqual.Should().BeTrue();
	}

	[Fact]
	public void ReturnTrue_WhenLeftOperandIsGreaterThanRightOperand()
	{
		//Arrange
		var left = "Krypton";
		var right = "Clark Kent";

		//Act
		var actualWhenLeftIsGreaterThanEqualToRight = left.IsGreaterThanEqualTo(right);

		//Assert
		left.Should().Be("Krypton");
		right.Should().Be("Clark Kent");
		actualWhenLeftIsGreaterThanEqualToRight.Should().BeTrue();
	}
}
