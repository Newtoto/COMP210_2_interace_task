const int Potentiometer = {A0};
int outputPin = {13};
int Delay;


void setup() {
  pinMode(13, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  
  digitalWrite(13, HIGH);
  if (analogRead(Potentiometer) > 1020){
    Delay = 20;
  }
  else if (analogRead(Potentiometer) > 1012){
    Delay = 19;
  }
  else if (analogRead(Potentiometer) > 986){
    Delay = 18;
  }
  else if (analogRead(Potentiometer) > 960){
    Delay = 17;
  }
  else if (analogRead(Potentiometer) > 916){
    Delay = 16;
  }
  else if (analogRead(Potentiometer) > 872){
    Delay = 15;
  }
  else if (analogRead(Potentiometer) > 816){
    Delay = 14;
  }
  else if (analogRead(Potentiometer) > 756){
    Delay = 13;
  }
  else if (analogRead(Potentiometer) > 682){
    Delay = 12;
  }
  else if (analogRead(Potentiometer) > 610){
    Delay = 11;
  }
  else if (analogRead(Potentiometer) > 546){
    Delay = 10;
  }
  else if (analogRead(Potentiometer) > 466){
    Delay = 9;
  }
  else if (analogRead(Potentiometer) > 360){
    Delay = 8;
  }
  else if (analogRead(Potentiometer) > 240){
    Delay = 7;
  }
  else if (analogRead(Potentiometer) > 122){
    Delay = 6;
  }
  else if (analogRead(Potentiometer) > 20){
    Delay = 5;
  }
  else {
    Delay = 4;
  }

  digitalWrite(outputPin, HIGH);
  Serial.begin(9600);
  Serial.println(Delay);
  delay(Delay);
}
