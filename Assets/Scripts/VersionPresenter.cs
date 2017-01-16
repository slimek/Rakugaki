using Meringue.Mvp;
using UniRx;

#if UNITY_EDITOR
using UnityEditor;
#endif

public interface IVersionPresenter
{
    ReactiveProperty<string> text { get; }
}

public partial class VersionPresenter : Presenter
                                      , IVersionPresenter
{
    public ReactiveProperty<string> text { get; private set; }

    public static IVersionPresenter Create()
    {
        return Presenter.Create<IVersionPresenter>();
    }

    public VersionPresenter()
    {
        #if UNITY_EDITOR
        var version = PlayerSettings.bundleVersion;
        #else
        string version = "0.0.0";
        #endif

        text = new ReactiveProperty<string>(version);
    }
}
