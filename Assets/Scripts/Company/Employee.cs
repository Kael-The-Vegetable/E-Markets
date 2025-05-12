using UnityEngine;

public class Employee : MonoBehaviour
{
	public void Start()
	{
		TickManager.OnTick += () => Debug.Log(TickManager.Instance.TimePerTick);
	}
}
