namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;

using FluentAssertions;
using System;
using VP.DotNet.Assist.Extensions;
using Xunit;

public class Int16_IsPositive
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var intMaxValue = Int16.MaxValue;
		var intMinValue = Int16.MinValue;

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
		var intZero = (Int16)(Int16.MaxValue + Int16.MinValue + 1);

		//Act
		var actualWhenIntIsZero = intZero.IsPositive();

		//Assert
		actualWhenIntIsZero.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsNegative()
	{
		//Arrange
		var intNegative = Int16.MinValue;

		//Act
		var actualWhenIntIsNegative = intNegative.IsPositive();

		//Assert
		actualWhenIntIsNegative.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsPositive()
	{
		//Arrange
		var intPositive = Int16.MaxValue;

		//Act
		var actualWhenIntIsPositive = intPositive.IsPositive();

		//Assert
		actualWhenIntIsPositive.Should().BeTrue();
	}
}
