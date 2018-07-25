using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showMenu : MonoBehaviour {
    public GameObject planDesignButton;
    public GameObject planDesign;
    private Camera holoCamera;
    // Use this for initialization
    void Start () {
        planDesignButton.SetActive(false);
        planDesign.SetActive(false);
        holoCamera = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnRecognizedMenu()
    {
        Debug.Log("menu");
        // カメラの目の前 1.25 Unit（移動目標地点、1 Unit = 1 m くらいのはず？ ）の座標取得
        Vector3 frontPosition = holoCamera.transform.position + holoCamera.transform.forward * 1.25f;
        //frontPosition.y = 0f;
        planDesignButton.transform.position = frontPosition;
        planDesignButton.transform.LookAt(holoCamera.transform.position);
        planDesignButton.transform.Rotate(new Vector3(0, 180, 0));
        planDesignButton.SetActive(true);
    }
    public void OnRecognizedClear()
    {
        planDesignButton.SetActive(false);
        planDesign.SetActive(false);
    }
}
