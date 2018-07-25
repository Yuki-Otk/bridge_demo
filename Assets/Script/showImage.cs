using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showImage : MonoBehaviour , IInputClickHandler
{
    public GameObject image;
    private Camera holoCamera;
    int count;
    // Use this for initialization
    void Start () {
        holoCamera = Camera.main;
        count = 0;
        //image.SetActive(false);
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
            // カメラの目の前 1.25 Unit（移動目標地点、1 Unit = 1 m くらいのはず？ ）の座標取得
            Vector3 frontPosition = holoCamera.transform.position + holoCamera.transform.forward * 1.25f;
            frontPosition.z = frontPosition.z + 1f;
            //frontPosition.y = 0f;
            image.transform.position = frontPosition;
            image.transform.LookAt(holoCamera.transform.position);
            image.transform.Rotate(new Vector3(0, 180, 0));
            image.SetActive(true);
        }
        count++;

    }
}
