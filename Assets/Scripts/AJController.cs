using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AJController : MonoBehaviour
{
    [SerializeField]
    private Animator AJAnimator;



    [SerializeField]
    private string paramSpeed = "Speed";

    [SerializeField]
    private string paramDirection = "Direction";

    [SerializeField]
    private string inputSpeed = "Vertical";

    [SerializeField]
    private string inputDirection = "Horizontal";
    [SerializeField]
    private string inputJump = "Jump";
    // Start is called before the first frame update
    void Start()
    {
        
    }

  public float speed;
  public float rotationSpeed;
    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis(inputSpeed);
        float horizontalInput = Input.GetAxis(inputDirection);
        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();
        transform.Translate(movementDirection * speed * Time.deltaTime,Space.World);
        if(movementDirection != Vector3.zero)
        {
      AJAnimator.SetBool("isMoving", true);
      Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
      transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
    }
    else
    {
      AJAnimator.SetBool("isMoving", false);
    }
    }
}
