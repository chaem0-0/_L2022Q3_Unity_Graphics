using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Scene�� �ٲ� �� �ִ� ��
using UnityEngine.SceneManagement;

public class LoadScene_OnMouseDown: MonoBehaviour
{
    public Object SceneToLoad;
    Scene CurrentScene;

    //���� Scene�̸� ���
    void Start()
    {

        //gameObject -> ���� script�� �پ� �ִ� scene
        CurrentScene = gameObject.scene;
        print("CurrentScene = " + CurrentScene.name);
    }

    //���콺�� �����ٸ�
    private void OnMouseDown()
    {
        // ()�ȿ��� ���� �ٲٰ� ���� Scene�̸� �ֱ�
        SceneManager.LoadScene(SceneToLoad.name);
    }
}
