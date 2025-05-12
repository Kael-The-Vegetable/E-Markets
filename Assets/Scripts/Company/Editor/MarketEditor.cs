using UnityEngine;
using UnityEngine.UIElements;

#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(Market))]
public class MarketEditor : Editor
{
	public VisualTreeAsset visualTree;

	private Market _ref;

	private void OnEnable()
	{
		_ref = target as Market;
	}
	public override VisualElement CreateInspectorGUI()
	{
		VisualElement root = new VisualElement();

		visualTree.CloneTree(root);

		return root;
	}
}
#endif
