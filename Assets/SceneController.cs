using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    public void CloseGame()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        StartCoroutine(LoadLevel("MainScene"));
    }

    IEnumerator LoadLevel(string name)
    {
        transition.SetTrigger("In");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(name);
    }
}
