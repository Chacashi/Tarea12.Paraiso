using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubickControl : MonoBehaviour
{	
	public float horizontal;
	public float vertical;
	Rigidbody2D _compRigidbody2D;
	SpriteRenderer _compSpriteRenderer;
	public float speedX;
	public float speedY;
    // Start is called before the first frame update
    
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
	_compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       horizontal = Input.GetAxisRaw("Horizontal");
       vertical= Input.GetAxisRaw("Vertical");
       _compRigidbody2D.velocity = new Vector2(speedX*horizontal,speedY*vertical);
    }

    void OnCollisionEnter2D(Collision2D collision){
	
	if(collision.gameObject.tag == "Horizontal"){
	
	if(_compSpriteRenderer.flipX == true){
	_compSpriteRenderer.flipX= false;
	}
	else{
	_compSpriteRenderer.flipX= true;
	}
	if(_compSpriteRenderer.flipY == true){
	_compSpriteRenderer.flipY= false;
	}
	else{
	_compSpriteRenderer.flipY= true;
	}
	}
     if(collision.gameObject.tag == "Vertical"){
	
	if(_compSpriteRenderer.flipX == true){
	_compSpriteRenderer.flipX= false;
	}
	else{
	_compSpriteRenderer.flipX= true;
	}
	if(_compSpriteRenderer.flipY == true){
	_compSpriteRenderer.flipY= false;
	}
	else{
	_compSpriteRenderer.flipY= true;
	}
	
	}
	
	}
	

}
