using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

  Rigidbody2D rb;

  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    transform.rotation = rotation;
    Destroy(this, 7);
  }

  private void FixedUpdate()
  {
    rb.MovePosition(rb.position + new Vector2(10, 0) * Time.fixedDeltaTime);
  }
}
