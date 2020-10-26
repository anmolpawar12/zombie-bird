using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instance = null;
    private bool playeractive = false;
    private bool gameover = false;
    private bool playerentered = false;
    [SerializeField] GameObject mainMenu;
    public bool PlayerActive
    {
        get { return playeractive; }
    }
    public bool GameOver
    {
        get { return gameover; }
    }
    public bool Playerentered
    {
        get { return playerentered; }
    }
    public GameObject cam;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);

        }
        DontDestroyOnLoad(gameObject);
        Assert.IsNotNull(mainMenu);
        cam.SetActive(false);
        

        
    }
    public void playerstarted()
    {
        playeractive = true;
    }
    public void playercollided()
    {
        gameover = true;

    }
    public void entergame()
    {
        mainMenu.SetActive(false);
        playerentered = true;
        cam.SetActive(true);
        

    }
}
