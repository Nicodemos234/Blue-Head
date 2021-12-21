using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  Rigidbody2D playerRigidbody;
  public float playerVelocity = 1.7f;
  Vector2 movement;

  // Start is called before the first frame update
  void Start()
  {
    playerRigidbody = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    movement.y = Input.GetAxis("Vertical");
    movement.x = Input.GetAxis("Horizontal");
  }

  private void FixedUpdate()
  {
      playerRigidbody.MovePosition(playerRigidbody.position + movement * playerVelocity * Time.fixedDeltaTime);
  }
}
