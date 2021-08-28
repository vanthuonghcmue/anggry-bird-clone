using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    [SerializeField] Sprite _deadSprite;
    [SerializeField] ParticleSystem _particleSystem;
    bool _hasDead;

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (ShouldDieFromCollision(collision))
        {
            StartCoroutine(Die());
            Scores.instance.scores += 10;
        }

    }

    IEnumerator Die()
    {
        _hasDead = true;
        GetComponent<SpriteRenderer>().sprite = _deadSprite;
        _particleSystem.Play();
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
    }

    private bool ShouldDieFromCollision(Collision2D collision)
    {
        if (_hasDead)
            return false;
        Bird bird = collision.gameObject.GetComponent<Bird>();
        if (bird != null)
            return true;
        return false;
    }
}
