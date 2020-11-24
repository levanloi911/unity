using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 50f, maxspeed = 3, maxjump = 8 , jumpPow = 100f;
    public Rigidbody2D r2;
    public bool grounded = true, faceright = true, doublejump = false;


    public int ourHealth;
    public int maxhealth = 5;

    public Animator anim;
    public gamemaster gm;

    //thong báo game over
    public GameObject gameover;

    
    // Start is called before the first frame update
   
   
    void Start()
    {
        r2 = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<gamemaster>();
        ourHealth = maxhealth;
        gameover.SetActive(false);


    }

    //takedame to boss
    public void TakeDamage(int damage)
    {
        ourHealth -= damage;

        gameObject.GetComponent<Animation>().Play("redflat");

        if (ourHealth <= 0)
        {
            Death();
        }
    }

    // Update is called once per frame
    void Update()
    {
      
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(r2.velocity.x));
   
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                grounded = false;
                doublejump = true;
                r2.AddForce(Vector2.up * jumpPow);
            }
            else
            {
                if (doublejump) {
                    doublejump = false;
                    //k cho người chơi nhảy chồng lên nhau
                    r2.velocity = new Vector2(r2.velocity.x, 0);
                    r2.AddForce(Vector2.up * jumpPow * 1f);
                }
                
            }
        }
    }
    private void FixedUpdate()
    {
        //h là điều kiện set trái phải 

        float h = Input.GetAxis("Horizontal");
        r2.AddForce((Vector2.right) * speed * h);
        if (r2.velocity.x > maxspeed)
            r2.velocity = new Vector2(maxspeed, r2.velocity.y);
        if (r2.velocity.x < -maxspeed)
            r2.velocity = new Vector2(-maxspeed, r2.velocity.y);

        if (r2.velocity.y > maxjump)
            r2.velocity = new Vector2(r2.velocity.x, maxjump);
        if (r2.velocity.y < -maxjump)
            r2.velocity = new Vector2(r2.velocity.x, -maxjump);

        if (h > 0 && !faceright)
        {
            Flip();
        }
        if (h < 0 && faceright)
        {
            Flip();
        }
        if (grounded)
        {
            r2.velocity = new Vector2(r2.velocity.x * 0.5f, r2.velocity.y);
        }
        if (ourHealth <= 0)
        {
          
            Death();
        }

    }
   
    public void Flip()
    {
        faceright = !faceright;
        transform.Rotate(0f, 180f, 0f);     
    }
    public void Death()
    {
        
        gameover.SetActive(true);
        //if (PlayerPrefs.GetInt("highscore") < gm.points)
        //    PlayerPrefs.SetInt("highscore", gm.points);
    }
    public void Damage(int damage)
    {
        ourHealth -= damage;
        gameObject.GetComponent<Animation>().Play("redflat");
    }
    public void Addheal(int addheal)
    {
        ourHealth += addheal;
    }
    //public void Knockback(float Knockpow, Vector2 Knockdir)
    //{
    //    r2.velocity = new Vector2(0, 0);
    //    r2.AddForce(new Vector2(Knockdir.x * -100, Knockdir.y - Knockpow));
    //}
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Coins"))
        {
            Destroy(col.gameObject);
            gm.points += 1;
        }
    }
    
    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
