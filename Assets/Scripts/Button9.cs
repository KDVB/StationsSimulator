using UnityEngine;

public class Button9 : MonoBehaviour
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
            gameObject.GetComponent<Animation>().Play("Button9Press");
            if (Global.isRadio)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().RadioChangeDown();
            }
            if (Global.isScan)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ScanChangeDown();
            }
            if (Global.arpConfig)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().ArpConfigChangeDown();
            }
            if (Global.isTest && Global.currentTestItem == 0)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().TestBitSettingDown();
            }
        }
    }
}
