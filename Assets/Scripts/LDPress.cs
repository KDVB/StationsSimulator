using UnityEngine;

public class LDPress : MonoBehaviour
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
                    gameObject.GetComponent<Animation>().PlayQueued("OFF-LD");
                    break;
                case "PT":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("PT-LD");
                    break;
                case "CT":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("CT-LD");
                    break;
                case "Z":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("Z-LD");
                    break;
                case "CLR":
                    gameObject.GetComponent<AudioSource>().Play(0);
                    gameObject.GetComponent<Animation>().PlayQueued("CLR-LD");
                    break;
            }
            Global.currentMode = "LD";
        }
    }
}
