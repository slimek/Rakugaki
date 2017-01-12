using Meringue.Mvp;

public class TitleView : View
                       , VersionPresenter.IVersionView
{
    public UILabel versionLabel;

    private VersionPresenter _versionPresenter;

    protected override void OnAwake()
    {
        _versionPresenter = new VersionPresenter(this);
    }

    public void SetVersion(string version)
    {
    }
}
