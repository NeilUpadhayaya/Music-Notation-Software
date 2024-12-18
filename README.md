# MusicNotationSoftware
This is a unity intergrated Music Notation software paired up with a arduino piano.
# Code

**NoteSpawner**

![Image of Code](https://github.com/NeilUpadhayaya/Music-Notation-Software/blob/main/code%20pt1.png)
![Image of Code](https://github.com/NeilUpadhayaya/Music-Notation-Software/blob/main/code%20pt2.png)
![Image of Code](https://github.com/NeilUpadhayaya/Music-Notation-Software/blob/main/code%20pt3.png)

The images attached above are from the note spawner script. This is what allows the notes to spawn and the background to move. It spawns 5 types of notes; sixteenth, eighth, quarter, half, whole notes. There is also a protocol that spawns a rest when not playing for 4 seconds.

**SharpsAndFlats**

![Image of Code](https://github.com/NeilUpadhayaya/Music-Notation-Software/blob/main/code%20pt4.png)

This script above spawns in sharps and flats depending on the button input. It detects where the note is and puts the sign directly there.

**SoundGenerator**

![Image of Code](https://github.com/NeilUpadhayaya/Music-Notation-Software/blob/main/code%20pt5.png)

The Sound Generator plays sounds when a input is pressed.

**ReplayFunction**

![Image of Code](https://github.com/NeilUpadhayaya/Music-Notation-Software/blob/main/code%20pt%208.png)

This function allows you see replay the sheet music and see the notes you have played.

**Misc Functions**

![Image of Code](https://github.com/NeilUpadhayaya/Music-Notation-Software/blob/main/code%20pt%207.png)
![Image of Code](https://github.com/NeilUpadhayaya/Music-Notation-Software/blob/main/code%20pt%208.png)
![Image of Code](https://github.com/NeilUpadhayaya/Music-Notation-Software/blob/main/code%20pt%209.png)

These scripts control the functions of restarting the software, creating a fade screen when you start the scene, and start/ restart sounds.

**Arduino Code**

![Image of Code](https://github.com/NeilUpadhayaya/Music-Notation-Software/blob/main/Screenshot%202024-10-22%20093651.png)

This script allows the arduino to communicate with the computer by turning its inputs to selective keys on the keyboard.




















