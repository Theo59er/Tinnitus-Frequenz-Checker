## How To use in Unity

Dieses Skript in Unity erstellt einen Ton mit variabler Frequenz und ermöglicht es, die Tonhöhe über Benutzeroberflächenkomponenten zu steuern.

### Komponenten:

1. **TextMeshProUGUI für Tonhöhe (Pitchfrequenz):**
   - `public TextMeshProUGUI Pitchfrequenz;`
   - Zeigt die aktuelle Tonhöhe in Hertz an.

2. **Audiokomponente:**
   - `private AudioSource audioSource;`
   - Eine Unity-Komponente zum Abspielen von Audio. Wird im `Start`-Methode initialisiert.

3. **Maximale und minimale Tonhöhe (maxpitch und minpitch):**
   - `int maxpitch = 15000;`
   - `int minpitch = 0;`
   - Definiert den Bereich der möglichen Tonhöhen.

4. **Aktuelle Tonhöhe (pitch):**
   - `public int pitch = 3000;`
   - Die Standard-Tonhöhe in Hertz.

5. **Lautstärke (volume):**
   - `public float volume = 1f;`
   - Die Lautstärke des Tons, standardmäßig auf 1 (maximale Lautstärke) eingestellt.

### Verwendung der Buttons:

1. **StartToneOnClick():**
   - Methode, die vom Start-Button aufgerufen wird. Startet den Ton.

2. **HigherPitchOnClick():**
   - Methode, die vom "Higher Pitch"-Button aufgerufen wird.
   - Erhöht die Tonhöhe zufällig innerhalb des festgelegten Bereichs.

3. **LowerPitchOnClick():**
   - Methode, die vom "Lower Pitch"-Button aufgerufen wird.
   - Verringert die Tonhöhe zufällig innerhalb des festgelegten Bereichs.

### Zusätzliche Informationen:

- **Unendlicher Loop:**
  - Der Ton wird in einer Endlosschleife abgespielt, dies kann in der `Start`-Methode geändert werden.
  
- **Tonstop (Invoke):**
  - Der Ton stoppt nach einer Sekunde. Diese Verzögerung kann in der `Invoke`-Methode angepasst werden.

- **Tonhöhe aktualisieren:**
  - Die aktuelle Tonhöhe wird im `Update`-Methode auf dem UI-Element aktualisiert.

### Hinweis:

Vergewissern Sie sich, dass die erforderlichen Unity-Komponenten wie `TextMeshProUGUI` und `AudioSource` vorhanden sind, und weisen Sie die Buttons den entsprechenden Methoden im Unity-Editor zu.
