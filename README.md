# HTTP Server

Ein selbst entwickelter HTTP-Server in C#, der von Grund auf aufgebaut wird.

Das Projekt ist Teil meiner persönlichen Lernprojekte und dient dazu, mein Verständnis für **Netzwerkkommunikation, HTTP, TCP und Softwareentwicklung mit C#** zu vertiefen.

Der Server wird Schritt für Schritt erweitert. Dabei geht es nicht darum, möglichst schnell einen vollständigen Webserver zu entwickeln, sondern die einzelnen technischen Grundlagen selbst zu verstehen und umzusetzen.

## Ziele

Mit diesem Projekt möchte ich unter anderem lernen:

* Wie funktioniert HTTP auf technischer Ebene?
* Wie kommunizieren Client und Server miteinander?
* Wie funktionieren TCP-Verbindungen und Sockets?
* Wie werden HTTP-Requests verarbeitet?
* Wie werden HTTP-Responses aufgebaut?
* Wie funktioniert Routing?
* Wie können mehrere Verbindungen verarbeitet werden?
* Wie kann ein Server strukturiert und erweitert werden?
* Wie lassen sich Fehlerbehandlung und Logging sinnvoll umsetzen?

## Geplanter Funktionsumfang

Der Server wird schrittweise entwickelt.

### Grundlagen

* [ ] TCP-Verbindung aufbauen
* [ ] Auf eingehende Verbindungen warten
* [ ] HTTP-Request empfangen
* [ ] HTTP-Request analysieren
* [ ] HTTP-Response erstellen
* [ ] Einfache HTML-Datei zurückgeben

### HTTP

* [ ] HTTP-Methoden verstehen und verarbeiten
* [ ] Request-Header auslesen
* [ ] Response-Header erstellen
* [ ] Statuscodes unterstützen
* [ ] Request-Body verarbeiten
* [ ] Content-Type berücksichtigen

### Server-Funktionen

* [ ] Routing implementieren
* [ ] Statische Dateien ausliefern
* [ ] Fehlerseiten hinzufügen
* [ ] Logging implementieren
* [ ] Mehrere Clients unterstützen
* [ ] Saubere Trennung der Verantwortlichkeiten

### Erweiterungen

* [ ] Konfiguration des Servers
* [ ] Graceful Shutdown
* [ ] Tests hinzufügen
* [ ] Performance untersuchen
* [ ] HTTP-Keep-Alive untersuchen
* [ ] Weitere HTTP-Funktionen nach Bedarf

Der Umfang kann sich während der Entwicklung verändern. Neue Funktionen werden ergänzt, sobald sie für das Verständnis des Projekts sinnvoll sind.

## Technologie

* **C#**
* **.NET**
* **TCP / Sockets**
* **HTTP**
* **Git / GitHub**

## Projektstruktur

Die Projektstruktur wird während der Entwicklung entstehen und entsprechend der Anforderungen angepasst.

Eine mögliche Struktur ist:

```text
HttpServer/
├── src/
│   └── HttpServer/
├── tests/
│   └── HttpServer.Tests/
├── docs/
└── README.md
```

## Lernansatz

Das Projekt wird bewusst möglichst nah an den technischen Grundlagen entwickelt.

Dabei möchte ich zunächst verstehen, **was hinter den verwendeten Abstraktionen passiert**, bevor ich fertige Frameworks oder Libraries für die jeweilige Funktionalität einsetze.

Während der Entwicklung dokumentiere ich wichtige Erkenntnisse und Entscheidungen in meinem Lernjournal.

## Lernjournal

Zu diesem Projekt gehört ein persönliches Lernjournal. Dort dokumentiere ich unter anderem:

* Was habe ich an diesem Tag gelernt?
* Was habe ich umgesetzt?
* Welche Probleme sind aufgetreten?
* Wie habe ich die Probleme gelöst?
* Was habe ich noch nicht verstanden?
* Was möchte ich als Nächstes untersuchen?

## Status

Das Projekt befindet sich aktuell in der Entwicklung.

Es handelt sich ausdrücklich um ein **Lernprojekt** und nicht um einen produktionsreifen HTTP-Server.

## Warum dieses Projekt?

Ich möchte meine Fähigkeiten als Softwareentwickler weiterentwickeln und dabei nicht nur mit bestehenden Frameworks arbeiten, sondern auch die Grundlagen verstehen, auf denen viele dieser Technologien aufbauen.

Ein eigener HTTP-Server bietet dafür eine gute Möglichkeit, verschiedene Themen miteinander zu verbinden – von Netzwerkkommunikation und Protokollen bis hin zu sauberer Softwarearchitektur und Fehlerbehandlung.
