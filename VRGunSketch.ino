const int potentiometer = {A0};

void setup() {

}

void loop() {
  Serial.begin(9600);
  Serial.println(analogRead(potentiometer));
  delay(20);
  Serial.flush();
}
