using UnityEngine;
using System.Collections;

public class io_ctr : MonoBehaviour {

	int degree,movement,status;

	// Use this for initialization
	void Start () {
	
		status = 0;
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

	public void set_status(int status)
	{
		this.status = status;
	}

	public int get_status()
	{
		return status;
	}
	
	// Update is called once per frame
	void Update () {
	
		io ();
	}

	public void io()
	{	
		status = 0;
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			status = 1;
			degree = degree - movement;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			status = 2;
			degree = degree + movement;
		}
	}
}
