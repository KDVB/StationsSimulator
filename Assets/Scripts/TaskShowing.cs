using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaskShowing : MonoBehaviour
{
    public Button button; 
    public GameObject prefab;
    public float position;
    public GameObject station;
    public GameObject stationModel;
    public static bool defaultPosition = false;
    private RectTransform panel;
    public GameObject nextStationButton;
    public GameObject prevStationButton;
    

    // Start is called before the first frame update
    void Start()
    {
        
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskShow);
        panel = GameObject.Find("PanelForTask").GetComponent<RectTransform>();
        nextStationButton = GameObject.Find("NextStation");
        prevStationButton = GameObject.Find("PrevStation");
        station = GameObject.Find("AnimHarris7800");
        stationModel = GameObject.Find("Station");
        
    }

    // Update is called once per frame
    

    void TaskShow()
    {
        stationModel.transform.position = new Vector3(36,64,31);

        Global.isLesson = true;
        defaultPosition = true;
        station.SetActive(false);

        prevStationButton.SetActive(false);
        nextStationButton.SetActive(false);


        string filePath = "";
        string[] fileNames = Directory.GetFiles(Global.testPath);
        for (int i = 0; i < fileNames.Length; i++)
        {
            if (fileNames[i].Contains(button.GetComponentInChildren<TextMeshProUGUI>().text))
            {
                filePath = fileNames[i];
            }
        }

        string[] fileLines = File.ReadAllLines(filePath);

        for (int i = 0; i < fileLines.Length; i++)
        {
            Global.currentTasks.Add(fileLines[i].Split(':')[0], fileLines[i].Split(':')[1]);
            GameObject goButton = (GameObject)Instantiate(prefab);
            goButton.GetComponentInChildren<TextMeshProUGUI>().text = Global.keyValues[fileLines[i].Split(':')[0]];
            if((fileLines[i].Split(':')[1] != "true") && (fileLines[i].Split(':')[1] != "false"))
            {
                goButton.GetComponentInChildren<TextMeshProUGUI>().text += " " + fileLines[i].Split(':')[1].ToUpper();
            }
            goButton.transform.SetParent(panel, false);
            goButton.transform.localPosition = new Vector3(-590, 0, 0);
            int k = (goButton.GetComponentInChildren<TextMeshProUGUI>().text.Length / 40);
            goButton.GetComponent<RectTransform>().sizeDelta = new Vector2(200,50 * (k+1) - 13 * k);
            Global.tasks.Add(goButton.GetComponent<TextMeshProUGUI>());
            Global.tasks[0].color = Global.currentTaskColor;  
        }
        
    }
}
