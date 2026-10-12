using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeedPostCalc;
    [SerializeField] private float Energy = 100f;
    [SerializeField] public float moveSpeed = 20f;
    [SerializeField] private bool canDash;


    void Update()
    {

        if (Energy > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeedPostCalc = moveSpeed * 2;
        }
        else
        {
            moveSpeedPostCalc = moveSpeed;
        }

        while (Energy > 0 && Input.GetKey(KeyCode.LeftShift))
        {

        }
        {
            Vector3 direction = Vector3.zero;

            if (Input.GetKey(KeyCode.W)) direction.z += 1f;
            if (Input.GetKey(KeyCode.S)) direction.z -= 1f;
            if (Input.GetKey(KeyCode.A)) direction.x -= 1f;
            if (Input.GetKey(KeyCode.D)) direction.x += 1f;

            transform.Translate(
                direction.normalized * moveSpeedPostCalc * Time.deltaTime,
                Space.World
            );
        }

       
    }
}
