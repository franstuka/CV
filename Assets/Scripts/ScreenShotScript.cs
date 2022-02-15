using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShotScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ScreenShot();
        }
    }

    public void ScreenShot()
    {
        Debug.Log("Kartoffel. Search in the route of the project");
        ScreenCapture.CaptureScreenshot("Resume.png");
    }
}
