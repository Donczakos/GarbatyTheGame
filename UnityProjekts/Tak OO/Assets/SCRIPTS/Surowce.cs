using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Surowce : MonoBehaviour
    {


    public int Wood;
    public TextMeshProUGUI WoodText;
    public void AddWood()
    {
        Wood += 1;
        WoodText.text = Wood.ToString();
    }

}
