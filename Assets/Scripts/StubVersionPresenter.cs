using UniRx;

public class StubVersionPresenter : IVersionPresenter
{
    public ReactiveProperty<string> text { get; private set; }

    public StubVersionPresenter()
    {
        text = new ReactiveProperty<string>("M.m.b");
    }
}
