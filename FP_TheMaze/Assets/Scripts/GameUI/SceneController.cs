using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController Instance;

    private void Awake()        //Evitar duplicados en escena
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //Cargar escena normal (remplaza la escena completa)
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Cargando escena: " + sceneName);
    }

    //Cargar escena overlay
    public void LoadOverlay(string sceneName)
    {
        if (!SceneManager.GetSceneByName(sceneName).isLoaded)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
            Debug.Log("Cargando overlay: " + sceneName);
        }
    }

}
