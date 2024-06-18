using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public void SceneLoader(string name)
    {
        SceneManager.LoadScene(name);
    }
}
