using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCredit : MonoBehaviour
{
    
private void Update()
{
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        SceneManager.LoadScene("MainMenu");
    }
}
}
