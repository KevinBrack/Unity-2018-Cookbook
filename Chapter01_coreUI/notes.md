# CORE UI

## Hello, World!

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
