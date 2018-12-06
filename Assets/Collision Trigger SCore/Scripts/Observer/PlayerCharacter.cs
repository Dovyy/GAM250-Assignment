using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCharacter : Subject {

    public static PlayerCharacter instance;

    private PlayerData playerData;

    void Awake ()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
	}
	
	// Update is called once per frame
	public void Start ()
    {
        playerData = new PlayerData();
        AddObserver(HUDManager.instance);
        Debug.Log("NOTIFY");
        Notify(playerData);
	}

    void OnTriggerEnter(Collider coll)
    {
        playerData.score++;
        Notify(playerData);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
        SceneManager.LoadScene(0);
        }
    }
}
