using System;
using System.Xml.Serialization;
using UnityEngine;

public class Character : IntEventInvoker
{
    public int health { get; set; }
    public float speed { get; set; }
    public float damage { get; set; }

    public float speedAttack { get; set; }

    public Rigidbody2D body { get; set; }

    public Animator animator { get; set; }

    public BoxCollider2D boxCollider2D { get; set; }

    public Transform transform { get; set; }

    public Camera camera { get; set; }

    private float currentSpeed;

    private Vector2 axisMovement;
    private Vector2 mousePos;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        unityEvents.Add(EventName.HealthChangedEvent, new HealthChangedEvent());
        EventManager.AddInvoker(EventName.HealthChangedEvent, this);
        unityEvents.Add(EventName.GameOverEvent, new GameOverEvent());
        EventManager.AddInvoker(EventName.GameOverEvent, this);
    }
        public Character(GameObject gameObject)
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
        transform = gameObject.transform;
    }


    internal void Update()
    {
        InputHandle();
        FixedUpdate();
    }

    private void InputHandle()
    {
        axisMovement.x = Input.GetAxisRaw("Horizontal");
        axisMovement.y = Input.GetAxisRaw("Vertical");

        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        
        Move();
    }

    private void Move()
    {
        body.MovePosition(body.position + axisMovement * speed * Time.fixedDeltaTime);
        camera.transform.position = new Vector3(body.position.x, body.position.y, -10);
        Vector2 lookdir = mousePos - body.position;
        float angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;
        body.rotation = angle;
        CheckForFlipping();
    }

    private void CheckForFlipping()
    {
        bool movingLeft = axisMovement.x < 0;
        bool movingRight = axisMovement.x > 0;

        if (movingLeft)
        {
            transform.localScale = new Vector3(-1f, transform.localScale.y);

        }
        if (movingRight)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y);
        }
    }

    /// <summary>
    /// Reduces health by the given amount of damage
    /// </summary>
    /// <param name="damage">damage</param>

}
