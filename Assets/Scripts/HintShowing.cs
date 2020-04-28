using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class HintShowing : MonoBehaviour
{
    public static bool isHint = false;
    public GameObject antenaImage;
    public GameObject[] horizontalButtons = new GameObject[2];
    public GameObject[] verticalButtons = new GameObject[2];
    public GameObject ptImage;
    public GameObject ctImage;
    public GameObject entButton;
    public GameObject optButton;
    public Image spriteImage;
    public Sprite eyeOpen;
    public Sprite eyeCross;

    private Color32 grey = new Color32(130, 130, 130, 255);
    private Color32 lightGreen = new Color32(0, 177, 8, 255);

    private void FixedUpdate()
    {
        if(isHint)
        {
            ShowImage();
        }
        else
        {
            HideImages();
        }
    }

    public void ShowImage()
    {
        switch(Global.currentTask)
        {
            case 0:
                HideImages();
                antenaImage.SetActive(true);
                break;
            case 1:
                HideImages();
                ptImage.SetActive(true);
                ctImage.SetActive(true);
                break;
            case 2:
                HideImages();
                ptImage.SetActive(true);
                break;
            case 3:
                HideImages();
                optButton.SetActive(true);
                break;
            case 4:
                MenuHintSteps();
                break;
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
                HintSteps();
                break;

        }
    }

    public void MenuHintSteps()
    {
        if (Global.keyValues[Global.currentTasks.ElementAt(Global.currentTask).Key].ToLower().Contains(Global.currentOption.ToLower()))
        {
            HideImages();
            entButton.SetActive(true);
        }
        else
        {
            HideImages();
            for (int i = 0; i < horizontalButtons.Length; i++)
            {
                horizontalButtons[i].SetActive(true);
            }
        }
    }

    public void HintSteps()
    {
        if(Global.currentTasks.ElementAt(Global.currentTask).Value.ToLower().Equals(Global.currentOption.ToLower()))
        {
            HideImages();
            entButton.SetActive(true);
        }
        else
        {
            HideImages();
            Debug.Log("fnsfnds " + Global.currentOption);
            for (int i = 0; i < verticalButtons.Length; i++)
            {
                verticalButtons[i].SetActive(true);
            }
        }
    }

    public void HideImages()
    {
        antenaImage.SetActive(false);
        ptImage.SetActive(false);
        ctImage.SetActive(false);
        optButton.SetActive(false);
        entButton.SetActive(false);

        for (int i = 0; i < horizontalButtons.Length; i++)
        {
            horizontalButtons[i].SetActive(false);
        }

        for (int i = 0; i < verticalButtons.Length; i++)
        {
            verticalButtons[i].SetActive(false);
        }


    }

    public void Activate()
    {
        if(!isHint)
        {
            spriteImage.overrideSprite = eyeOpen;
            spriteImage.color = lightGreen;
            isHint = true;
        }
        else
        {
            spriteImage.overrideSprite = eyeCross;
            spriteImage.color = grey;
            isHint = false;
        }
    }
}
