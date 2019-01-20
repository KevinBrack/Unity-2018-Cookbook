# Responding to User Events for Interactive UIs

## 01 - Creating UI buttons to move between scenes.

Using the 2D template.

Go to `file >> build settings` to modify the list of available scenes in the build.

Removed the default sample scene and added 2 of my own.

Each scene had a different text object and button to navigate to the other

Added a script to the `Main Camera` object to navigate between scenes

```
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadOnClick(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
```

The button for each scene by default has a button script. That had an onclick section
that I used to add another script. First I needed to drag the Main Camera from the
object hirearchy in to the object input field. Then I was able to select the SceneLoader script and select it to run onclick. This presented a field to input an integer to pass to the script. Scene 1 navigated to int 1, and scene 2 navigated to int 0, since in the build settings we modified earlier the scenes are stored as a 0 based array.
