﻿namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;
public class Int16_IsPositive
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		Int16 intMaxValue = Int16.MaxValue;
		Int16 intMinValue = Int16.MinValue;

		//Act
		Action actWhenInt16Max = () => intMaxValue.IsPositive();
		Action actWhenInt16Min = () => intMinValue.IsPositive();

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
		var actualWhenIntIsZero = intZero.IsPositive();

		//Assert
		actualWhenIntIsZero.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsNegative()
	{
		//Arrange
		Int16 intNegative = Int16.MinValue;

		//Act
		var actualWhenIntIsNegative = intNegative.IsPositive();

		//Assert
		actualWhenIntIsNegative.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsPositive()
	{
		//Arrange
		Int16 intPositive = Int16.MaxValue;

		//Act
		var actualWhenIntIsPositive = intPositive.IsPositive();

		//Assert
		actualWhenIntIsPositive.Should().BeTrue();
	}
}
