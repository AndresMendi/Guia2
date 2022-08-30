using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MultiC : MonoBehaviour
{
    public TextMeshProUGUI texto;
    private int TapCount = 0;
    private string MTinfo;
    private Touch theTouch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MTinfo = string.Format("Numero de dedos: {0}\n", TapCount);

        if(Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                theTouch = Input.GetTouch(i);
                string info = "Touch: " + i.ToString() + " - " + theTouch.phase.ToString() + "\n";

                MTinfo += info;
            }
        }

        TapCount = Input.touchCount;
        texto.SetText(MTinfo);
    }
}
