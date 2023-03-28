using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private ScenesEnum LoadNextScene = ScenesEnum.Registration;

    [SerializeField] private enum ScenesEnum {None=0, Registration=1, Novell1=2, Map=3, Case=4, Novell2=5};
    public void LoadScene()
    {
        Time.timeScale = 1f;
        switch (LoadNextScene)
        {
            case ScenesEnum.Registration:
                SceneManager.LoadScene("RegistrationScene");
                break;
            case ScenesEnum.Novell1:
                SceneManager.LoadScene("NovellScene1");
                break;
            case ScenesEnum.Map:
                SceneManager.LoadScene("MapScene");
                break;
            case ScenesEnum.Case:
                SceneManager.LoadScene("CaseSceneMain");
                break;
            case ScenesEnum.Novell2:
                SceneManager.LoadScene("NovellScene2");
                break;
        }
    }
    public void StringToEnum( string str)
    {
        switch (str)
        {
            case "RegistrationScene":
                LoadNextScene = ScenesEnum.Registration;
                LoadScene();
                break;
            case "NovellScene1":
                LoadNextScene = ScenesEnum.Novell1;
                LoadScene();
                break;
            case "NovellScene2":
                LoadNextScene = ScenesEnum.Novell2;
                break;
        }
    }
}
