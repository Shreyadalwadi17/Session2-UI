using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public Canvas Login;
    public Canvas Registration;
    public Canvas PointRummy;
    public Canvas MainMenu;
    public Canvas GamePlay;
    public Canvas Exit;


    void Start()
    {
        Exit.enabled = false;
        GamePlay.enabled = false;
        MainMenu.enabled = false;
        GamePlay.enabled = false;
        Registration.enabled = false;
        Login.enabled = true;
    }
    public void Registration_Canva()
    {
        Exit.enabled = false;
        GamePlay.enabled = false;
        MainMenu.enabled = false;
        GamePlay.enabled = false;
        Registration.enabled = true;
        Login.enabled = false;
    }

    public void Login_Canva()
    {
        Exit.enabled = false;
        GamePlay.enabled = false;
        MainMenu.enabled = false;
        GamePlay.enabled = false;
        Registration.enabled = false;
        Login.enabled = true;
    }

    public void PointRummy_Canva()
    {
        Exit.enabled = false;
        GamePlay.enabled = false;
        MainMenu.enabled = false;
        GamePlay.enabled = true;
        Registration.enabled = false;
        Login.enabled = false;
    }

    public void MainMenu_Canva()
    {
        Exit.enabled = false;
        GamePlay.enabled = false;
        MainMenu.enabled = true;
        GamePlay.enabled = false;
        Registration.enabled = false;
        Login.enabled = false;
    }

    public void GamePlay_Canva()
    {
        Exit.enabled = false;
        GamePlay.enabled = true;
        MainMenu.enabled = false;
        GamePlay.enabled = false;
        Registration.enabled = false;
        Login.enabled = false;

    }

    public void Exit_Canva()
    {
        Exit.enabled = true;
        GamePlay.enabled = false;
        MainMenu.enabled = false;
        GamePlay.enabled = false;
        Registration.enabled = false;
        Login.enabled = false;
    }
}
