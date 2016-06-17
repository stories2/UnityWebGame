using UnityEngine;
using System.Collections;

public class io_ctr : MonoBehaviour {

	int degree,movement;

	// Use this for initialization
	void Start () {
	
	}

	public void set_movement(int movement)
	{
		this.movement = movement;
	}

	public int get_degree()
	{
		return degree;
	}

	public void set_degree(int degree)
	{
		this.degree = degree;
	}
	
	// Update is called once per frame
	void Update () {
	
		io ();
	}

	public void io()
	{	
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			degree = degree - movement;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			degree = degree + movement;
		}
	}
}
