using UnityEngine;
using UnityEngine.UI;

public class NextStation : MonoBehaviour
{
    public Button btn;
    void Start()
    {
        Button temp = btn.GetComponent<Button>();
        btn.onClick.AddListener(GameObject.Find("GameGlobalVariables").GetComponent<Global>().NextStation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
