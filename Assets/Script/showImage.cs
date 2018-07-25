using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showImage : MonoBehaviour , IInputClickHandler
{
    public GameObject image;
    int count;
    // Use this for initialization
    void Start () {
        count = 0;
        image.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (count % 2 != 0)
        {
            image.SetActive(false);
        }
        else
        {
            image.SetActive(true);
        }
        count++;

    }
}
