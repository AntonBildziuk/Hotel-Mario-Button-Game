using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject NewCanvas;
    public GameObject OldCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoreMoney()
    {
        OldCanvas.SetActive(false);
        NewCanvas.SetActive(true);
        SceneManager.LoadScene("SampleScene");
    }
}
