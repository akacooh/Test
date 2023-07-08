using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadScene(string name) {
        if (SceneManager.GetActiveScene().name == name) return;
        SceneManager.LoadScene(name);
    }
}
