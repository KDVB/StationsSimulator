using TMPro;
using UnityEngine;

public class PTPress : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject glass;
    public TextMeshProUGUI modeText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Global.modeSwitch)
        {
            if ((Time.time - Global.timeLoad) < 2f)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().loadMenu[0].SetActive(true);
            }
            else if ((Time.time - Global.timeLoad) < 4f)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().loadMenu[1].SetActive(true);
            }
            else if ((Time.time - Global.timeLoad) < 5f)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().loadMenu[2].SetActive(true);
            }
            else if ((Time.time - Global.timeLoad) < 7f)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().loadMenu[3].SetActive(true);
                Global.isLoad = true;
            }
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            glass.SetActive(true);
            if (Global.timeLoad == 0)
            {
                Global.timeLoad = Time.time;
            }

            Global.isTurn = true;

            if (!Global.modeSwitch)
                Global.modeSwitch = true;

            switch (Global.currentMode)
            {
                case "OFF":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("OFF-PT");
                    break;
                case "CT":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("CT-PT");
                    break;
                case "LD":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("LD-PT");
                    break;
                case "Z":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("Z-PT");
                    break;
                case "CLR":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("CLR-PT");
                    break;
            }
            Global.currentMode = "PT";
            modeText.text = "PT";
        }
    }
}
