using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TouchC : MonoBehaviour
{
    public TextMeshProUGUI texto;
    private Touch theTouch;
    private float touchTime, displaytime = .5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            texto.SetText(theTouch.phase.ToString());
            if(theTouch.phase == TouchPhase.Ended)
            {
                touchTime = Time.time;
            }
        }
        else if(Time.time - touchTime > displaytime)
        {
            texto.SetText("");
        }
    }
}
