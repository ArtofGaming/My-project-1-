using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    Scene lastScene;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        lastScene = SceneManager.GetActiveScene();
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    public void GoToSave()
    {
        lastScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Save Scene");
    }

    public void GoToMain()
    {
        lastScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Main Scene");
    }

    public void GoToLoad()
    {
        lastScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Load Scene");
    }

    public void GoToOptions()
    {
        lastScene = SceneManager.GetActiveScene();
        Debug.Log(lastScene.buildIndex);
        
        SceneManager.LoadScene("Options");

    }

    public void GoToPause()
    {
        lastScene = SceneManager.GetActiveScene();
        Debug.Log(lastScene.buildIndex);
        SceneManager.LoadScene("Pause");
        
    }


    public void GoToMenu()
    {
        lastScene = SceneManager.GetActiveScene();
        Debug.Log(lastScene.buildIndex);
        SceneManager.LoadScene("Menu");

    }
}
