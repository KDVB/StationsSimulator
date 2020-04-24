using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class TaskChecker : MonoBehaviour
{
    FieldInfo fld;
    public GameObject finalText;
    public GameObject mainMenuButton;
    public GameObject nextLessonButton;
    public GameObject hintButton;
    private void FixedUpdate()
    {
        if(Global.isLesson)
        {
            Debug.Log(Global.currentTask);
            hintButton.SetActive(true);
            if (Global.currentTask != Global.currentTasks.Count)
            {
                fld = typeof(Global).GetField(Global.currentTasks.ElementAt(Global.currentTask).Key);
                Debug.Log(fld.GetValue(null).ToString().ToLower() + " " + Global.currentTasks.ElementAt(Global.currentTask).Value.ToLower());
                
                if(fld.GetValue(null).ToString().ToLower().Equals(Global.currentTasks.ElementAt(Global.currentTask).Value.ToLower()))
                {
                    if (Global.currentTask == Global.currentTasks.Count - 1)
                    {
                        Global.tasks[Global.currentTask].color = Global.finishedTaskColor;
                    }
                    else
                    {
                        Global.tasks[Global.currentTask].color = Global.finishedTaskColor;
                        Global.tasks[Global.currentTask + 1].color = Global.currentTaskColor;
                    }
                    
                    Global.currentTask++;

                    Global.arrowPosition -= 90;
                    GameObject.Find("TaskArrow(Clone)").GetComponentInChildren<Image>().transform.localPosition = new Vector3(-960, Global.arrowPosition, 0);
                }
            }
            else
            {
                Destroy(GameObject.Find("TaskArrow(Clone)"));
                Global.isLesson = false;
                Global.currentTask = 0;
                finalText.SetActive(true);
                mainMenuButton.SetActive(true);
                nextLessonButton.SetActive(true);
                hintButton.SetActive(false);
            }
        }
    }


}
