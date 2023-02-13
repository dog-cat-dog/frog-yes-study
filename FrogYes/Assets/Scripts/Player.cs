using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public float doubleJumpForce;
    public int numberDeaths;
    private int checkPoint;
   // public int Lifes = 5;
    


    private Rigidbody2D rig;
    private Animator anim;

    public bool isJumping;
    public bool doubleJump;
    //private float movement;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Lifes = 5;
        Move();
        Jump();
        //Deaths();
    }

    void Move()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f); //usa-se input sempre q eh necessario pegar botao digitado no teclado
                                                                                                      // movement = Input.GetAxis("Horizontal");
        transform.position += movement;
        anim.SetBool("run", true);


        if (Input.GetAxis("Horizontal") < 0f)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);  //eulerangles altera os angulos


        }
        else
            if (Input.GetAxis("Horizontal") > 0f)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);

        }
        else
            if (Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("run", false);
        }

    }

    void Jump() // ja existe classe pronta e metodos no rigidbody para pulo, arremesso para cima
    {

        if (Input.GetButtonDown("Jump"))
        {


            if (isJumping == false)
            {

                Vector2 j = new Vector2(0f, jumpForce);
                rig.AddForce(j, ForceMode2D.Impulse); // addforce eh um metodo pronto que arremessa um objeto para algum lugar
                                                      // obrigatorio especificar o tipo de força no forcemode2d
                doubleJump = true;
                anim.SetBool("jump", true);
                anim.SetBool("doubleJump", false);
            }
            else // double jump
            if (doubleJump == true)
            {
                Vector2 j = new Vector2(0f, doubleJumpForce);
                rig.AddForce(j, ForceMode2D.Impulse);
                doubleJump = false;
                //anim.SetBool("jump", false);
                anim.SetBool("doubleJump", true);
            }
            // else
            // if(isJumping == true)
            // {
            //     anim.SetBool("jump", false);
            //     anim.SetBool("doubleJump", false);
            // }

        }


    }

    


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 9) // pega layer a qual o objeto desse script esta colidindo
        {
            isJumping = false; // se tiver colidindo com o chão vai retornar falso
            anim.SetBool("jump", false);
            anim.SetBool("doubleJump", false);

            if (collision.gameObject.layer == 9)
            {
                CheckPointFlag.animCheckPoint.SetBool("start", true);
               
            }
        }

        if (collision.gameObject.layer == 7 && GameController.instance.Score > 0 && checkPoint != 1)
        {
            transform.position = new Vector3(-7.83f, -2.18f, 0f);

            
            //numberDeaths += 1;
            GameController.instance.Score -= 1;

        } else
        if (collision.gameObject.layer == 7 && GameController.instance.Score > 0 && checkPoint == 1)
        {
            transform.position = new Vector3(2.82f, -1.13f, 0f);


            //numberDeaths += 1;
            GameController.instance.Score -= 1;
        }
        if (collision.gameObject.layer == 9)
        {
            checkPoint = 1;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6 || collision.gameObject.layer == 9) // pega layer a qual o objeto desse script esta colidindo
        {
            doubleJump = true;
            isJumping = true; // se NÃO tiver colidindo com o chão vai retornar verdadeiro para pulando
            if (collision.gameObject.layer == 9)
            {
                CheckPointFlag.animCheckPoint.SetBool("FlagAlways", true);

            }
        }
    }

}
