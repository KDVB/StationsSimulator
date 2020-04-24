using TMPro;
using UnityEngine;

public class MenuButtonHover : MonoBehaviour//, IPointerEnterHandler, IPointerExitHandler
{
    public TMP_Dropdown dropdonw;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnMouseEnter()
    {
        Debug.Log("The cursor entered the selectable UI element.");
        dropdonw.Show();

    }
    public void OnMouseExit()
    {
        dropdonw.Hide();

    }



    //public void OnPointerEnter(PointerEventData eventData)
    //{
    //    Debug.Log("The cursor entered the selectable UI element.");
    //    dropdonw.Show();

    //}

    //public void OnPointerExit(PointerEventData eventData)
    //{
    //    Debug.Log("The cursor entered the selectable UI element.");
    //    dropdonw.Hide();

    //}

    // Update is called once per frame
    void Update()
    {

    }
}
