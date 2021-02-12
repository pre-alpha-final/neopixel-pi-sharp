#Introduction
A C# way of controlling AdaFruit's NeoPixel hardware on a Raspberry Pi. Well not really. In reality the code still runs CircuitPython on the Adafruit-Blinka abstraction layer (which allows CircuitPyton to run on Pi). C# just executes the python interpreter to run the scripts.

In essence it is a minimalistic setup for running NeoPixel hardware "using C#". Simple copy-paste instructions and a few lines of code. Tested on Raspberry Pi Zero W.

#Installation
The steps are (describted in detail [here](https://learn.adafruit.com/circuitpython-on-raspberrypi-linux/installing-circuitpython-on-raspberry-pi "link"))
```
# Update system
sudo apt update
sudo apt upgrade
```
```
# Install Adafruit-Blinka
cd ~
sudo pip3 install --upgrade adafruit-python-shell
wget https://raw.githubusercontent.com/adafruit/Raspberry-Pi-Installer-Scripts/master/raspi-blinka.py
sudo python3 raspi-blinka.py
```
```
# Install NeoPixel driver
sudo pip3 install adafruit-circuitpython-neopixel
sudo pip3 install rpi_ws281x
```
and that's that. The attached app demonstates how to run a python script utilizing the NeoPixel driver.