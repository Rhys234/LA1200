# Lern-Bericht
Llama
Carina Sutter, Mohammad Bashiri, Nils Wiederkehr, Steven Salie

## Einleitung

Ein Vokabeltrainer, mit dem Sie Wörter vom Deutschen ins Russische oder vom Russischen ins Deutsche lernen können.

## Was haben wir gelernt?

Wir haben gelernt wie man in einem einzelnen Code-Block, jedes Element eines Array nacheinander abfragen kann.

## Beschreibung

✍️ Verwenden Sie drei verschiedene Medien, um zu zeigen, was Sie gelernt haben. Zum Beispiel:

Zuerst wusste ich nicht ganz, wie ich das anstellen soll. Nachdem ich ein bisschen ausprobiert habe, habe ich mein Problem auf Stack overflow geschildert. Nach kurzer Zeit habe ich eine Antwort bekommen, die Funktionierte. Hier unten sehen sie den Code, der ich als Antwort bekommen habe und ich werde ihn erklären. Fangen wir oben an. Wie sie sehen steht ganz oben russianArray. Ein Array ist sozusagen eine Box wo wir mehrere Werte abspeichern können. In diesem Beispiel haben wir jetzt 5 Russische Wörter als Werte und im germanArray haben wir die 5 Übersetzungen von den 5 Russischen Wörtern. Um diese Arrays abzurufen habe ich in diesem Beispiel eine for schleife gemcht. Das was in der Klammer ist, bedeutet folgendes: Wenn i kleiner ist als die russianArray, wird i um eins erhöht. Was als nächstes folgt ist die Abfragung vom User. Das heisst die Konsole (Console) sagt dem User das er folgendes Wort übersetzen soll. Nachdem zeigt die konsole das erste Wort des russianArray an. Wenn der User die Antwort eingegeben hat, kontrolliert die Konsole, ob die Antwort des Users mit dem germanArray übereinstimmt. Wenn ja sagt das Programm: "Das ist richtig! sehr gut!" und wen nicht sagt es: "Das ist nicht richtig. Die richtige Antwort ist " und dann kommt noch die richtige Antwort.

```csharp
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string[] russianArray = { "быть", "сказать", "мочь", "говорить", "знать" };
string[] germanArray = { "zu sein, sein", "zu sagen,sprechen", "in der Lage sein", "zu sagen, erzählen, ersagen", "wissen, sich bewusst sein" };

for (int i = 0; i < russianArray50.Length; i++)
{

    Console.WriteLine("Übersetzen Sie folgendes Wort: ");
    Console.WriteLine(russianArray50[i]);
    string russiantranslation = Console.ReadLine();

    if (russiantranslation == germanArray50[i])
    {
        Console.WriteLine("Das ist richt! Sehr gut!");
    }

    else
    {
        Console.WriteLine("Das ist nicht richtig. Die richtige Antwort ist ");
        Console.WriteLine(germanArray50[i]);
    }
}

```



## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflexion zum Arbeitsprozess

Was ich wirklich gut fand, war unsere Teamarbeit bei diesem Projekt. Alle taten was ihnen aufgetragen wurde und erledigten ihre Arbeit pünktlich.

Es gab viele Dinge, die nicht wirklich gut liefen. Das erste war, dass einige von uns mehrfach krankheitsbedingt abwesend waren oder einen Termin hatten. 
Zweitens waren wir zu ehrgeizig mit unseren Zielen und normalerweise würde ich sagen, dass das eine gute Sache ist, aber es hat viel Zeit gedauert, bis wir herausgefunden haben, was wir tun wollten, mit den uns gestellten Anforderungen nicht möglich war vom Lehrer. 
Wir hatten auch Schwierigkeiten, einige Funktionen wie die Registrierung und Anmeldung zu implementieren.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
