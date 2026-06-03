using System;

namespace Calculator;

public class Calculator
{
    /* Undervisningseksempler. Add er også en del av Oppgave 2 */
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    /* Oppgave 1: Skriv testene først, commitmeldingen skal inneholde red før
    du går videre med å kode metoden. */
    public int Multiply(int a, int b)
    {
        throw new NotImplementedException();
    }

    public int Divide(int a, int b)
    {
        throw new NotImplementedException();
    }

    /* Oppgave 3: Finn feilen ved hjelp av unit tester.
       Koden fungerer for noen tall, men har en skjult logisk feil. */
    public int Add2(int a, int b)
    {
        return Math.Abs(a) + b; 
    }


    /* Bonus oppgave: Implementer IsEven ved å bruke Red-Green-Refactor.
       Krav: Metoden skal returnere true for partall, og false for oddetall. */
    public bool IsEven(int num)
    {
        throw new NotImplementedException();
    }
}
