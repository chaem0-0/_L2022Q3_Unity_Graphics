using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Scene을 바꿀 수 있는 것
using UnityEngine.SceneManagement;

public class LoadScene_OnMouseDown: MonoBehaviour
{
    public Object SceneToLoad;
    Scene CurrentScene;

    //현재 Scene이름 출력
    void Start()
    {

        //gameObject -> 현재 script가 붙어 있는 scene
        CurrentScene = gameObject.scene;
        print("CurrentScene = " + CurrentScene.name);
    }

    //마우스로 눌렀다면
    private void OnMouseDown()
    {
        // ()안에는 내가 바꾸고 싶은 Scene이름 넣기
        SceneManager.LoadScene(SceneToLoad.name);
    }
}
