using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuInteraction : MonoBehaviour
{
    public void loadLevel()
    {
        // load some scene by name (or, by number)
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
    public void choicewhite()
    {
        GameState.playerColor = "White";
        AI.ai_player = "Black";
        InputController.playerColor = "White";

    }
    public void choiceblack()
    {
        GameState.playerColor = "Black";
        AI.ai_player = "White";
        InputController.playerColor = "Black";

    }
}
