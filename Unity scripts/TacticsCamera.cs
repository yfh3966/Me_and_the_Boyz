using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacticsCamera : MonoBehaviour
{
    public void rotateLeft()
    {
        transform.Rotate(Vector3.up, 90, Space.Self);
    }

    public void rotateRight()
    {
        transform.Rotate(Vector3.up, -90, Space.Self);
    }
}
 