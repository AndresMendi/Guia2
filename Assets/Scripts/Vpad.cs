using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Vpad : MonoBehaviour
{
    public TextMeshProUGUI dirText, Tcount, value;

    private Touch TC;
    private Vector2 StartP, EndP;
    private string direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            TC = Input.GetTouch(0);

            if (TC.phase == TouchPhase.Began)
            {
                StartP = TC.position;
            }
            else if (TC.phase == TouchPhase.Moved || TC.phase == TouchPhase.Ended)
            {
                EndP = TC.position;

                float x = EndP.x - StartP.x;
                float y = EndP.y - StartP.y;

                if (Mathf.Abs(x) == 0 && Mathf.Abs(y) == 0)
                {
                    direction = "Tapped";
                }
                else if (Mathf.Abs(x) > Mathf.Abs(y))
                {
                    direction = x > 0 ? "Right" : "Left";
                }
                else
                {
                    direction = y > 0 ? "Up" : "Down";
                }
                value.SetText("x: " + (x/500).ToString() + " y: " + (y/500).ToString());
            }
        }

        dirText.SetText(direction);
        Tcount.SetText(Input.touchCount.ToString());
    }
}