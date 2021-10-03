using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum SceneEnum{
    Title, Game, Custom
}


//public class SceneController : MonoBehaviour
//{
//    public static SceneController Instance;

//    //const int sceneAmount = 3;  //動的にシーンの総数を知る方法がなさそうなので手書きで...
//    //int currentSceneNum = 0;


//    void Start(){
//        if(Instance == null)
//            Instance = this;
//        else
//            Destroy(this.gameObject);
//    }

//    //public void ChangeScene(){
//    //    SceneManager.LoadScene((currentSceneNum+1)%sceneAmount);
//    //}

//    public void ChangeScene(SceneEnum nextSceneEnu){
//        SceneManager.LoadScene((int)nextSceneEnu)
//    }
//}
