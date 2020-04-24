using UnityEngine;

public class Cable : MonoBehaviour
{
    public GameObject gameObject;
    private bool inOut = false;

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
            if (!inOut)
            {
                gameObject.GetComponent<Animation>().Play("CableIn");
                Global.isCouplerIn = true;
                inOut = true;
            }
            else
            {
                gameObject.GetComponent<Animation>().Play("CableOut");
                Global.isCouplerIn = false;
                inOut = false;
            }
        }
    }

}
