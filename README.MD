#Introduction
A C# way of controlling AdaFruit's NeoPixel hardware. Well not really. In reality the code still runs CircuitPython but it's abstracted by Adafruit-Blinka (which allows CircuitPyton to run on Pi), that in turn is abstracted by IronPython (which allows executing python in C#).

This project s a minimalistic poc of such setup. Simple copy-paste instructions and a few lines of code. Tested on Raspberry Pi Zero W.

#Setup
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
```
and that's that. The attached app demonstates how to call python code using IronPython nuget (better describted [here](https://www.needfulsoftware.com/IronPython/IronPythonCS "here")).