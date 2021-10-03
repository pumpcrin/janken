using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    //LeftPlayerがオンライン対戦時自機になる
    [SerializeField] private Player LeftPlayer;
    [SerializeField] private Player RightPlayer;
    [SerializeField] private GameCanvas GameCanvas;

    void Start(){
        Instance = this;
        GameStart();
    }

    void GameStart(){
        LeftPlayer.Initialize();
        RightPlayer.Initialize();
        //Debug.Log("GameManager.GameStart()");
    }

    public void Finish(){
        //Debug.Log("GameManager.Finish()");
        //次のシーンへ
        SceneManager.LoadScene((int)SceneEnum.Custom);
    }


    void OnDestroy(){
        Instance = null;
    }
}
