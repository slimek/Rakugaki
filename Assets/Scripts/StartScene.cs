using Meringue.Mvp;
using UnityEngine;
using UniRx;

public class StartScene : Scene
{
    private View _titleView;

	private void Start()
    {
        var titleLoader = this.LoadView("Title");
        titleLoader.Subscribe(view => _titleView = view);
	}
}
