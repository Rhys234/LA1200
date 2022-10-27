# Projekt-Dokumentation

Llama

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 27.10.2022 | 0.0.1   | User-Stories und Testfälle |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Der User muss Übersetzung eingeben.| Funktional | Als ein User möchte ich die Sprache wechseln können (Fremdsprache --> Deutsch/Deutsch --> Fremdsprache | 
| 2    | Der User kann die Eingabe wiederholen wenn er sie zuerst falsch eingegeben hat | Funktional | Als User möchte ich meine flaschen Antowrten wiederholt eingeben|
| 3    | Der User kann am Schluss seine Punktzahl sehen | Funktional | Als User möchte ich am Schluss meine Punktzahl sehen.| 
| 4    | Der User kann am Schluss sehen nach 2. Runde wie er sich verbessert hat bzw. Highscore | Qualität| Als User möchte ich sehen wie ich mich verbessert habe nach dem ersten Mal. |
| 5    | Als User kann ich eine Animation anschauen wenn ich ein Wort richtig habe. | Qualität | Als User möchte ich eine Animation wenn ich etwas richtig beantwortet habe.
| 6    | Als User kann ich den Text gut erkennen auf dem Hintergrund | Qualität | Als User möchte ich eine gute Gestaltung. |
| 7    | Als User kann ich mich einloggen | Qualität | Als User möchte ich mich einloggen und meine Ergebnisse sehen. |
| 8    | Als User möchte ich eine Animation anschauen wenn ich ein Wort falsch habe.| Qualität | Als User möchte ich eine Animation wenn ich etwas falsch beantwortet habe. |
| 9    | kann mich registrieren. | Qualität | Als User möchte ich wie bei einer Webseite ein Fenster haben, wo ich mich registrieren kann.



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm wird gestartet | welche Sprache | Sprache die User gewählt hat |
| 2.1  | Eingabe von User ist Falsch | Hello --> Hund | nächstes Wort kommt |
| 3.1  | Alle Wörter wurden Übersetzt | | Punktzahl wird angezeigt |
| 4.1  | Alle Wörter wurden erneut Übersetzt | | Punktzahl von vorherigen Runde und dieser Runde verglichen und es wird gezeigt wie viel Punkte der User mehr hat. |
| 5.1  | Programm wird gestartet | Hello --> Hallo | Animation für richtig | 
| 7.1  | Programm wird gestartet | Name + Passwort | Begrüssung |
| 8.1  | Programm wird gestartet | Hello --> Hund | Animation für falsch |
| 9.1  | Programm wird gestartet | Name + Passwort + Passwort bestätigen | Begrüssung + Anleitung |

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
