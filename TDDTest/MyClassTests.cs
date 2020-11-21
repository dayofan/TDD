using AutoFixture;
using FluentAssertions;
using Moq;
using System.Diagnostics;
using TDD;
using Xunit;

namespace TDDTest
{
    public class MyClassTests
    {
        //[Fact]
        //public void WhenReverseStringCalled_ReturnString()
        //{
        //    // Arrange
        //    var sut = new MyClass();

        //    // Act
        //    var result = sut.ReverseString("abc");

        //    // Assert
        //    //Assert.IsType<string>(result);

        //    result.Should().BeOfType<string>();
        //}

        //[Theory]
        //[InlineData("abc", "cba")]
        //[InlineData("bigger", "reggib")]
        //[InlineData("nigeria", "airegin")]
        //public void WhenReverseStringCalled_ReturnReversedString(string text, string expectedResult)
        //{
        //    // Arrange
        //    var sut = new MyClass();

        //    // Act
        //    var result = sut.ReverseString(text);

        //    // Assert
        //    result.Should().Be(expectedResult);

        //    //Assert.Equal(expectedResult, result);
        //}

        //[Fact]
        //public void WhenSetNoOfLegsIsCalled_AndAnimalIsDog_NoOfLegsIs4()
        //{
        //    // Arrange
        //    var sut = new MyClass();
        //    var fixture = new Fixture();

        //    var animal = fixture.Build<Animal>()
        //        .With(a => a.Type, "dog")
        //        .With(a => a.Name, "pete")
        //        .Create();

        //    // Act
        //    sut.SetNoOfLegs(animal);

        //    // Assert
        //    animal.NoOfLegs.Should().Be(4);
        //    //Assert.Equal(4, animal.NoOfLegs);
        //}

        //[Fact]
        //public void WhenSetNoOfLegsIsCalled_AndAnimalIsNotDog_NoOfLegsIsTheSame()
        //{
        //    // Arrange
        //    var sut = new MyClass();
        //    var fixture = new Fixture();

        //    var animal = fixture.Build<Animal>()
        //        .With(a => a.Type, "cat")
        //        .With(a => a.NoOfLegs, 3)
        //        .Create();

        //    var expected = animal.NoOfLegs;

        //    // Act
        //    sut.SetNoOfLegs(animal);

        //    // Assert
        //    animal.NoOfLegs.Should().Be(expected);
        //    //Assert.Equal(4, animal.NoOfLegs);
        //}

        [Fact]
        public void WhenSetAnimalName_AnimalNameChanged()
        {
            // Arrange
            var databaseHelperMock = new Mock<IDatabaseHelper>();
            databaseHelperMock.Setup(x => x.GetAnimal(It.IsAny<int>())).Returns(new Animal());
            //databaseHelperMock.Setup(x => x.GetAnimal(1)).Returns(new Animal { Name = "Animal 1" });
            //databaseHelperMock.Setup(x => x.GetAnimal(2)).Returns(new Animal { Name = "Animal 2" });
            //databaseHelperMock.Setup(x => x.GetAnimal(3)).Returns(new Animal { Name = "Animal 3" });

            var sut = new MyClass(databaseHelperMock.Object);
            var id = 2;
            var name = "Pete";

            // Act
            var result = sut.SetAnimalName(id, name);

            // Assert
            //Assert.Equal(name, result.Name);
            databaseHelperMock.Verify(x => x.SaveAnimal(It.Is<Animal>(a => a.Id == id)));
        }
    }
}
