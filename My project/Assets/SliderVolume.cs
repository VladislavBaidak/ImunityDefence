using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVolume : MonoBehaviour
{
    public Slider volume;

    public void ChangeVolume()
    {
        AudioListener.volume = volume.value;
    }

}
