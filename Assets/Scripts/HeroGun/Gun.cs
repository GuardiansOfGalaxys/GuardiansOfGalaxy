
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    [SerializeField]
    public GameObject bullet;
    [SerializeField]
    public Transform firePoint;

    public float bulletForce = 5f;

    public Button button;

    void Start()
    {
        button = GameObject.Find("BtnFire").GetComponent<Button>();
        button.onClick.AddListener(Shoot);
    }

    // Update is called once per frame
    void Update()
    {
        //if (GameObject.Find("BtnFire").GetComponent<Button>())
        //{
            //Shoot();
        //}
    }

    public void Shoot()
    {
        GameObject bull = Instantiate(bullet, firePoint.position, firePoint.rotation);
        // get the rigidbody component of the bullet object
        Rigidbody2D rb = bull.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        AudioManager.Play(AudioClipName.BurgerShot);
    }
}
