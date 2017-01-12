using Meringue.Mvp;
using UnityEngine;
using UniRx;

public class StartScene : Scene
{
    private View _titleView;

	private void Start()
    {
        this.LoadView("Title")
            .Subscribe(view => _titleView = view);
	}
}
