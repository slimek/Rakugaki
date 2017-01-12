using Meringue.Mvp;

public class VersionPresenter
{
    public interface IVersionView
    {
        void SetVersion(string version);
    }

    IVersionView _view;

    public VersionPresenter(IVersionView view)
    {
        _view = view;
    }
}
