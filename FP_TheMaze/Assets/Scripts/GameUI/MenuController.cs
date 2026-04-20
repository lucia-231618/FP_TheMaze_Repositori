using UnityEngine;
using UnityEngine.Video;

public class MenuController : MonoBehaviour

{
    public GameObject PanelUI; 

    public void PlayGame()
    {

        SceneController.Instance.LoadScene("LEVEL1");
        
    }

    public void OptionsGame() // en proceso
    {

        SceneController.Instance.LoadScene("**");

    }

    public void ExitGame() 
    {

        Application.Quit();

    }
}
