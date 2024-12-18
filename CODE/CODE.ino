#include <Keyboard.h>

// Define button pins (pins 2 to 14)
const int buttonPins[] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};  // Pins for buttons
const char keyMappings[] = {'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'w', 'e', 't', 'y'};  // Corresponding characters

void setup() {
  // Initialize button pins as input with internal pull-ups
  for (int i = 0; i < 13; i++) {
    pinMode(buttonPins[i], INPUT_PULLUP);
  }
  
  Keyboard.begin();  // Start keyboard emulation
}

void loop() {
  for (int i = 0; i < 13; i++) {
    bool buttonState = digitalRead(buttonPins[i]) == LOW;  // Check if the button is pressed (active low)

    if (buttonState) {
      Keyboard.press(keyMappings[i]);  // Send the corresponding key press
    } else {
      Keyboard.release(keyMappings[i]);  // Release the key when the button is not pressed
    }
  }

  delay(10);  // Small delay for debounce
}