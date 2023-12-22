using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scrolling : MonoBehaviour
{
    [SerializeField] private RawImage img;
    [SerializeField] public float _x, _y;

    void Update()
    {
        img.uvRect = new Rect(img.uvRect.position + new Vector2(_x,_y) * Time.deltaTime,img.uvRect.size);
    }
}
