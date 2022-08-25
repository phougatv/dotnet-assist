﻿namespace VP.DotNet.Assist.UnitTest.IComparableExtensionTests;
public class IsLessThanShould
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
		Action actWhenBothOperandsAreEmpty = () => emptyLeft.IsLessThan(emptyRight);
		Action act = () => left.IsLessThan(right);

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
		Action actWhenLeftIsNull = () => nullLeft.IsLessThan(right);

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
		Action actWhenRightIsNull = () => left.IsLessThan(nullRight);

		//Assert
		actWhenRightIsNull.Should().ThrowExactly<ArgumentNullException>()
			.WithMessage("Value cannot be null. (Parameter 'right')")
			.WithParameterName("right");
	}

	/// <summary>
	/// By greater, it means where does value of one operand lies in the sorted order
	/// compared to the value of another operand.
	/// Any word starting with "B" will come before the word starting with "C".
	/// </summary>
	[Fact]
	public void ReturnFalse_WhenLeftOperandIsGreaterThanRightOperand()
	{
		//Arrange
		var left = "Clark Kent";
		var right = "Bruce Wayne";

		//Act
		var actualWhenLeftIsGreaterThanRight = left.IsLessThan(right);

		//Assert
		left.Should().Be("Clark Kent");
		right.Should().Be("Bruce Wayne");
		actualWhenLeftIsGreaterThanRight.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenBothOperandsAreEmpty()
	{
		//Arrange
		var emptyLeft = Arrange.EmptyString;
		var emptyRight = Arrange.EmptyString;

		//Act
		var actualWhenBothOperandsAreEmpty = emptyLeft.IsLessThan(emptyRight);

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
		var actualWhenBothOperandsAreEqual = left.IsLessThan(right);

		//Assert
		left.Should().Be(right).And.Be("Bruce Wayne");
		actualWhenBothOperandsAreEqual.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenLeftOperandIsLessThanRightOperand()
	{
		//Arrange
		var left = "Bruce Wayne";
		var right = "Clark Kent";

		//Act
		var actualWhenLeftIsLessThanRight = left.IsLessThan(right);

		//Assert
		left.Should().Be("Bruce Wayne");
		right.Should().Be("Clark Kent");
		actualWhenLeftIsLessThanRight.Should().BeTrue();
	}
}
