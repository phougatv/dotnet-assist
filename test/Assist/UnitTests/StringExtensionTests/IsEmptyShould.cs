namespace VP.DotNet.Assist.UnitTest.StringExtensionTests;
public class IsEmptyShould
{
	[Fact]
	public void NotThrow_NotImplementedException()
	{
		//Arrange
		var text = "";

		//Act
		var act = () => text.IsEmpty();

		//Assert
		act.Should().NotThrow<NotImplementedException>();
	}

	[Fact]
	public void Throw_ArgumentNullException()
	{
		//Arrange
		var text = (String)null!;

		//Act
		var act = () => text.IsEmpty();

		//Assert
		act.Should().Throw<ArgumentNullException>()
			.WithMessage("Value cannot be null. (Parameter 'text')")
			.WithParameterName("text");
	}

	[Fact]
	public void ReturnFalse_WhenArgumentIsNotEmpty()
	{
		//Arrange
		var text = "Bruce Wayne";
		
		//Act
		var actual = text.IsEmpty();

		//Assert
		actual.Should().BeFalse();
		text.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public void ReturnTrue_WhenArgumentIsEmpty()
	{
		//Arrange
		var text1 = "";
		var text2 = String.Empty;
		var text3 = new String(new Char[0]);
		var text4 = new String(Array.Empty<Char>());

		//Act
		var actual1 = text1.IsEmpty();
		var actual2 = text2.IsEmpty();
		var actual3 = text3.IsEmpty();
		var actual4 = text4.IsEmpty();

		//Assert
		actual1.Should().BeTrue();
		actual2.Should().BeTrue();
		actual3.Should().BeTrue();
		actual4.Should().BeTrue();

		text1.Should().BeEmpty();
		text2.Should().BeEmpty();
		text3.Should().BeEmpty();
		text4.Should().BeEmpty();
	}
}
