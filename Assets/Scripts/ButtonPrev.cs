﻿using UnityEngine;

public class ButtonPrev : MonoBehaviour
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
            gameObject.GetComponent<Animation>().Play("ButtonPrevPress");
            if (Global.inSettingMenu)
            {
                if (Global.currentMenuItem == 0)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[0].SetActive(false);
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[1].SetActive(true);
                }
                if (Global.currentMenuItem == 5)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[0].SetActive(true);
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[1].SetActive(false);
                }
                if (Global.currentMenuItem != 0)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeColor(GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuImages[Global.currentMenuItem],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuItems[Global.currentMenuItem],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuImages[Global.currentMenuItem - 1],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuItems[Global.currentMenuItem - 1]);
                    Global.currentMenuItem--;
                }
                else
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().ChangeColor(GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuImages[Global.currentMenuItem],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuItems[Global.currentMenuItem],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuImages[6],
                                                                                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().menuItems[6]);
                    Global.currentMenuItem = 6;
                }
            }
            if (Global.isARP)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ArpChangePrev();
            }
            if (Global.isTest)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().TestChangePrev();
            }
        }
    }
}