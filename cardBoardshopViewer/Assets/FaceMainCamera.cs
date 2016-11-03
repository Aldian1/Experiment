using UnityEngine;

using System.Collections;

public class FaceMainCamera : MonoBehaviour
{

    void Update()
    {

        transform.LookAt(Camera.main.transform.position);

        transform.Rotate(0, 180, 0);

    }

}

