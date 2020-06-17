using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateManualList : MonoBehaviour
{
    public Button list;
    public GameObject prefabButton;
    public RectTransform panel;
    public float position = 93;

    // Start is called before the first frame update
    void Start()
    {
        CreateList();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateList()
    {
        string[] fileNames = Directory.GetFiles(Global.path);
        for (int i = 0; i < fileNames.Length; i++)
        {
            string name = fileNames[i].Substring(Global.path.Length + 1,
                                                 fileNames[i].Length - Global.path.Length - 5);
            GameObject goButton = (GameObject)Instantiate(prefabButton);
            goButton.GetComponentInChildren<TextMeshProUGUI>().text = name;
            goButton.transform.SetParent(panel, false);
            goButton.transform.localPosition = new Vector3(0, position, 0);
            position -= 15;
        }
    }
}
