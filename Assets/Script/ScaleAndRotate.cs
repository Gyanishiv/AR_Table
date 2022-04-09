using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScaleAndRotate: MonoBehaviour 
{
public Scrollbar ScalingScr;
public Scrollbar RotationScr;
public GameObject Table;

// Start is called before the first frame update 
void Start()
{

}

// Update is called once per frame
void Update()
   {
    Table.transform.localScale = new Vector3(0.1f + ScalingScr.value, 0.1f + ScalingScr.value, 0.1f + ScalingScr.value);
    Table.transform.rotation = new Quaternion(Table.transform.rotation.x, Table.transform.rotation.y + RotationScr.value, Table.transform. rotation.z,1);
   }
}