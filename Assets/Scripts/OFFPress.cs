using UnityEngine;

public class OFFPress : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject glass;
    public GameObject[] loadMenu = new GameObject[4];

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
            glass.SetActive(false);

            Global.timeLoad = 0f;
            Global.modeSwitch = false;
            GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();

            switch (Global.currentMode)
            {
                case "PT":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("PT-OFF");
                    break;
                case "CT":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("CT-OFF");
                    break;
                case "LD":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("LD-OFF");
                    break;
                case "Z":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("Z-OFF");
                    break;
                case "CLR":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("CLR-OFF");
                    break;
            }
            Global.isTurn = false;
            Global.currentMode = "OFF";
        }
    }
}
