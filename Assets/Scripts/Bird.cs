using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    [SerializeField] float _launchForce = 8000;
    [SerializeField] float _maxDragDistance = 50;
    Vector2 _startPosition;
    Rigidbody2D _rigidbody2D;
    SpriteRenderer _spriteRenderer;
    public static Bird Instance { get; private set; }
    public int numberOfBirds = 2;

    public bool IsDragging { get; private set; }

    public AudioSource aus;
    public AudioClip jump;
    public AudioClip lose;

    void Awake()
    {
        Instance = this;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        // get start bird positon 
        _startPosition = _rigidbody2D.position;
        // kinematic is on
        _rigidbody2D.isKinematic = true;

    }


    void OnMouseDown()
    {
        // set corlor bird
        _spriteRenderer.color = new Color32(123,199,248,255) ;
        IsDragging = true;

        if (aus && lose)
        {
            aus.PlayOneShot(lose);

        } 
      
    }

    void OnMouseUp()
    {
        Vector2 currentPosition = _rigidbody2D.position;
        Vector2 direction = _startPosition - currentPosition;
        direction.Normalize();

        _rigidbody2D.isKinematic = false;
        _rigidbody2D.AddForce(direction * _launchForce);

        _spriteRenderer.color = Color.white;
        IsDragging = false;
        StartCoroutine(ResetAfterDelay());

        if ( aus && jump)
        {
            aus.PlayOneShot(jump);

        }

    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 desiredPosition = mousePosition;
        

        float distance = Vector2.Distance(desiredPosition, _startPosition);
        if(distance > _maxDragDistance)
        {
            Vector2 direction = desiredPosition - _startPosition;
            direction.Normalize();
            desiredPosition = _startPosition + (direction * _maxDragDistance);
        }

        if (desiredPosition.x > _startPosition.x)
            desiredPosition.x = _startPosition.x;

        _rigidbody2D.position = desiredPosition;
    }

    // Update is called once per frame
    void Update()
    {
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    StartCoroutine(ResetAfterDelay());
        
   //}

    IEnumerator ResetAfterDelay()
    {
        yield return new WaitForSeconds(3);
        _rigidbody2D.position = _startPosition;
        _rigidbody2D.isKinematic = true;
        _rigidbody2D.velocity = Vector2.zero;
        numberOfBirds--;
    }
}
