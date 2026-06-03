using Xunit;
using Calculator;

namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        var calculator = new Calculator();
        var result = calculator.Add(4, 5);
        Assert.Equal(9, result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsCorrectDifference()
    {
        var calculator = new Calculator();
        var result = calculator.Subtract(8, 2);
        Assert.Equal(6, result);
    }

    /* Oppgave 1: Skriv ferdig testene (fyll inn Arrange, Act, Assert).
       Deretter implementerer du koden i Calculator.cs. 
       Husk prosessen: Red -> Green -> Refactor. */

    [Fact]
    public void Multiply_TwoNumbers_ReturnsCorrectProduct()
    {
        // Arrange

        // Act

        // Assert
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsCorrectQuotient()
    {
        // Arrange

        // Act

        // Assert
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange

        // Act + Assert
        // Hint: Bruk Assert.Throws<DivideByZeroException>("en melding")
    }

    /* Oppgave 2: Trening i å bruke Theory. 
       Skriv ferdig logikken i testen slik at de tre InlineData-settene kjøres.
       Forhold deg til Add-metoden og ikke Add2-metoden */
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(5, 5, 10)]
    [InlineData(-1, 1, 0)]
    public void Add_WithMultipleInputs_ReturnsExpectedResult(int a, int b, int expected)
    {
        // Arrange

        // Act

        // Assert

    /* Midlertidig linje for å unngå rød streker før du har skrevet koden.
        Denne linjen skal slettes etter du har implementert testen: */
        throw new System.NotImplementedException($"Bruk {a}, {b} og {expected} til å lage testen.");
    }

    /* Oppgave 3: Finn feilen!
        En annen utvikler har laget metoden "Add2" i Calculator.cs.
        Den ser ut til å fungere fint med vanlige, positive tall, men har en skjult feil.
        
        1. Skriv tester med ulike typer input (f.eks. negative tall) for å finne feilen.
        2. Kjør testene til du får en "RØD" test.
        3. Rett opp feilen i Calculator.cs slik at alle testene blir "GRØNNE". */   

    [Fact]
    public void Add2_PositiveNumbers_ReturnsCorrectSum()
    {
        // En test med positive tall blir GRØNN med en gang.
        // Denne viser at koden tilsynelatende virker.
        var calculator = new Calculator();
        var result = calculator.Add2(4, 5);
        Assert.Equal(9, result);
    }

    [Fact]
    public void Add2_x_ReturnsCorrectSum()
    {
        // Arrange:
        var calculator = new Calculator();

        // Act:

        // Assert:
    }

    /* Bonus oppgave: Skriv alle tester du mener trengs for å utvikle IsEven-metoden.
       Bruk TDD-prosessen:
       1. Skriv en test for et positivt partall -> Se at den feiler (Rød).
       2. Skriv nok kode i Calculator.cs til at den blir suksess (Grønn).
       3. Gjenta for oddetall, negative tall og null. */
    [Fact]
    public void IsEven_PositiveEvenNumber_ReturnsTrue()
    {
        // Skriv første test her
    }
}

