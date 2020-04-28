using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManualOpen : MonoBehaviour
{

    public Button button;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenManual()
    {
        string filePath = "";
        string[] fileNames = Directory.GetFiles(Global.path);
        for (int i = 0; i < fileNames.Length; i++)
        {
            if(fileNames[i].Contains(button.GetComponentInChildren<TextMeshProUGUI>().text))
            {
                filePath = fileNames[i];
                break;
            }
        }

        Uri uri = new System.Uri(System.Environment.CurrentDirectory + filePath);
        string converted = uri.AbsoluteUri;
        Process.Start(@"C:\Users\KDVB\Desktop\ConsoleApp1\ConsoleApp1\bin\Debug\netcoreapp3.1\ConsoleApp1.exe", converted);
    }

}
