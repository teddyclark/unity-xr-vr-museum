using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportHandler : MonoBehaviour
{
    public GameObject player;
    public Vector3 placeToTeleport;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(placeToTeleport);
    }

    // Update is called once per frame
    void Update() {
        Debug.Log(Vector3.Distance(player.transform.position, transform.position));
        if (Vector3.Distance(player.transform.position, transform.position) < 1.5f) {
            player.transform.position = placeToTeleport;
        }
    }
}
