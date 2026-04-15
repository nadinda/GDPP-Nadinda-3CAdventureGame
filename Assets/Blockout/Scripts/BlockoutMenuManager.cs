using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockoutMenuManager : MonoBehaviour

{
    public void Play()
    {
        SceneManager.LoadScene("BlockoutGame");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
