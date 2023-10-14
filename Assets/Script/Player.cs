using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed=3;
    public GameManager gameManager;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        #region moveright
        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveRight();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            _rigidbody.velocity = Vector2.right * 0;
        }
        #endregion

        #region moveleft
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            _rigidbody.velocity = Vector2.left * 0;
        }
        #endregion

        #region moveup
        if (Input.GetKeyDown(KeyCode.W))
        {
            MoveUp();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _rigidbody.velocity = Vector2.up * 0;
        }
        #endregion

        if(transform.position.y < -280)
        {
            Destroy(gameObject);
        }
    }
    private void MoveRight()
    {
            _rigidbody.velocity = Vector2.right * _speed; 
    }
    private void MoveLeft()
    {
        _rigidbody.velocity = Vector2.left * _speed;
    }
    private void MoveUp()
    {
        _rigidbody.velocity = Vector2.up * _speed;
    }
}
