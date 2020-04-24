using UnityEngine;

public class Button7 : MonoBehaviour
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
            gameObject.GetComponent<Animation>().Play("Button7Press");

            if (Global.isLoad)
            {
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().DisableLoadMenu();
                GameObject.Find("GameGlobalVariables").GetComponent<Global>().settingMenu[0].SetActive(true);
                Global.currentOption = "tod";
                Global.inSettingMenu = true;
            }
        }
    }
}
