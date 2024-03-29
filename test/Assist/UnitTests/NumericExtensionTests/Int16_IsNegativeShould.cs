﻿namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;
public class Int16_IsNegativeShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		Int16 intMaxValue = Int16.MaxValue;
		Int16 intMinValue = Int16.MinValue;

		//Act
		Action actWhenInt16Max = () => intMaxValue.IsNegative();
		Action actWhenInt16Min = () => intMinValue.IsNegative();

		//Assert
		actWhenInt16Max.Should().NotThrow<NotImplementedException>();
		actWhenInt16Min.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsZero()
	{
		//Arrange
		Int16 intZero = Int16.MaxValue + Int16.MinValue + 1;

		//Act
		var actualWhenIntIsZero = intZero.IsNegative();

		//Assert
		actualWhenIntIsZero.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsPositive()
	{
		//Arrange
		Int16 intPositive = Int16.MaxValue;

		//Act
		var actualWhenIntIsPositive = intPositive.IsNegative();

		//Assert
		actualWhenIntIsPositive.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsNegative()
	{
		//Arrange
		Int16 intNegative = Int16.MinValue;

		//Act
		var actualWhenIntIsNegative = intNegative.IsNegative();

		//Assert
		actualWhenIntIsNegative.Should().BeTrue();
	}
}
