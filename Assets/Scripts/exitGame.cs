using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class exitGame : MonoBehaviour
{
    public Canvas start;
    public Button exit;

    public void quit()
    {
        Debug.Log("has quit game.");
        Application.Quit();
    }
}
