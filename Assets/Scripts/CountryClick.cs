using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CountryClick : MonoBehaviour
{
    private GameObject objBut;
    public UnityEvent OnClick = new UnityEvent();
    public Zoom z;
    // Start is called before the first frame update
    void Start()
    {
        objBut = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("MouseDown");
            Debug.Log(Physics.Raycast(ray, out Hit, 1000f));
            if (Physics.Raycast(ray, out Hit, 1000f) && Hit.collider.gameObject == gameObject)
            {
                Debug.Log("Button Clicked");
                OnClick.Invoke();
            }
        }
    }
}
