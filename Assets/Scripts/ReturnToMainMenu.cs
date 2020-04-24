using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnToMainMenu : MonoBehaviour
{
    public GameObject mainButton;
    public GameObject nextLessonButton;
    public GameObject nextStationButton;
    public GameObject prevStationButton;
    public GameObject stationAnim;
    public GameObject finishText;
    public GameObject hintbutton;

    public void ReturnToMain()
    {
        finishText.SetActive(false);
        mainButton.SetActive(false);
        nextLessonButton.SetActive(false);
        nextStationButton.SetActive(true);
        prevStationButton.SetActive(true);
        stationAnim.SetActive(true);
        hintbutton.SetActive(false);

        GameObject.Find("cabel").GetComponent<Animation>().Play("CableOut");
        Global.isCouplerIn = false;
        GameObject.Find("Glass").SetActive(false);

        for (int i = 0; i < Global.tasks.Count; i++)
        {
            Destroy(Global.tasks[i]);
        }
        Global.tasks.Clear();
    }
}
