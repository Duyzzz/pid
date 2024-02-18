#ifndef INC_PID_R_V1_H
#define INC_PID_R_V1_H

#include "stm32f1xx_hal.h"

unsigned char *encAPin;
unsigned char *encBPin;
unsigned char *in1;
unsigned char *in2;
unsigned char *pwm;
void setEncoderPin(unsigned char *encAPinS,
    unsigned char *encBPinS);
void setMotorPin(unsigned char *In1, unsigned char *In2, unsigned char *pwm);
void cmdHBridge(char dir, short pwmVal, ){

}

#endif /*INC_PID_R_V1_H*/ 