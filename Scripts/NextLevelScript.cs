using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
   public void Level1Clicked()
   {
        SceneManager.LoadScene("Level1");
   }
    public void Level2Clicked()
   {
        SceneManager.LoadScene("Level2");
   }
    public void Level3Clicked()
   {
        SceneManager.LoadScene("Level3");
   }
    public void Level4Clicked()
   {
        SceneManager.LoadScene("Level4");
   }
}
