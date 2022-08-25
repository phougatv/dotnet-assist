namespace VP.DotNet.Assist.UnitTest.NumericExtensionTests;
public class SByte_IsZeroShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var sByteMaxValue = SByte.MaxValue;
		var sByteMinValue = SByte.MinValue;

		//Act
		Action actWhenByteMax = () => sByteMaxValue.IsZero();
		Action actWhenByteMin = () => sByteMinValue.IsZero();

		//Assert
		actWhenByteMax.Should().NotThrow<NotImplementedException>();
		actWhenByteMin.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsNegative()
	{
		//Act
		var actualWhenSByteMin = SByte.MinValue.IsZero();

		//Assert
		SByte.MinValue.Should().BeNegative();
		actualWhenSByteMin.Should().BeFalse();
	}

	[Fact]
	public void ReturnFalse_WhenNumberIsPositive()
	{
		//Act
		var actualWhenSByteMin = SByte.MaxValue.IsZero();

		//Assert
		SByte.MaxValue.Should().BePositive();
		actualWhenSByteMin.Should().BeFalse();
	}

	[Fact]
	public void ReturnTrue_WhenNumberIsZero()
	{
		//Arrange
		SByte sByteZero = SByte.MaxValue + SByte.MinValue + 1;

		//Act
		var actualWhenSByteIsZero = sByteZero.IsZero();

		//Assert
		actualWhenSByteIsZero.Should().BeTrue();
	}
}
