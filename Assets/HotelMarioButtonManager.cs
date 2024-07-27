using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HotelMarioButtonManager : MonoBehaviour
{
    public AudioClip[] HotelMarioClips;
    public AudioSource AS;
    private int ClipNumber;
    // Start is called before the first frame update
    void Start()
    {
        ClipNumber = -1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonPressedCoolio()
    {
        if (ClipNumber > HotelMarioClips.Length)
        {
            SceneManager.LoadScene("Win");
        }
        AS.clip = HotelMarioClips[ClipNumber += 1];
        AS.Play();
    }
}
