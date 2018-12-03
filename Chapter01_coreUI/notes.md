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
