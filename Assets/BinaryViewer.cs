using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BinaryViewer : MonoBehaviour
{
    const int BINARY_KETA = 4;
    Text[] viewer;
    // Start is called before the first frame update
    void Start()
    {
        viewer = new Text[BINARY_KETA];

        for(int i = 0; i < viewer.Length; i++)
        {
            viewer[i] = GameObject.Find("View" + i.ToString()).GetComponent<Text>();
        }

        ChangeNumber(1, 3);
        ChangeNumber(0, 2);
        ChangeNumber(1, 1);
        ChangeNumber(0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeNumber(int num, int keta)
    {
        if (num != 0 && num != 1)
        {
            Debug.Assert(false, "“ñi”‚Í0‚ ‚é‚¢‚Í1‚µ‚©“ü—Í‚Å‚«‚Ü‚¹‚ñ.");
        }

        viewer[keta].text = num.ToString();
    }
}
