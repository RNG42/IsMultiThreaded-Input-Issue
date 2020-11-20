
Following settings seem to work fine (these are currently set in the project):

VSync = VSyncMode.On;
IsMultiThreaded = false;
UpdateFrequency = 60;


Following settings the input get lost:

case 1:

VSync = VSyncMode.Off;
IsMultiThreaded = false;
UpdateFrequency = 60;

case 2:

VSync = VSyncMode.On;
IsMultiThreaded = true;
UpdateFrequency = 60;

case 3:

VSync = VSyncMode.Off;
IsMultiThreaded = true;
UpdateFrequency = 60;
