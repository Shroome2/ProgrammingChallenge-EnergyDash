using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashEnergy : MonoBehaviour
{
    public float Energy = 100f;
    [SerializeField] PlayerMovement moveScript;

    // Update is called once per frame
    void Update()
    {
        if (Energy > 0 && Input.GetKeyDown(KeyCode.LeftShift) == true)
        {
            Vector3 direction = Vector3.zero;

            if (Input.GetKey(KeyCode.W)) direction.z += 1f;
            if (Input.GetKey(KeyCode.S)) direction.z -= 1f;
            if (Input.GetKey(KeyCode.A)) direction.x -= 1f;
            if (Input.GetKey(KeyCode.D)) direction.x += 1f;

            transform.Translate(
                direction.normalized * (moveScript.moveSpeed * 2) * Time.deltaTime,
                Space.World
                );

        }

    }
}
