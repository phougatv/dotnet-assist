﻿namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;
public class Int16_IsOddShould
{
	[Fact]
	public void NotThrow_NotImpelmentedException()
	{
		//Arrange
		Int16 intMinus1 = -1;
		Int16 intSecondToMinValue = Int16.MinValue + 1;

		//Act
		Action actWhenMinus1 = () => intMinus1.IsOdd();
		Action actWhenSecondToMinValue = () => intSecondToMinValue.IsOdd();

		//Assert
		actWhenMinus1.Should().NotThrow<NotImplementedException>();
		actWhenSecondToMinValue.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsEvenAndNegative()
	{
		//Arrange
		Int16 intMinus2 = -2;
		Int16 intMinValue = Int16.MinValue;

		//Act
		var actualWhenMinus2 = intMinus2.IsOdd();
		var actualWhenMinValue = intMinValue.IsOdd();

		//Assert
		intMinus2.Should().BeNegative()
			.And.BeOfType(typeof(Int16));
		intMinValue.Should().BeNegative()
			.And.BeOfType(typeof(Int16));
		actualWhenMinus2.Should().BeFalse();
		actualWhenMinValue.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsEvenAndPositive()
	{
		//Arrange
		Int16 int2 = 2;
		Int16 intMaxValueMinus1 = Int16.MaxValue - 1;

		//Act
		var actualWhen2 = int2.IsOdd();
		var actualWhenMaxValueMinus1 = intMaxValueMinus1.IsOdd();

		//Assert
		int2.Should().BePositive()
			.And.BeOfType(typeof(Int16));
		intMaxValueMinus1.Should().BePositive()
			.And.BeOfType(typeof(Int16));
		actualWhen2.Should().BeFalse();
		actualWhenMaxValueMinus1.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsOddAndNegative()
	{
		//Arrange
		Int16 intMinus1 = -1;
		Int16 intSecondToMinValue = Int16.MinValue + 1;

		//Act
		var actualWhenMinus1 = intMinus1.IsOdd();
		var actualWhenSecondToMinValue = intSecondToMinValue.IsOdd();

		//Assert
		intMinus1.Should().BeNegative()
			.And.BeOfType(typeof(Int16));
		intSecondToMinValue.Should().BeNegative()
			.And.BeOfType(typeof(Int16));
		actualWhenMinus1.Should().BeTrue();
		actualWhenSecondToMinValue.Should().BeTrue();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsOddAndPositive()
	{
		//Arrange
		Int16 int1 = 1;
		Int16 int19 = 19;
		Int16 intMaxValue = Int16.MaxValue;

		//Act
		var actualWhen1 = int1.IsOdd();
		var actualWhen19 = int19.IsOdd();
		var actualWhenMaxValue = intMaxValue.IsOdd();

		//Assert
		int1.Should().BePositive()
			.And.BeOfType(typeof(Int16));
		int19.Should().BePositive()
			.And.BeOfType(typeof(Int16));
		intMaxValue.Should().BePositive()
			.And.BeOfType(typeof(Int16));

		actualWhen1.Should().BeTrue();
		actualWhen19.Should().BeTrue();
		actualWhenMaxValue.Should().BeTrue();
	}
}
