using UnityEngine;
using System.Collections;

public class queue_block : MonoBehaviour {

	block_ctr front,rear;

	// Use this for initialization
	void Start () {
	
		front = null;
		rear = null;
	}

	public block_ctr get_rear()
	{
		return rear;
	}

	public block_ctr get_front()
	{
		return front;
	}

	public bool del()
	{
		block_ctr block;
		if (is_empty ())
			return false;
		block = front;
		front = block.get_next_block ();
		Destroy (block);
		return true;
	}

	public void add()
	{
		block_ctr block = gameObject.AddComponent<block_ctr> ();
		if (rear) {
			rear.set_next_block (block);
		} 
		else {
			rear = block;
		}
		if (is_empty ()) {
			front = block;
		}
	}

	public bool is_empty()
	{
		return front == null;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
