﻿using UnityEngine;

public class ButtonCLR : MonoBehaviour
{
    public GameObject gameObject;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<AudioSource>().Play(0);
            gameObject.GetComponent<Animation>().Play("ButtonCLRPress");
            GameObject.Find("GameGlobalVariables").GetComponent<Global>().CLRPress();
        }
    }
}
