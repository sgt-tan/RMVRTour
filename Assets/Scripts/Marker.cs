using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour {

    public Transform player;
    private TextMesh mesh;
    private string text;
    public bool enabled;

    private void Start() {
        mesh = GetComponent<TextMesh>();
        text = mesh.text;
    }

    void Update() {
        mesh.fontSize = (int) (5 * Mathf.Sqrt(Vector3.Distance(player.position, transform.position) + 1) + 10);
        transform.LookAt(player);
        if (enabled) {
            Ray ray = new Ray(player.position, player.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100) && hit.transform.position == transform.position) {
                mesh.text = text;
            } else {
                mesh.text = "ↂ";
            }
        } else {
            mesh.text = "";
        }
    }

}