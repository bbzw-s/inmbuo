# Dokumentation Projektarbeit M226B & M120

> Lian Studer & Kris Huber, 13.05.2022

## Inhaltsverzeichnis

- [Dokumentation Projektarbeit M226B \& M120](#dokumentation-projektarbeit-m226b--m120)
  - [Inhaltsverzeichnis](#inhaltsverzeichnis)
  - [Einleitung (Management Summary)](#einleitung-management-summary)
  - [Planung](#planung)
    - [User Stories (Grobkonzept I)](#user-stories-grobkonzept-i)
    - [Scribbles (Grobkonzept II)](#scribbles-grobkonzept-ii)
    - [Prototyp (Detailkonzept II)](#prototyp-detailkonzept-ii)
      - [User Scenario](#user-scenario)
    - [Usability Tests (Detailkonzept III)](#usability-tests-detailkonzept-iii)

## Einleitung (Management Summary)

**Autoren**: Lian Studer, Kris Huber

**Erstelldatum**: 13.05.2022

## Planung

In diesem Abschnitt ist der Planungsprozess dokumentiert.

### User Stories (Grobkonzept I)

In der folgenden Tabelle sind sämtliche User Stories aufgelistet, welche in diesem Projekt umgesetzt werden sollen. Die Tabelle ist nach Priorität der User Story sortiert. Jede User Story hat zusätzlich eine Liste von Abnahmekriterien, welche festlegen, wann eine User Story als implementiert und abgeschlossen gilt. Die letzte Spalte der Tabelle signalisiert, ob eine User Story abgeschlossen wurde, oder nicht.

**Bedeutungen der Emojis:**

- Abgeschlossen: ✔️
- Nicht abgeschlossen: ❌

| ID    | User Story                                                   | Abnahmekriterien                                             | Priorität*¹ | Status |
| ----- | ------------------------------------------------------------ | ------------------------------------------------------------ | ----------- | ------ |
| **1** | Als Benutzer möchte ich die neusten Blogposts nach Kategorie sortiert sehen. | - Ein Blogpost wird in der richtigen Kategorie angezeigt.<br/>- Blogposts sind nach Kategorien gruppiert/sortiert.<br/>- Alle Kategorien werden angezeigt.<br/>- Es werden nur die fünf neusten Blogposts pro Kategorie angezeigt. | D           | ❌      |
| **2** | Als Benutzer möchte ich weitere Blogposts einer Kategorie sehen, wenn ich auf die Kategorie klicke. | - Ein Blogpost wird in der richtigen Kategorie angezeigt.<br/>- Alle Blogposts der Kategorie werden angezeigt.<br/>- Die Blogposts sind nach Erstelldatum sortiert. | D           | ❌      |
| **3** | Als Benutzer möchte ich einen neuen Blogpost erstellen können. | - Feld für Titel<br/>- Feld für Inhalt<br/>- Veröffentlichungsstatus kann festgelegt werden (Entwurf, Veröffentlicht)<br/>- Kategorie kann ausgewählt werden | A           | ❌      |
| **4** | Als Benutzer möchte ich mich Anmelden können.                | - Feld für Benutzername<br/>- Feld für Password              | A           | ❌      |
| **5** | Als Benutzer möchte ich meine Blogposts bearbeiten können.   | - Titel, Inhalt, Veröffentlichungsstatus und Kategorie können verändert werden. | C           | ❌      |
| **6** | Als Benutzer möchte ich mein Profil bearbeiten können.       | - Benutzername, Passwort, Biografie und Profilbild können bearbeitet werden. | B           | ❌      |

*¹ **Prioritäten**

Die Priorisierung erfolgt nach der Eisenhower Matrix. Sie ist in der folgenden Graphik abgebildet. Mehr Information finden Sie [hier](https://de.wikipedia.org/wiki/Eisenhower-Prinzip). 

![Eisenhower Prinzip](assets/eisenhower.jpg)

### Scribbles (Grobkonzept II)

> Die Scribbles für die Abgabe "Grobkonzept II" wurden separat abgegeben. Sie werden zu einem späteren Zeitpunkt noch zu diesem Dokument hinzugefügt.

### Prototyp (Detailkonzept II)

[Hier finden Sie unseren Adobe XD Prototypen](https://xd.adobe.com/view/6aa13fe3-38bb-4908-82a1-828bd68d5a03-3ff2/).

#### User Scenario

**Wer?** Der Benutzer in diesem Szenario arbeitet als Entwickler bei einer Firma, deren Büro in der Innenstadt liegt. Der Benutzer selbst wohnt ausserhalb der Stadt. Er fährt jeden Tag mit dem Zug zur Arbeit. Er ist etwa 30 Jahre alt, ist verheiratet und hat ein Kind.

**Was?** Das Ziel des Benutzers ist es, neues und interessantes aus dem Fachbereich der Software Entwicklung zu erfahren.

**Wann und Wo?** Während der Pause im Büro, oder abends zum Zeitvertreib, oder auch im Zug auf dem Weg ins Büro.

**Wieso?** Aus Langeweile und zum Zeitvertreib, aber hautpsächlich um etwas neues zu lernen.

### Usability Tests (Detailkonzept III)

**Durchführungsort:** Feld

**Durchführungsart:** Persönlich

**Moderation:** Unmoderiert

**Fragen die wir mit dem Usability Test beantwortet werden möchten sind:**

- **Kann der Benutzer die Software intuitiv navigieren?** Ja, der Benutzer hat keine Probleme mit der Navigation. Da die Benutzeroberfläche ähnlich ist wie andere Applikationen die ähnliches leisten, fühlt sich der Benutzer vertraut mit der Benutzeroberfläche.

- **Ist klar erkennbar welches die Steuerelemente (Buttons etc.) sind?** Ja, die Steuerelemente sollten gut erkennbar sein.

- **Ziele der Tests:** Wir wollen herausfinden ob unsere Applikation einfach zu bedienen ist.

**Tests**
- Melden Sie sich an.
    - Abgeschlossen wenn man sich auf der Anmeldeseite befindet (Login Logik funktioniert im XD Prototyp nicht)
- Erkundigen Sie sich über die beliebteste Post Kategorie.
    - Abgeschlossen wenn man bei der Kategorie "Engineering und Architektur" auf "Mehr Anzeigen" drückt.
- Lesen Sie den Artikel über Microservices mit linkerd.
    - Abgeschlossen wenn man auf den Artikel "Microservices mit linkerd" drückt und danach den Text durchliest.
