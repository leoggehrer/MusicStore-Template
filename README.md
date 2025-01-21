# MusicStore

------

**Lernziele**

- Diese Vorlage dient als Ausgangspunkt für verschiedenste Aufgaben.

## MusicStore

Das Projekt **'MusicStore'** ist ein kleines datenzentriertes Anwendungsbeispiel mit welchem die Erstellung eines Software-Systems dargestellt werden soll. Aufgrund der Komplexität, die ein Software-System im Allgemeinem darstellt, ist die Erstellung des Beispiels in mehreren Themenbereichen unterteilt. Jedes Thema beginnt mit diesem Vorlage und wird entsprechend der jeweiligen Aufgabenstellung erweitert. 

### Vorlage

In dieser Vorlage gibt es bereits zwei unterschliedliche Projekte:

|Name|Beschreibung|
|---|---|
|MusicStore.ConApp| Eine Konsolen-Anwendung zum Starten der Anwendung. Hier werden unterschiedliche  |
|MusicStore.Logic|In diesem Projekt sind alle Schnittstellen, Models und Geschäftslogiken von MusicStore implementiert.|
|MusicStore.Logic.Contracts|In diesem Abschnitt befinden sich alle Schnittstellen.|
|MusicStore.Logic.Models|In diesem Abschnitt befinden sich alle Daten-Objekte (PoCo).|
|MusicStore.Logic.DataContext|In diesem Abschnitt befindet sich der Daten-Kontext (`MusicStroeContext`). Diese transformiert die csv-Daten in die in die Daten-Objekte und stellt einen Zugriff auf diese Objekte bereit.|
|MusicStore.Logic.Statistics|In diesem Abschnitt befindet sich die Logik zur Auswertung der Statistik. Die Klasse hat den Namen `MusicStoreStatistics` und stellt die verschiedenen Methoden zur Abfrage der Statistik-Kennzahlen zur Verfügung.|

### Grundsystem

**MusicStore** Erstellen Sie die Projektstruktur von MusicStore und fassen Sie die einzelnen Projekte zu einer Solution zusammen. Die Struktur besteht aus den Projekten:

|Name|Beschreibung|
|---|---|
|MusicStore.ConApp|Eine Konsolen-Anwendung zum Laden der csv-Daten und zum Ausgeben der Kennzahlen.|
|MusicStore.Logic|In diesem Projekt sind alle Schnittstellen, Models und Geschäftslogiken von MusicStore implementiert.|
|MusicStore.Logic.Contracts|In diesem Abschnitt befinden sich alle Schnittstellen.|
|MusicStore.Logic.Models|In diesem Abschnitt befinden sich alle Daten-Objekte (PoCo).|
|MusicStore.Logic.DataContext|In diesem Abschnitt befindet sich der Daten-Kontext (`MusicStroeContext`). Diese transformiert die csv-Daten in die in die Daten-Objekte und stellt einen Zugriff auf diese Objekte bereit.|
|MusicStore.Logic.Statistics|In diesem Abschnitt befindet sich die Logik zur Auswertung der Statistik. Die Klasse hat den Namen `MusicStoreStatistics` und stellt die verschiedenen Methoden zur Abfrage der Statistik-Kennzahlen zur Verfügung.|

Verbinden Sie die Abhängigkeiten der einzelnen Projekte untereinander.

**Funktionsumfang** Laden Sie die csv-Daten in das Objektmodell und ermitteln Sie die statistischen Kennzahlen mit Linq.

|Name|Beschreibung|
|---|---|
|*Artist und Album*|Geben Sie den Artisten und die Alben aus.|
|*Artist und Titeln*|Geben Sie den Namen des Artisten und Songs aus.|
|*Artist und Songzeit*|Geben Sie den Namen des Artisten, die gesamte Songzeit und die durchschnittliche Songzeit aus.|
|*Album und Titeln*|Geben Sie den Titel des Albums und deren Titeln aus.|
|*Album und Songzeit*|Geben Sie den Titel des Albums, die gesamte Songzeit und die durchschnittliche Songzeit aus.|
|*Durchschnitt der Songzeit eines Genres*|Gesamte und durchschnittliche Songzeit eines Genres in Sekunden.|
|*Durchschnitt der Songzeit eines Album*|Gesamte und durchschnittliche Songzeit eines Albums in Sekunden.|
|*Durchschnitt der Songzeit eines Titels*|Gesamte und durchschnittliche Songzeit eines Titels in Sekunden.|
|*Genre und Anzahl*|Geben Sie das Genre und die Anzahl der Titeln aus.|

**Anmerkung**: Es darf nur Linq verwendet werden - keine Schleifen.

### Testen des Systems

Überprüfen Sie die Kennzahlen mit Excel!

## Hilfsmitteln

- keine Angaben

## Abgabe

- Termin: 1 Woche nach der Ausgabe

- Klasse:

- Name:

## Quellen

- keine Angabe

> **Viel Erfolg!**
