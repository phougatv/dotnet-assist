namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;

using FluentAssertions;
using System;
using VP.DotNet.Assist.Extensions;
using Xunit;

public class Int32_IsPositiveShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var intMaxValue = Int32.MaxValue;
		var intMinValue = Int32.MinValue;

		//Act
		Action actWhenInt32Max = () => intMaxValue.IsPositive();
		Action actWhenInt32Min = () => intMinValue.IsPositive();

		//Assert
		actWhenInt32Max.Should().NotThrow<NotImplementedException>();
		actWhenInt32Min.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsZero()
	{
		//Arrange
		var intZero = Int32.MaxValue + Int32.MinValue + 1;

		//Act
		var actualWhenIntIsZero = intZero.IsPositive();

		//Assert
		actualWhenIntIsZero.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsNegative()
	{
		//Arrange
		var intNegative = Int32.MinValue;

		//Act
		var actualWhenIntIsNegative = intNegative.IsPositive();

		//Assert
		actualWhenIntIsNegative.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsPositive()
	{
		//Arrange
		var intPositive = Int32.MaxValue;

		//Act
		var actualWhenIntIsPositive = intPositive.IsPositive();

		//Assert
		actualWhenIntIsPositive.Should().BeTrue();
	}
}
