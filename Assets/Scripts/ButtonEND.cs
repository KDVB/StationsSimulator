using UnityEngine;

public class ButtonEND : MonoBehaviour
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
            gameObject.GetComponent<Animation>().Play("ButtonENDPress");
            if (Global.inSettingMenu)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterSettings();
                Global.inSettingMenu = false;
            }
            else
            {
                if (Global.isTod)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[0].SetActive(true);
                    Global.inSettingMenu = true;
                }
                else if (Global.isRadio)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().RadioSetting();
                }
                else if (Global.isScan)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[0].SetActive(true);
                    Global.inSettingMenu = true;
                }
                else if (Global.isARP)
                {
                    if (!Global.arpConfig && !Global.arpView)
                    {
                        GameObject.Find("GameGlobalVariables").GetComponent<Global>().ArpEnter();
                    }
                    else
                    {
                        if (Global.arpView)
                        {
                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().ArpViewChange();
                        }
                        else if (Global.arpConfig)
                        {
                            GameObject.Find("GameGlobalVariables").GetComponent<Global>().ArpConfigChange();
                        }
                    }

                }
                else if (Global.isAcc)
                {
                    GameObject.Find("GameGlobalVariables").GetComponent<Global>().AccSettings();
                }
                else if (Global.isTest)
                {
                    if (Global.isBit)
                    {
                        GameObject.Find("GameGlobalVariables").GetComponent<Global>().TestPassed();
                    }
                    else
                        GameObject.Find("GameGlobalVariables").GetComponent<Global>().EnterTestSetting();

                }
            }
        }
    }
}
