using Meringue.Mvp;
using UniRx;

public class TitleView : View
{
    public UILabel versionLabel;

    private IVersionPresenter _version;

    protected override void OnAwake()
    {
        _version = VersionPresenter.Create();
        _version.text.Subscribe(x => versionLabel.text = x);
    }
}
