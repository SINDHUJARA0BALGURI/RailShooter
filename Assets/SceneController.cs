using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GoToGameScene", 2.0f);
    }

    // Update is called once per frame
    void GoToGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
