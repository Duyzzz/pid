#include "PID.h"

void setEncoderPin(unsigned char *encAPinS,
    unsigned char *encBPinS){
        encAPin = encAPinS;
        encBPin = encBPinS;
}
void setMotorPin(unsigned char *In1, unsigned char *In2, unsigned char *Pwm){
    in1 = In1;
    in2 = In2;
    pwm = Pwm;
}
void pwmOut(short out){
    
}