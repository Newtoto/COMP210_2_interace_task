const int Potentiometer = {A0};
String Output;

void setup() {

}

void loop() {
  Output = String(analogRead(Potentiometer));
  // Get length of potentiometer value and add to start
  if (analogRead(Potentiometer) > 999){
    Output = "4" + Output;
  } else if (analogRead(Potentiometer) > 99) {
    Output = "3" + Output;
  } else if (analogRead(Potentiometer) > 9) {
    Output = "2" + Output;
  } else {
    Output = "1" + Output;
  }

  // Add length of potentiometer value to start
  Serial.begin(9600);
  Serial.println(Output);
  delay(30);
  Serial.flush();
}
