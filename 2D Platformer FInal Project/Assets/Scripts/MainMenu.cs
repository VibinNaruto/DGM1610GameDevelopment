using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
   
   public void StartGame()
   {
       // This loads the scence in the Build Settings and into the game
       SceneManager.LoadScene(sceneToLoad);
   }

   public void QuitGame()
   {
       // This will quit the game but it has a debug so it won't quit but it will let you know it worked. 
       Application.Quit();
       Debug.Log("Quit Game");
   }
}
