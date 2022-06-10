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

## Umsetzung

In diesem Abschnitt wird der Umsetzungsprozess dokumentiert, vom erstellen der Views, bis zur Implementation der Logik.

### View (Umsetzung I)

Da wir das Projekt mit WPF und C# auf .NET 6 entwickeln, wurden unsere beiden Views in XAML geschrieben. Wir haben dabei versucht, uns so nah wie möglich an unseren Prototypen zu halten.

### MV* Patterns (Umsetzung II)

Wir haben das aus ÜKs und autodidaktischer Bildung bereits vorhandene Wissen über die verschiedenen MV* Patterns mit Tutorials wieder aufgefrischt. Dazu haben wir folgende Ressourcen verwendet:

**MVVM*
- [Microsoft Docs](https://docs.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern)
- [Dev Insider](https://www.dev-insider.de/was-bedeutet-mvvm-a-1103448)
- [Medium](https://medium.com/@ankit.sinhal/mvc-mvp-and-mvvm-design-pattern-6e169567bbad)

**MVP**
- [Medium](https://medium.com/@ankit.sinhal/mvc-mvp-and-mvvm-design-pattern-6e169567bbad)
- [Mark Health Blog](https://markheath.net/post/model-view-presenter-winforms)

**MVC**
- [Medium](https://medium.com/@ankit.sinhal/mvc-mvp-and-mvvm-design-pattern-6e169567bbad)
- [Tutorialspoint](https://www.tutorialspoint.com/design_pattern/mvc_pattern.htm)

#### Beurteilung der Ressourcen

- Die Microsoft Docs, welche bereits WPF als spezifischen Anwendungsfall aufbringen war sehr Hilfreich, da sie mit Code Snippets aufzeigt, wie man MVVM auch wirklich implementiert.
- Der Medium Artikel hat alle drei Patterns kurz erklärt und erläutert, was die Funktionen der einzelnen Komponenten des Patterns (z.Bsp. Model, View und Controller) sind.
- Der Artikel auf Dev Insider hat zwar eine grosse Menge an Text und wenig anschauliche Beispiele, ist dafür jedoch gut strukturiert und verständlich geschrieben.
- Tutorialspoint bietet eine Schritt für Schritt Anleitung zur Implementation des MVC Patterns und erklärt dabei jeden Schritt so, dass man versteht, was der Code tut.
- Der Artikel des Mark Health Blogs erläutert das MVP Pattern und nennt einige Vorteile. Ausserdem ist eine Demo auf Github verlinkt.


