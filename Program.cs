using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Transactions;

int p = 0;


Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Wollen Sie ein vorprogrammiertes Programm oder selber Ihre Wörter eingeben? [vor programmiert|selber] \nВы хотите набрать свои собственные Слова или вы хотите иметь предварительно запрограммированную версию? [своими словами|предупретованной]");
string question = Console.ReadLine();

if (question == "vor programmiert")
{
    Console.WriteLine("Wie viele Wörter möchten Sie? [10|20|30|40|50]: ");
    int numberWords = Convert.ToInt32(Console.ReadLine());

    switch (numberWords)
    {
        case 50:
            string[] russianArray50 = {"быть", "сказать", "мочь", "говорить", "знать", "стать", "есть", "хотеть", "видеть", "идти", "стоять", "думать", "спросить", "жить", "смотреть", "сидеть", "понять", "иметь", "делать", "взять", "сделать", "понимать", "казаться", "давать", "пойти", "увидеть", "остаться", "выйти", "дать", "работать", "любить", "оказаться", "ответить", "подумать", "значить", "посмотреть", "ждать", "лежать", "найти", "писать", "решить", "вернуться", "считать", "помнить", "получить", "ходить", "бывать", "прийти", "узнать", "заметить" };
            string[] germanArray50 = { "zu sein, sein", "zu sagen,sprechen", "in der Lage sein", "zu sagen, erzählen, ersagen", "wissen, sich bewusst sein", "werden, beginnen, kommen", "essen, sein", "wollen, wie", "sehen", "zu gehen, zu kommen", "stehen, sein, aufstehen", "denken", "fragen", "leben", "schauen", "sitzen", "verstehen", "haben", "machen", "to take", "machen, fertig machen", "verstehen", "erscheinen", "geben, lassen, erlauben", "gehen", "sehen", "bleiben", "raus gehen, raus kommen, erscheinen", "geben", "arbeiten", "lieben", "sich selbst finden, sich herausstellen", "antworten", "denken", "meinen", "um einen Blick zu werfen, schauen, prüfen", "warten", "lügen, gelegen sein", "finden, entdecken, erwägen", "schreiben", "entscheiden, lösen", "zurückbringen", "zählen, erwägen", "erinnern", "bekommen, kriegen, erhalten", "gehen, laufen", "sein, besuchen, passieren", "kommen, ankommen", "wissen, lernen, erkennen", "bemerken, beobachten"};


            for (int i = 0; i < russianArray50.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Übersetzen Sie folgendes Wort: ");
                Console.ResetColor();
                Console.WriteLine(russianArray50[i]);
                string russiantranslation = Console.ReadLine();

                if (russiantranslation == germanArray50[i])
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Das ist richt! Sehr gut!");
                    Console.ResetColor();
                    p++;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Das ist nicht richtig. Die richtige Antwort ist ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(germanArray50[i]);
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Super du hast " + p + " Punkte erreicht");
            break;
            

        case 40:
            string[] russianArray40 = { "быть", "сказать", "мочь", "говорить", "знать", "стать", "есть", "хотеть", "видеть", "идти", "стоять", "думать", "спросить", "жить", "смотреть", "сидеть", "понять", "иметь", "делать", "взять", "сделать", "понимать", "казаться", "давать", "пойти", "увидеть", "остаться", "выйти", "дать", "работать", "любить", "оказаться", "ответить", "подумать", "значить", "посмотреть", "ждать", "лежать", "найти", "писать" };
            string[] germanArray40 = { "zu sein, sein", "zu sagen,sprechen", "in der Lage sein", "zu sagen, erzählen, ersagen", "wissen, sich bewusst sein", "werden, beginnen, kommen", "essen, sein", "wollen, wie", "sehen", "zu gehen, zu kommen", "stehen, sein, aufstehen", "denken", "fragen", "leben", "schauen", "sitzen", "verstehen", "haben", "machen", "to take", "machen, fertig machen", "verstehen", "erscheinen", "geben, lassen, erlauben", "gehen", "sehen", "bleiben", "raus gehen, raus kommen, erscheinen", "geben", "arbeiten", "lieben", "sich selbst finden, sich herausstellen", "antworten", "denken", "meinen", "um einen Blick zu werfen, schauen, prüfen", "warten", "lügen, gelegen sein", "finden, entdecken, erwägen", "schreiben" };

            for (int i = 0; i < russianArray40.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Übersetzen Sie folgendes Wort: ");
                Console.ResetColor();
                Console.WriteLine(russianArray40[i]);
                string russiantranslation = Console.ReadLine();

                if (russiantranslation == germanArray40[i])
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Das ist richt! Sehr gut!");
                    Console.ResetColor();
                    p++;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Das ist nicht richtig. Die richtige Antwort ist ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(germanArray40[i]);
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Super du hast " + p + " Punkte erreicht");
            break;

        case 30:
            string[] russianArray30 = { "быть", "сказать", "мочь", "говорить", "знать", "стать", "есть", "хотеть", "видеть", "идти", "стоять", "думать", "спросить", "жить", "смотреть", "сидеть", "понять", "иметь", "делать", "взять", "сделать", "понимать", "казаться", "давать", "пойти", "увидеть", "остаться", "выйти", "дать", "работать", "любить" };
            string[] germanArray30 = { "zu sein, sein", "zu sagen,sprechen", "in der Lage sein", "zu sagen, erzählen, ersagen", "wissen, sich bewusst sein", "werden, beginnen, kommen", "essen, sein", "wollen, wie", "sehen", "zu gehen, zu kommen", "stehen, sein, aufstehen", "denken", "fragen", "leben", "schauen", "sitzen", "verstehen", "haben", "machen", "to take", "machen, fertig machen", "verstehen", "erscheinen", "geben, lassen, erlauben", "gehen", "sehen", "bleiben", "raus gehen, raus kommen, erscheinen", "geben", "arbeiten" };


            for (int i = 0; i < russianArray30.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Übersetzen Sie folgendes Wort: ");
                Console.ResetColor();
                Console.WriteLine(russianArray30[i]);
                string russiantranslation = Console.ReadLine();

                if (russiantranslation == germanArray30[i])
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Das ist richt! Sehr gut!");
                    Console.ResetColor();
                    p++;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Das ist nicht richtig. Die richtige Antwort ist ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(germanArray30[i]);
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Super du hast " + p + " Punkte erreicht");
            break;

        case 20:
            string[] russianArray20 = { "быть", "сказать", "мочь", "говорить", "знать", "стать", "есть", "хотеть", "видеть", "идти", "стоять", "думать", "спросить", "жить", "смотреть", "сидеть", "понять", "иметь", "делать", "взять", "сделать" };
            string[] germanArray20 = { "zu sein, sein", "zu sagen,sprechen", "in der Lage sein", "zu sagen, erzählen, ersagen", "wissen, sich bewusst sein", "werden, beginnen, kommen", "essen, sein", "wollen, wie", "sehen", "zu gehen, zu kommen", "stehen, sein, aufstehen", "denken", "fragen", "leben", "schauen", "sitzen", "verstehen", "haben", "machen", "to take", "machen, fertig machen" };

            for (int i = 0; i < russianArray20.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Übersetzen Sie folgendes Wort: ");
                Console.ResetColor();
                Console.WriteLine(russianArray20[0]);
                string russiantranslation = Console.ReadLine();

                if (russiantranslation == germanArray20[i])
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Das ist richt! Sehr gut!");
                    Console.ResetColor();
                    p++;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Das ist nicht richtig. Die richtige Antwort ist ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(germanArray20[i]);
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Super du hast " + p + " Punkte erreicht");
            break;

        case 10:
            string[] russianArray10 = { "быть", "сказать", "мочь", "говорить", "знать", "стать", "есть", "хотеть", "видеть", "идти", "стоять" };
            string[] germanArray10 = { "zu sein, sein", "zu sagen,sprechen", "in der Lage sein", "zu sagen, erzählen, ersagen", "wissen, sich bewusst sein", "werden, beginnen, kommen", "essen, sein", "wollen, wie", "sehen", "zu gehen, zu kommen", "stehen, sein, aufstehen"};

            for (int i = 0; i < russianArray10.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Übersetzen Sie folgendes Wort: ");
                Console.ResetColor();
                Console.WriteLine(russianArray10[i]);
                string russiantranslation = Console.ReadLine();

                if (russiantranslation == germanArray10[i])
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Das ist richt! Sehr gut!");
                    Console.ResetColor();
                    p++;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Das ist nicht richtig. Die richtige Antwort ist ");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(germanArray10[i]);
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Super du hast " + p + " Punkte erreicht");
            break;

            

           

    }
}

if (question == "selber")
{
    List<string> germanList = new List<string>();
    List<string> russianList = new List<string>();
    string mehrWoerter;
    do
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Geben Sie das russische Wort ein: ");
        Console.ResetColor();
        string russianWord = Console.ReadLine();
        russianList.Add(russianWord);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Geben Sie die deutsche Übersetzung ein: ");
        Console.ResetColor();
        string germanWord = Console.ReadLine();
        germanList.Add(germanWord);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Noch ein Wort?[ja|nein]: ");
        Console.ResetColor();
        mehrWoerter = Console.ReadLine();


    } while (mehrWoerter == "ja");

    for (int i = 0; i < russianList.Count; i++)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Übersetzen Sie folgendes Wort: ");
        Console.ResetColor();
        Console.WriteLine(russianList[i]);
        string russiantranslation = Console.ReadLine();

        if (russiantranslation == germanList[i])
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Das ist richt! Sehr gut!");
            Console.ResetColor();
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Das ist nicht richtig. Die richtige Antwort ist ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(germanList[i]);
            Console.ResetColor();
        }
    }
}
