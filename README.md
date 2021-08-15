![](https://dualznz.space/static/Octo-Streamer/ico.png)

# Octo-Streamer

This desktop application was created to allow you to stream your printers status from OctoPrint to various software such as OBS, SLOBS, X-Split and others.

The software pushes live updates to various text files located in the application /stream directory.

To launch this application just click on Octo-Streamer executable file ![](https://dualznz.space/static/Octo-Streamer/ostreamEXE.png)

### Connecting To OctoPrint Server

When first launching the application you will be greeted with the **New Connection** window, from here you can fill in the required information in order to communicate with your server.

- Host - the url for your printer eg *http://192.168.10.10*
- Port - **(Optional)** The port used to connect to the server in your url eg *8080*
- API Key - The global API key to access your server, information on getting this can be found [here...](https://docs.octoprint.org/en/master/api/general.html#authorization)

Then to connect to your OctoPrint server just click **Connect to Server** under File/ tool strip

### Accessing Stream Data

To access the stream data to add to your stream, simply go to the **Application Folder / stream** or **Tools/Application Data** within the application, there you will find multiple folders which contain the various values that get parsed to the files in real-time within the application.

### Adding Stream Data To OBS

OBS (Open Broadcasting Software) has made it exceptionally easy to add new text sources to your scene, as the data files are Text files (.txt) we can use the following source **Text (GDI+)**, to add a source click on the  ![](https://dualznz.space/static/Octo-Streamer/plus.png)icon under your **Sources Area**.

Then next we need to add the type which in our case will be **Text (GDI+)** 

![](https://dualznz.space/static/Octo-Streamer/source.png)

Finally we need to add the location of txt file you wish to use ![](https://dualznz.space/static/Octo-Streamer/medialink.png)

Ensure you click on **Read from file** then browse to the application folder **/stream/** whichever directory / file you wish to use, you can then change the color, size, font and so forth like you would do with any other text source within OBS.

### Addons

The application also has values contained within the following plugin(s):

- DisplayLayerProgress **(Optional)**

To activate the additional values within the application head over to **Tools/Application Settings** to activate the plugins

### Todo

- [ ] Remove global key & change to Application Token within OctoPrint
- [ ] Allow change from Celsius to Fahrenheit

### Issues

If you wish to add an issue / Request please head over to our Issues Tab

License

- [GNU GPL v3](https://www.gnu.org/licenses/gpl-3.0.html)
- Copyright 20