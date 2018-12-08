# CORE UI

## 01 - Hello, World!

We are currently working in the 2D template.

To add a text object we right click the hierarchy window and choose
`[UI] => [Text]`

When we do this Unity automatically creates new `Canvas` and `EventSystem` objects for us.

The `Rect Transform` at the top of the inspector is the placement of the current element on the `Canvas`. If you want to select a new position you hold `[shift]+[alt]` and click the desired preset.

### Rich Text

There are some supported HTML-style markups

Bold

```
I am <b>bold</b>
```

Italic

```
I am <i>italic</i>
```

Color

```
I am <color=green>green text</color> but I am <color=#FF0000>red</color>
```

[Unity Docs Reference](https://docs.unity3d.com/Manual/StyledText.html "Unity Docs Reference")

## 02 - Displaying a digital clock

project includes the script `ClockDigital.cs`

Script components can be added to GameObjects by

- clicking on `[Add Component]`
- go down to scripts
- select the script you want to add

you can also drag the script into the inspector when the object is highlighted

Notice that as well as the 2 standard default C# packages `UnityEngine` and `System.Collections` you need to add 2 more.

- `UnityEngine.UI`
  -- Because the code uses the UI Text Object
- `System`
  -- Because it stores the DateTime object that we need access to.

We set a variable to the component we want to access `bananna` and access it's text by setting `bananna.text` to our new string.

We get the component in the `Awake(){}` method and update the string every frame with the `Update(){}` method

## 03 - Displaying a digital count-down timer

Project includes the scripts `CountdownTimer.cs` and `DigitalCountdown.cs`

This project required 2 script files. The first was a `CountdownTimer` class that had all the functions necessary to operate the timer. The second one was `DigitalCountdown` that was specific to this game Object only. The `DigitalCountdown` script called a new instance of `CountdownTimer`. `DigitalCountdown` connected to the Text Object that it needed to overwrite and called functions on the instance of `CountdownTimer` passing it things like the number of seconds we wanted to set when starting the timer.

**Note: When these scripts ran I was expecting the timer to run for 30 seconds, but it ended up running for 60 seconds. Need to track this down.**

Also we added both scripts to the inspector, but we could have just added the `DigitalCountdown` script if we used the syntax

```
[RequireComponent(typeof (CountdownTimer))]
```

directly above the class declaration. This will automatically create a new instance of the class for us.

## 04 - Crating a message that fades away

Starts with a copy of the previous level and modifies it from there. It reuses the `CountdownTimer` class but not the `DigitalCountdown`. We will be writing a new script called `FadeAway`

In fact we removed the instance of CountdownTimer all together and used the `RequireComponent` syntax described above to pull a new instance into the `FadeAway` class.

**Interresting note. I thought the `CountdownTimer` function was not going to show in the inspector window, but since it was required, when I added the instance of `Fade Away` it auto populated both script components**

Also the next part was so cool I am dropping the script in the notes for reference

```
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof (CountdownTimer))]
public class FadeAway : MonoBehaviour {
	private CountdownTimer countdownTimer;
	private Text textUI;

	void Awake () {
		textUI = GetComponent<Text>();
		countdownTimer = GetComponent<CountdownTimer>();
	}

	void Start () {
		countdownTimer.ResetTimer(5);
	}

	void Update () {
		float alphaRemaining = countdownTimer.GetProportionTimeRemaining();
		print (alphaRemaining);
		Color c = textUI.color;
		c.a = alphaRemaining;
		textUI.material.color = c;
	}
}
```

Notice in the `Update` method we are retrieving the current color of the Text object. Next it assigns an alpha channel to the copy of the color. Finally it takes the orrigional Text Object and replaces the color with the modified color.

Because we are using a float we get a smooth transition, and as the time remaining goes down the color becomes more transparent **woot**!

**One more note! If we now try to remove the CountdownTimer component from the inspector we get an alert saying "Can not remove: required by Fade Away Script"**

## Displaying a 3D text mesh

Now using the 3D template. Created `Scrollz` C# script to handle the movement.

`Scrollz` is accessing `transform.position` and `transform.TransformDirection(0, 1, 0)` in order to move the text up in the y axis.

We also edited the FOV (Field of view) of the main camera to it's highest position to make sure the text dissapeared to a vanishing point.

## Creating sophisticated text with text mesh pro

For this project we started with the 3D template. The instructions said that text mesh pro may be incorporated into the core of unity in the future. When I added the TextMesh Pro UI object I was prompted to import TMP essentials. The old way of importing from the Unity Store broke the project origionally but this method is working.

TMP requires SDF fonts. They were missing from the follow along assets repo. I found them in a repo dedicated to this project. I went ahead and forked the origional assets repo, added the fonts, removed a duplicate copy of the chapter 3 assets that were in the chapter one folder, and submitted a PR. Figured it was better to propose a fix instead of complaining about it. Only time will tell if it gets merged to the main asset repo, but it would be awesome to contribute and help those who take this journey after me.

Unfortunately after all that, the TextMesh Pro object would not accept the new fonts. Might be because of using the free version. Final result using the default font was a little underwhelming.

## Displaying an image

Project is starting with the 2D template.

To start with they requested a game resolution of 400 x 300. We achieved this by going to the `Game` tab, selecting the current aspect ratio, and creating a new preset.

To get an image game object, in the heirarchy window you right click and select `UI` => `Raw Image`.

In the inspector of the RawImage object we add the image by selecting Texture, and setting it to the image file. Then click the `Set Native Size` button to remove the aspect ratio distortion.

Then we used the `Rect Transform` window to position the image top, and center.
