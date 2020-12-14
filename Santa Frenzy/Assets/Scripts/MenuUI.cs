using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuUI : MonoBehaviour
{
    public RectTransform Levels , info;
    public GameObject Logo, button1, button2;
    public Vector2[] xy;
    // Start is called before the first frame update
    void Start()
    {
        Logo.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
        Levels.DOAnchorPos(xy[0], 0.1f);
        info.DOAnchorPos(xy[2], 0.1f);
    }

    // Update is called once per frame
    public void DoLevels()
    {
        Logo.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        Levels.DOAnchorPos(xy[1], 0.5f);
        NoInfo();
    }

    public void NoLevels()
    {
        Logo.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
        Levels.DOAnchorPos(xy[0], 0.5f);
    }

    public void Info()
    {
        info.DOAnchorPos(xy[3], 0.5f);
    }

    public void NoInfo()
    {
        info.DOAnchorPos(xy[2], 0.5f);
    }
}
