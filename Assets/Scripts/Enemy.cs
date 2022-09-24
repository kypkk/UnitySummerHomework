using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  Score score;

  private void Start()
  {
    score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
  }

  public delegate void EventDelegate();
  public event EventDelegate destroyEvent;

  public void OnDestroy()
  {
    if (destroyEvent != null)
      destroyEvent();
  }
  void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag == "Player")
    {
      Destroy(this.gameObject);
      if (score.getScore() > 0)
      {
        score.subScore();
      }
    }
    //if (other.gameObject.tag == "Bullet")
    //{
    //  Destroy(this.gameObject);
    //  score.addScore();
      
    //}
  }

}
