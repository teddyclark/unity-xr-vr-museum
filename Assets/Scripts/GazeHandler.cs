using System.Collections;
using UnityEngine;

public class GazeHandler : MonoBehaviour
{

    // The description that appears when the painting is looked at
    public Canvas PaintingDescription;
    public Light SpotLight;

    // The objects are about 1 meter in radius, so the min/max target distance are
    // set so that the objects are always within the room (which is about 5 meters
    // across).
    private const float _minObjectDistance = 2.5f;
    private const float _maxObjectDistance = 3.5f;
    private const float _minObjectHeight = 0.5f;
    private const float _maxObjectHeight = 3.5f;

    private Renderer _myRenderer;
    private Vector3 _startingPosition;

    // Start is called before the first frame update.
    public void Start()
    {
        PaintingDescription.enabled = false;
        SpotLight.enabled = false;
        _myRenderer = GetComponent<Renderer>();
    }

    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    public void OnPointerEnter()
    {
        PaintingDescription.enabled = true;
        SpotLight.enabled = true;
    }

    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    public void OnPointerExit()
    {
        PaintingDescription.enabled = false;
        SpotLight.enabled = false;
    }
}
