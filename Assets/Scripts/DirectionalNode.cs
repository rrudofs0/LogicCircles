using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNode : MonoBehaviour
{
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string current;
    SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        SwitchSprite();
    }

    void Update()
    {
        
    }

    void SwitchSprite()
    {
        if(current == "left")
        {
            sr.sprite = left;
        }
        else if(current == "right")
        {
            sr.sprite = right;
        }
        else
        {
            sr.sprite = none;
        }
    }
}
