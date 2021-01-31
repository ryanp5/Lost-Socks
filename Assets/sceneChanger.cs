using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public SockManager manager;
   public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void setFirstTry()
    {
        manager.firstTry = false;
    }
}
