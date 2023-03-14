from asyncore import loop
import RPi.GPIO as GPIO
import time

red = 4
yellow = 3
green = 2

def init():
    GPIO.setmode(GPIO.BCM)
    GPIO.setup(red, GPIO.OUT)
    GPIO.setup(yellow, GPIO.OUT)
    GPIO.setup(green, GPIO.OUT)

def loop():
    while True:
        try:
            GPIO.output(red, GPIO.HIGH)
            time.sleep(2)
            GPIO.output(yellow, GPIO.HIGH)
            time.sleep(1)
            GPIO.output(red, GPIO.LOW)
            GPIO.output(yellow, GPIO.LOW)
            GPIO.output(green, GPIO.HIGH)
            time.sleep(1)
            GPIO.output(green, GPIO.LOW)
        except KeyboardInterrupt:
            GPIO.cleanup()

init()
loop()
