using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetScene : MonoBehaviour
{
    //Reset current scene
    public void ResetMainScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
