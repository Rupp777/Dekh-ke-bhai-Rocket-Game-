using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour
{
    public Button button;
    public string scean;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnbButtonClick);
    }

    void OnbButtonClick()
    {
        Debug.Log("Clicked button...");
        SceneManager.LoadScene(scean);
    }

}
