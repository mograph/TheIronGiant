using UnityEngine;

public class AbsolutePositioning : MonoBehaviour
{
    public GameObject neuronHead;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 position = neuronHead.transform.position;
        this.transform.position = position + offset;
    }
}