using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public static bool largeBall = false;
    public static float playerSpeed = 800.0f;
    public static int ballColor = 1;

    public Slider SpeedSlider;
    public Dropdown Colors;

    public void ToggleSize()
    {
        largeBall = true;
    }

    public void ChangeSpeed()
    {
        playerSpeed = SpeedSlider.value;
    }

    public void ChangeColor()
    {
        switch (Colors.value)
        {
            case 1:
                ballColor = 1;
                break;
            case 2:
                ballColor = 2;
                break;
            case 3:
                ballColor = 3;
                break;
        }
    }
}
