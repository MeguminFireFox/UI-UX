using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueFalse : MonoBehaviour
{
    public void OnClick(GameObject hi, GameObject bye)
    {
        hi.SetActive(true);
        bye.SetActive(false);
    }
}
