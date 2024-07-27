using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    public GameObject NewCanvas;
    public GameObject OldCanvas;
    public float TImer = 0.1f;
    public GameObject Load2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TImer -= Time.deltaTime;
        if(TImer <= 0)
        {
            NewCanvas.SetActive(true);
            OldCanvas.SetActive(false);
        }

        if(TImer <= -0.5f)
        {
            Destroy(Load2);
            Destroy(this.gameObject);
        }
    }
}
