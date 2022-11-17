# Projekt-Dokumentation

Llama

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 27.10.2022 | 1.0.1 | User-Stories und Testfälle |
| 27.10.2022 | 1.0.2 | Planen                       |
| 3.11.2022 | 2.0.1 | Mit Programmieren angefangen                      |
| 10.11.2022 | 3.0.1 | Weiter programmiert                     |
| 17.11.2022 | 3.0.2 | Bearbeitung und Zusammenführung der Programm                      |
| 17.11.2022 | 4.0.1 | Projekt-Dokumentation ergänzt                    |
| 17.11.2022 | 4.0.2| Lern-Bericht gemacht                   |




## 1 Informieren

### 1.1 Ihr Projekt

Vocabeltrainer für Englisch und Deutsch

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Der User muss Übersetzung eingeben.| Funktional | Als ein User möchte ich die Sprache wechseln können (Russisch --> Deutsch/Deutsch --> Russisch | 
| 2    | Der User kann die Eingabe wiederholen wenn er sie zuerst falsch eingegeben hat | Funktional | Als User möchte ich meine falschen Antowrten wiederholt eingeben|
| 3    | Der User kann am Schluss seine Punktzahl sehen | Funktional | Als User möchte ich am Schluss meine Punktzahl sehen.| 
| 4    | Der User kann am Schluss sehen nach 2. Runde wie er sich verbessert hat bzw. Highscore | Qualität| Als User möchte ich sehen wie ich mich verbessert habe nach dem ersten Mal. |
| 5    | Als User kann ich eine Animation anschauen wenn ich ein Wort richtig habe. | Qualität | Als User möchte ich eine Animation wenn ich etwas richtig beantwortet habe.
| 6    | Als User kann ich den Text gut erkennen auf dem Hintergrund | Qualität | Als User möchte ich eine gute Gestaltung. |
| 7    | Als User kann ich mich einloggen | Qualität | Als User möchte ich mich einloggen und meine Ergebnisse sehen. |
| 8    | Als User möchte ich eine Animation anschauen wenn ich ein Wort falsch habe.| Qualität | Als User möchte ich eine Animation wenn ich etwas falsch beantwortet habe. |
| 9    | Als User kann ich mich registrieren. | Qualität | Als User möchte ich wie bei einer Webseite ein Fenster haben, wo ich mich registrieren kann.|
| 10   | Als User kann ich aussuchen, wie viele Wörter ich im vorprogrammierten Code möchte haben. | Qualität | Als User möchte ich aussuchen können, wie viele Wörter ich im vorprogrammierten Code habe. |



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm wird gestartet | welche Sprache | Sprache die User gewählt hat |
| 2.1  | Eingabe von User ist Falsch | Hello --> огар | nächstes Wort kommt |
| 3.1  | Alle Wörter wurden Übersetzt | | Punktzahl wird angezeigt |
| 4.1  | Alle Wörter wurden erneut Übersetzt | | Punktzahl von vorherigen Runde und dieser Runde verglichen und es wird gezeigt wie viel Punkte der User mehr hat. |
| 5.1  | Programm wird gestartet | Hello --> приветь | Animation für richtig | 
| 6.1  | Programm wird gestartet | Name + Passwort | Begrüssung |
| 7.1  | Programm wird gestartet | блять --> Hund | Animation für falsch |
| 8.1  | Programm wird gestartet | Name + Passwort + Passwort bestätigen | Begrüssung + Anleitung |

### 1.4 Diagramme
![image](https://user-images.githubusercontent.com/111045708/201024596-5334e53b-832a-4504-b016-d30ff552600f.png)



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |03.11.2022| Carina Sutter | Entscheiden | 45 min. |
| 2.A  |03.11.2022| Mohammad Bashiri | Grundlagen | 20 min. |
| 3.A  |03.11.2022| Nils Wiederkehr | Lernbericht anfangen | 45 min. |
| 4.A  |03.11.2022| Steven Salie | PAP | 30 min.  |
| 5.A  |03.11.2022| Nils Wiederkehr | Animation | 1 h|
| 6.A  |03.11.2022| Steven Salie | Punktzahl anzeigen | 1 h|
| 7.A  |10.11.2022| Carina Sutter | Vorprogrammierte Wörter| 2h |
| 8.A  |10.11.2022| Mohammad Bashiri | Einloggen, Anmelden und Registrieren| 45 min. |
| 9.A  |10.11.2022| Steven Salie | Punktzahl |1h |
| 10.A |10.11.2022| Carina Sutter| kann Wörter selber eingeben| 1 - 2h|
| 11.A |10.11.2022| Carina Sutter | Kann selber entscheiden, wie viele wörter man möchte| 1 - 2h|

Total: 140 min. = 4.33

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 03.11.2022 | Nils Wiederkehr  |  45 min  |      30min        |
| 2.A  | 03.11.2022 | Mohammad Bashiri |  20 min  |     10 min   |
| 4.A  |03.11.2022| Steven Salie | 30min | 60 min.  |
| 5.A  |03.11.2022| Nils Wiederkehr | 1h | 2h|
| 7.A  |10.11.2022| Carina Sutter | 2h| 30min |
| 8.A  | 10.11.2022 | Mohammad Bashiri |  45 min  |     65 min   |
| 9.A  |10.11.2022| Steven Salie | 1h | 2h|
| 10.A |10.11.2022| Carina Sutter | 1 - 2h | 1.5h|
| 11.A | 10.11.2022 | Carina Sutter    | 1 - 2h   |      1.5h    |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  -    |     -    |   -    |
| 2.1  | 17.11.2022| Funktioniert|Carina + Steven|
| 3.1  | 17.11.2022| Funktioniert nicht | Steven|
| 3.2  | 17.11.2022| Funktioniert| Steven|
| 4.1  | -    |     -     |    -   |
| 5.1  | - | - | - |
| 6.1 | - | - | - |
| 7.1 | - | - | - |
| 8.1 | - | - | - |

Fazit: Bei den Testfällen mit dem Bindestrich konnten wir nicht umsetzen, weil wir das noch nicht können.


## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
