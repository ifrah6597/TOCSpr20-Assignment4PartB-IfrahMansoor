using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{
   public void GotoPenguinScene()
    {
        SceneManager.LoadScene("Penguins");
    }

    public void GotoHummingBirdScene()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
}
