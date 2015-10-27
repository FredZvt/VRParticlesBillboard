using UnityEngine;
using System.Collections;

public class VRReadyBillboard : MonoBehaviour
{
    private void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position, Vector3.up);
    }
}
