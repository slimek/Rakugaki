using Meringue.Mvp;

public class TitleView : View
                       , VersionPresenter.IVersionView
{
    public UILabel versionLabel;

    private VersionPresenter _version;

    protected override void OnAwake()
    {
        _version = new VersionPresenter(this);
        // _version = Bind<VersionPresenter>(this);
        // _version.text.Subscribe(SetVersion);
        // _version.text.Subscribe(x => versionLabel.text = x);
    }

    public void SetVersion(string version)
    {
    }
}
