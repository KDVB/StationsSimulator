using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateTestsList : MonoBehaviour
{
    public Button list;
    public GameObject prefabButton;
    public RectTransform panel;
    public float position;
    public GameObject stationModel;
    public Quaternion originRotation;
    float speed = 60f;

    // Start is called before the first frame update
    void Start()
    {
        CreateList();
        stationModel = GameObject.Find("Station");
        originRotation.eulerAngles = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TaskShowing.defaultPosition)
        {
            var step = speed * Time.deltaTime;
            stationModel.transform.rotation = Quaternion.RotateTowards(stationModel.transform.rotation, originRotation, step);
            if (stationModel.transform.rotation == originRotation)
            {
                TaskShowing.defaultPosition = false;
            }
        }
    }

    public void CreateList()
    {

        string[] fileNames = Directory.GetFiles(Global.testPath);
        for (int i = 0; i < fileNames.Length; i++)
        {
            string name = fileNames[i].Substring(Global.testPath.Length + 1,
                                                 fileNames[i].Length - Global.testPath.Length - 5);
            GameObject goButton = (GameObject)Instantiate(prefabButton);
            goButton.GetComponentInChildren<TextMeshProUGUI>().text = name;
            if(name.Length > 19)
            {
                goButton.GetComponentInChildren<TextMeshProUGUI>().fontSize = 17;
            }
            goButton.transform.SetParent(panel, false);
            goButton.transform.localPosition = new Vector3(0, position, 0);
            position -= 13;
        }
    }
}
