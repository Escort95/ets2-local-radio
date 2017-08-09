# ETS2/ATS Local Radio

ETS2/ATS Local Radio plays radio from where you are, in ETS2. Feel the immersion when the Swedish radio plays in Sweden,
and the Polish radio in Poland. It will switch automatically, while also allowing you to switch stations while driving.


ETS2 Local Radio contains over 500 radio stations that you could realistically listen to if you were driving in that actual country.
Most national radio stations are included; see the full list at the bottom of this page. 
It does not include radio stations that you would not be able to receive over FM or DAB in that country, like TruckersFM.
However, you can add those yourself if you so desire.

**Supported maps:**

ETS2: Default, Going East, Scandinavia, France, ProMods, RusMap, Southern Russia, Project Balkans*, Egypt Add-on, YKS Turkey*, Russian Open Spaces* and Italy Map.
\*Disabled by default

ATS: California, Nevada, Arizona.

**It's available in over 20 languages!**
Not available in yours? [Translate it](https://github.com/Koenvh1/ets2-local-radio/blob/master/web/lang/en-GB.json) and send it to me. I will add it in the new release.

[![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=KAX2AA9B85BAE)

## How to install it:

1. Download ETS2 Local Radio from the [releases page](https://github.com/Koenvh1/ets2-local-radio/releases)
2. Extract it wherever you like
3. Execute ETS2 Local Radio server.exe
4. Click the "Install plugin for Euro Truck Simulator/American Truck Simulator" button.
5. Open ETS2 Local Radio (or go to [http://localhost:8330](http://localhost:8330)) and have fun.

Additionally, you may want to look at the `web/config.js` file and set some additional settings to make the make your experience even better.
Please make sure that the keys and buttons you assign in ETS2 Local Radio are not assigned in game as well.

Make a station favourite to always switch to that station when entering the country it's located in.

## Reporting an issue:
Found a station that does not work, a wrong (or incomplete) translation or something else? 
Please open [an issue](https://github.com/Koenvh1/ets2-local-radio/issues) or post it on the ProMods/SCS forum.
Suggestions are welcome as well of course.

## Troubleshooting:
_The game crashes on exit!_

This is caused by the d3d9.dll file, used to display the overlay.
It can be fixed by either removing this file (which will disable the overlay), 
or by replacing the d3d9.dll in your `{ATS/ETS2 installation}\bin\win_x64` folder with this one:
[https://github.com/Koenvh1/ets2-local-radio/tree/master/plugins/alternative_d3d9.dll](https://github.com/Koenvh1/ets2-local-radio/tree/master/plugins/alternative_d3d9.dll)
([Direct link](https://github.com/Koenvh1/ets2-local-radio/raw/master/plugins/alternative_d3d9.dll/d3d9.dll))

Please bear in mind that it is experimental, so it may crash your game, kill your kittens or destroy the universe.

_Can't access it from another device_

Please make sure your firewall is not blocking the connection. 
If you use a different firewall that Windows Firewall, then please allow incoming connections on port 8330.
You can test whether the firewall is the issue by going to [http://localhost:8330](http://localhost:8330), 
if that works, it is most likely a firewall issue. 
Add ETS2 Local Radio server and/or incoming port 8330 (TCP) to the exceptions list (consult your firewall's manual how to do that),
or just use [http://localhost:8330](http://localhost:8330).

If it does not work on localhost either, then please try changing the default port in the `settings.json` file.

_It says the simulator is not running even though it is!_

This might be due to the fact that a dependency was not loaded properly.
Please try the following:
* Restart the game
* Open the `My Documents\{American Truck Simulator/Euro Truck Simulator 2}\game.log.txt` file,
check whether it contains the following lines:
```
00:00:18.261 : loading 'ets2-telemetry' '/Euro Truck Simulator 2/bin/win_x86/plugins/ets2-telemetry.dll'
00:00:18.262 : unable to load: 0000007E
```
* If that is the case, then please try installing the following:
https://www.microsoft.com/en-gb/download/details.aspx?id=48145 (or from https://github.com/Koenvh1/ets2-local-radio/tree/master/plugins/visual_c%2B%2B_redistributable)
and **restart your computer**
* If it contains something like this:
```
00:00:20.006 : loading 'ets2-telemetry' 'X:/Path/Euro Truck Simulator 2/bin/win_x86/plugins/ets2-telemetry.dll'
[...]
00:00:20.006 : <ERROR> [sdk] prism::sdk::lookup_channel: channel 'truck.adblue.consumption.average' not found
00:00:20.006 : <ERROR> [sdk] prism::sdk::lookup_channel: SCS_U32_NIL is not valid parameter for array channel 'truck.hshifter.select'
00:00:20.006 : <ERROR> [sdk] prism::sdk::telemetry_register_for_channel: channel 'truck.electric.enabled' index 4294967295 has already callback for type 1
00:00:20.006 : <ERROR> [sdk] prism::sdk::telemetry_register_for_channel: type 1 is not supported by channel 'truck.light.aux.front' index 4294967295
00:00:20.006 : <ERROR> [sdk] prism::sdk::telemetry_register_for_channel: type 1 is not supported by channel 'truck.light.aux.roof' index 4294967295
00:00:20.006 : <ERROR> [sdk] prism::sdk::lookup_channel: channel 'truck.adblue.consumption.average' not found
```
* Please check whether your volume slider is above 0%
* Check whether a different browser (Firefox/Edge) does work
* Try playing another station
* If it does not contain `loading 'ets2-telemetry'`, 
then please try to reinstall the plugin by pressing the "Install plugin" button, or manually copy the content of `\ETS2 Local Radio\plugins\bin` to
`\Steam\SteamApps\common\Euro Truck Simulator 2\bin`

_The game crashes when changing the graphics settings_

Some systems/graphics cards may have this issue. Please try removing the plugin by clicking "Remove plugin", then change your graphics settings and install the plugin again.

_The editor will not load with the overlay installed_

There is as of yet no solution for this problem, and I very much doubt that there ever will be given that DirectX 9 is very picky and this problem affects very few people.

_Somethings else does not work!_

Try restarting ETS2/ATS, rebooting your PC, and reloading the ETS2 Local Radio web page (as your browser may still have an invalid cached version of the page). 
If that does not work, then please open [an issue](https://github.com/Koenvh1/ets2-local-radio/issues) or post it on the ProMods/SCS forum. Include the `Error log.txt` file if possible.

## How to uninstall it:

Just remove the ETS2 Local Radio folder or, if you used the installer, remove it using the Control Panel.
You will need to manually remove the following files from the ETS2/ATS installation directory as well:
* `\bin\win_x64\d3d9.dll` 
* `\bin\win_x64\plugins\ets2-telemetry.dll`
* `\bin\win_x86\d3d9.dll`
* `\bin\win_x86\plugins\ets2-telemetry.dll`

## General information:

### How the system works:

Every city acts as a transmission tower with a certain range, and every city is bound to a country. 
The program check the distance to every city, and when it is within reach, the stations for that country are displayed.
When a city from a different country is closer than the one currently connected to (with a treshold), the radio automatically switches to that country.

### What does that coverage map show?

It shows all the transmission towers (the cities), with a range circle. 
The black inner ring is the clear audio border (~20% static).
Each country has its own (random) colour, to make it easier to see the difference between them.

### What is a favourite?

Once you enter a different country, the radio will automatically switch to a station from that country.
Normally this is the first available station, but if you set a station as your favourite, that station will be played instead.
You can also quickly switch to that station if you assign a key/button to the "Switch to favourite" option.

### Can I add my own stations?

Yes you can! Just head over to the [submit station](https://koenvh.nl/submit-station) page. 
If it is accepted, it will be added in the next update.
However, maybe your station does not meet the criteria (web only, does not broadcast in the majority of a country),
but you still want to add it. That's possible too. 
Just go to the `\web\stations\stations-custom.example.js` file, rename it to `stations-custom.js` and add your own stations there.
More information on that can be found in that file as well.

##### Why does it have to broadcast in a majority of the country?
 
Let us take a local radio station from France as an example:

Imagine a radio station that has a range of 50km in real life (which is quite a lot), so a diameter of 100km. 
Now, ETS2 has a scale of 1:19, so that would be 5.26km in ETS2. If you drive at 80km/h, 
you'll be able to listen to it for 0.066 hours or about four minutes, which is less than the time of one song. 
And that's when you go right through the middle of the coverage circle, it will be even shorter if you don't. 
You can already see (or actually hear) this problem by driving through Luxembourg, as Luxembourg is quite a small country.

The problem you create then is that the radio constantly switches stations, which is not really desirable. 
I worked around this in ATS, where radio stations are licensed per city instead of per state, 
by making the range unrealistically large and making it switch later than in ETS2, but the problem still exists there too.

### Can you support map x?

Maybe, maybe not. You can always send in a request.
* ATS maps will not be added unless you provide at least one station per new **city**.
* ETS2 maps will not be added unless you provide at least one station per new **country**. 

##### How about Project Balkans, Open Spaces or YKS Turkey?

A persisting problem is that some maps are incompatible with each other.
For that reason, some custom maps are not enabled by default.
You may want to edit the `\web\cities\cities-ets2.js` file, scroll to the bottom and uncomment the lines for Project Balkans, YKS Turkey and/or Open Spaces.
This will reset when you update ETS2 Local Radio.

### Why do Chrome, Opera, Internet Explorer and others not work fully?

ETS2 Local Radio can only include the stream types a station offers, and these vary station by station.
One can roughly group them in four groups:
* MP3
* AAC
* HLS
* OGG

Now, the problem is that not all browsers support all stream types.
One main problem is an MP3 stream from a server using ShoutCast v1, as Chrome discontinued HTTP/0.9 support on non-standard ports, [something ShoutCast v1 still uses](https://bugs.chromium.org/p/chromium/issues/detail?id=669800).
To put it all in a table:

|                   | MP3 | AAC | HLS | OGG | ShoutCast v1 |
|-------------------|-----|-----|-----|-----|--------------|
| Chrome            | Yes | Yes | Yes | Yes | No           |
| Edge              | Yes | Yes | Yes | Yes | Yes          |
| Firefox           | Yes | Yes | Yes | Yes | Yes          |
| Internet Explorer | Yes | No  | Yes | No  | Yes          |
| Opera             | Yes | Yes | Yes | Yes | No           |

You can see why I recommend Firefox or Edge. 
I have considered using VLC for the playback, but the CPU usage for HLS streams would regularly exceed 30%, something I don't consider acceptable.
Over time stations will probably fix their playback for Chrome and Opera, but I can't do it for them.

* _Update 2017-04-24: It seems like most stations have fixed their playback for Chrome and Opera now._ 
* _Update 2017-06-26: Actually, Chrome and Opera made an exception for ShoutCast. Still works though._

## Thanks to:

I could not have possibly done this alone, so thanks to the following people:
* SCS Software for creating ETS2
* **nlhans for creating the [ETS2 SDK plugin](https://github.com/nlhans/ets2-sdk-plugin)**
* **Michael Koch for creating [GPP](http://www.mikoweb.eu/?page_id=54)**
* All the translators
* Everyone who submitted a new station
* You, the user

## Screenshots:
![Screenshot](https://i.imgur.com/J3ycEJB.png)

_The server window_

![Screenshot](https://i.imgur.com/5naBcXw.jpg)

_The in-game view when switching stations (if the overlay is installed)_

![Screenshot](https://i.imgur.com/B4OBEPV.png)

_Another in-game view when switching stations (if the overlay is installed)_

![Screenshot](https://i.imgur.com/UaA9h1t.png)

_All available stations in ATS as of 1.12.0_

![Screenshot](https://i.imgur.com/aV0kV9H.png)

_All available stations in ETS2 as of 1.11.0_