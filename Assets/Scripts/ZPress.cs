using UnityEngine;

public class ZPress : MonoBehaviour
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
                    gameObject.GetComponent<Animation>().PlayQueued("OFF-Z");
                    break;
                case "PT":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("PT-Z");
                    break;
                case "CT":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("CT-Z");
                    break;
                case "LD":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("LD-Z");
                    break;
                case "CLR":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("CLR-Z");
                    break;
            }
            Global.currentMode = "Z";
        }
    }
}
