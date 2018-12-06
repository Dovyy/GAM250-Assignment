using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour, Observer
{
    public static HUDManager instance;

    public Text MyText;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void OnNotify(EventData data)
    {
        MyText.text = (data as PlayerData).score.ToString();
    }
}
