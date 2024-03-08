using UnityEngine;

namespace Disparity.Unity{

public class UnityInstantiatable<T> : IInstantiatable where T: Object
    {
	private T t;

	public UnityInstantiatable(T t)
	{
		this.t = t;
	}

	public void Instantiate(FakeVector3 pos)
	{
		UnityEngine.Object.Instantiate(t, pos.ToUnityV3(), Quaternion.identity);
	}
}

public class UnityInstantiater : IInstantiater
{
	public void Instantiate<T>(T obj, FakeVector3 pos) where T : class, IGameObject
	{
		var asGo = obj.GetGameObject<GameObject>();
		UnityEngine.Object.Instantiate(asGo, pos.ToUnityV3(), Quaternion.identity);
	}
}

}
