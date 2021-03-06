const int Potentiometer = {A0};
int outputValue;


void setup() {
  pinMode(13, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  
  digitalWrite(13, HIGH);
  if (analogRead(Potentiometer) > 1020){
    outputValue = 8;
  }
//  else if (analogRead(Potentiometer) > 1012){
//    outputValue = 19;
//  }
  else if (analogRead(Potentiometer) > 986){
    outputValue = 7;
  }
//  else if (analogRead(Potentiometer) > 960){
//    outputValue = 17;
//  }
  else if (analogRead(Potentiometer) > 916){
    outputValue = 6;
  }
//  else if (analogRead(Potentiometer) > 872){
//    outputValue = 15;
//  }
  else if (analogRead(Potentiometer) > 816){
    outputValue = 5;
  }
//  else if (analogRead(Potentiometer) > 756){
//    outputValue = 13;
//  }
  else if (analogRead(Potentiometer) > 682){
    outputValue = 4;
  }
//  else if (analogRead(Potentiometer) > 610){
//    outputValue = 11;
//  }
  else if (analogRead(Potentiometer) > 546){
    outputValue = 3;
  }
//  else if (analogRead(Potentiometer) > 466){
//    outputValue = 9;
//  }
  else if (analogRead(Potentiometer) > 360){
    outputValue = 2;
  }
//  else if (analogRead(Potentiometer) > 240){
//    outputValue = 7;
//  }
  else if (analogRead(Potentiometer) > 122){
    outputValue = 1;
  }
//  else if (analogRead(Potentiometer) > 20){
//    outputValue = 5;
//  }
  else {
    outputValue = 0;
  }

  Serial.begin(9600);
  Serial.println(outputValue);
  Serial.flush();
  delay(20);
}
