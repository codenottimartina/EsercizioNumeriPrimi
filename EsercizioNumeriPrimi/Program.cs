// Programma che chiede all'utente di inserire un numero intero, trova il numero primo successivo di esso e lo restituisce.
// Se il numero dato è un numero primo, restituisce il numero dato.

int numeroAcquisito = Utilities.AcquisisciInteroDaConsole("Inserisci un numero intero, verrà restituito il numero primo successivo:");
var numeroPrimoSuccessivo = Utilities.CalcolaNumeroPrimoSuccessivo(numeroAcquisito);
Console.WriteLine("Numero inserito: " + numeroAcquisito);
Console.WriteLine("Numero primo successivo: " + numeroPrimoSuccessivo);

public class Utilities
{
    public static int AcquisisciInteroDaConsole(string messaggioUtente)
    {
        int toReturn;
        Console.WriteLine(messaggioUtente);
        var stringaAcquisita = Console.ReadLine();
        if(!Int32.TryParse(stringaAcquisita, out toReturn))
        {
            Console.WriteLine("Attenzione, il numero inserito non è valido");
            return AcquisisciInteroDaConsole(messaggioUtente);
        }
        return toReturn;
    }

    public static int CalcolaNumeroPrimoSuccessivo(int  numeroAcquisito)
    {
        int? toReturn = null;

        while(toReturn == null)
        {
            if(_checkNumeroPrimo(numeroAcquisito))
            {
                toReturn = numeroAcquisito;
            }
            numeroAcquisito++;
        }

        return toReturn.Value;
    }

    public static bool _checkNumeroPrimo(int numero)
    {
        for (int i = 2; i < numero; i++)
        {
            if(numero %  i == 0)
            {
                return false;
            }
        }

        return true;
    }
}