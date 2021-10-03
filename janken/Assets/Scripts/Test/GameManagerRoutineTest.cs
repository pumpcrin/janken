using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerRoutineTest : MonoBehaviour
{

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) GameManager.Instance.Finish();
    }
}
