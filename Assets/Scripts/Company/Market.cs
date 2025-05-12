using UnityEngine;

[CreateAssetMenu(fileName = "Market", menuName = "Scriptable Objects/Market")]
public class Market : ScriptableObject
{
	[field: SerializeField] public string Name { get; private set; }
	[field: SerializeField] public string Description { get; private set; }
	[field: SerializeField] public Market[] PredecessorMarkets { get; private set; }
	[field: SerializeField] public Market[] SuccessorMarkets { get; private set; }
	[field: SerializeField] public Market[] SiblingMarkets { get; private set; }
}
