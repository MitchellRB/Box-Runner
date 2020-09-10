using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class ImageFadeOut : MonoBehaviour
{
    [Min(0)] public float fadeTime;

    private RawImage image;

    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<RawImage>();
        image.CrossFadeAlpha(0, fadeTime, true);
    }
}
