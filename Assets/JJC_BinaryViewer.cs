using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JJC_BinaryViewer : MonoBehaviour
{
    public int viewNumber = 0;
    int oldViewNumber = 0;
    BinaryViewer binaryViewer;

    // Start is called before the first frame update
    void Start()
    {
        binaryViewer = GameObject.Find("BinaryViewer").GetComponent<BinaryViewer>();
        oldViewNumber = viewNumber;
    }

    // Update is called once per frame
    void Update()
    {
        if (oldViewNumber != viewNumber)
        {
            RefreshViewer(viewNumber);
            oldViewNumber = viewNumber;
        }
    }

    void RefreshViewer(int num)
    {
        if (num < 0 || num >= 16)
        {
            Debug.Assert(false, "4�P�^�̓�i����0����15�������͂ł��܂���.");
        }

        // ���͂������l�̊e���̒l��0��1�����f���A�e�P�^�ɓ��͂���.








        binaryViewer.ChangeNumber(0, 3);
        binaryViewer.ChangeNumber(0, 2);
        binaryViewer.ChangeNumber(0, 1);
        binaryViewer.ChangeNumber(0, 0);
    }
}
