using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTest : MonoBehaviour
{
    public SceneEnum nextSceneEnu;

    void Update(){
        if(Input.GetMouseButtonDown(0))
            SceneManager.LoadScene((int)nextSceneEnu);
    }
}
