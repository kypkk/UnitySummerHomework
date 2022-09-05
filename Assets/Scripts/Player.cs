using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  Score score;

  private void Start()
  {
    score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
  }
  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Supply")
    {
      Destroy(other.gameObject);
      score.addScore();
    }
  }
}
