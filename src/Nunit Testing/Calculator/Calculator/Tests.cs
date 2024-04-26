using NUnit.Framework;

namespace Calculator;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void Addition_TwoDoubles_Pass()
    {
        //preq-UNIT-TEST-2
        // Arrange
        const double a = 4.2;
        const double b = 6.1;
        const double expected = 10.3;

        // Act
        var result = Program.Add(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }

    [Test]
    public void Subtraction_Doubles_Pass()
    {
        //preq-UNIT-TEST-3
        // Arrange
        const double a = 8;
        const double b = 1.1;
        const double expected = 6.9;

        // Act
        var result = Program.Subtract(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }

    [Test]
    public void Multiplication_Doubles_Pass()
    {
        //preq-UNIT-TEST-4
        // Arrange
        const double a = 3;
        const double b = 2.2;
        const double expected = 6.6;

        // Act
        var result = Program.Multiply(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }


    [Test]
    public void Division_Doubles_Pass()
    {
        //preq-UNIT-TEST-5
        // Arrange
        const double a = 20;
        const double b = 4;
        const double expected = 5;

        // Act
        var result = Program.Divide(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }

    [Test]
    public void Division_Doubles_DivideByZero()
    {
        //preq-UNIT-TEST-6 
        // Arrange
        const double a = 20;
        const double b = 0;
        const double expected = double.PositiveInfinity;

        // Act
        var result = Program.Divide(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }


    [Test]
    public void Equals_Doubles_Pass()
    {
        //preq-UNIT-TEST-7
        // Arrange
        const double a = 20;
        const double b = 20;
        const double expected = 1; //1 indicates yes they are equal, 0 indicates they are not

        // Act
        var result = Program.Equals(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }

    [Test]
    public void Equals_Doubles_Fail()
    {
        //preq-UNIT-TEST-7
        // Arrange
        const double a = 20;
        const double b = 22;
        const double expected = 0; //1 indicates yes they are equal, 0 indicates they are not

        // Act
        var result = Program.Equals(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }
    
    [Test]
    public void Power_Doubles_Pass()
    {
        //preq-UNIT-TEST-8
        // Arrange
        const double a = 3;
        const double b = 3;
        const double expected = 27;

        // Act
        var result = Program.Power(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }

    [Test]
    public void Log_Doubles_Pass()
    {
        //preq-UNIT-TEST-9
        // Arrange
        const double a = 8;
        const double b = 2;
        const double expected = 3;

        // Act
        var result = Program.Log(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }

    [Test]
    public void Log_Doubles_Error_A_LesserThanZero()
    {
        //preq-UNIT-TEST-10
        // Arrange
        const double a = 0;
        const double b = 2;
        const double expected = double.NegativeInfinity;
        // Act
        var result = Program.Log(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001);
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }


    [Test]
    public void Log_Doubles_Error_B_EqualsZero()
    {
        //preq-UNIT-TEST-11
        // Arrange
        const double a = 8;
        const double b = 0;
        const double expected = double.NaN;

        // Act
        var result = Program.Log(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }


    [Test]
    public void Root_Doubles_Pass()
    {
        //preq-UNIT-TEST-12
        // Arrange
        const double a = 8;
        const double b = 3;
        const double expected = 2;

        // Act
        var result = Program.Root(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }


    [Test]
    public void Root_Doubles_Error_B_EqualsZero()
    {
        //preq-UNIT-TEST-13
        // Arrange
        const double a = 8;
        const double b = 0;
        const double expected = double.PositiveInfinity;

        // Act
        var result = Program.Root(a, b);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }


    [Test]
    public void Factorial_Doubles_Pass()
    {
        //preq-UNIT-TEST-14
        // Arrange
        const double a = 5;
        const double expected = 120;

        // Act
        var result = Program.Factorial(a);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }


    [Test]
    public void Factorial_Doubles_Pass_Convention_One()
    {
        //preq-UNIT-TEST-15
        // Arrange
        const double a = 0;
        const double expected = 1;

        // Act
        var result = Program.Factorial(a);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }


    [Test]
    public void SinA_Doubles_Pass()
    {
        //preq-UNIT-TEST-16
        // Arrange
        const double a = 1;
        const double expected = 0.0174524;

        // Act
        var result = Program.SinA(a);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }


    [Test]
    public void CosA_Doubles_Pass()
    {
        //preq-UNIT-TEST-17
        // Arrange
        const double a = 1;
        const double expected = 0.99985;

        // Act
        var result = Program.CosA(a);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }


    [Test]
    public void TanA_Doubles_Pass()
    {
        //preq-UNIT-TEST-18
        // Arrange
        const double a = 1;
        const double expected = 0.0174551;

        // Act
        var result = Program.TanA(a);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }


    [Test]
    public void Reciprocal_Doubles_Pass()
    {
        //preq-UNIT-TEST-19
        // Arrange
        const double a = 8;
        const double expected = 0.125;

        // Act
        var result = Program.Reciprocal(a);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }

    [Test]
    public void Reciprocal_Doubles_Error_DividedByZero()
    {
        //preq-UNIT-TEST-20
        // Arrange
        const double a = 0;
        const double expected = 2;

        // Act
        var result = Program.Reciprocal(a);

        // Assert
        //Assert.AreEqual(expected, result, 0.001); //where 8 = points of precision Assert.Pass();
        Assert.That(expected,Is.EqualTo(result).Within(0.001));
    }
}
