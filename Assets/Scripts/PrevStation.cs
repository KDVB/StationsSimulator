using UnityEngine;
using UnityEngine.UI;

public class PrevStation : MonoBehaviour
{
    public Button btn;
    void Start()
    {
        Button temp = btn.GetComponent<Button>();
        btn.onClick.AddListener(GameObject.Find("GameGlobalVariables").GetComponent<Global>().PrevStation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
