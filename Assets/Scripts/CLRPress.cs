using UnityEngine;

public class CLRPress : MonoBehaviour
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
            switch (Global.currentMode)
            {
                case "OFF":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("OFF-CLR");
                    break;
                case "PT":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("PT-CLR");
                    break;
                case "CT":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("CT-CLR");
                    break;
                case "LD":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("LD-CLR");
                    break;
                case "Z":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("Z-CLR");
                    break;
            }
            Global.currentMode = "CLR";
        }
    }
}
