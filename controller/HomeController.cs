using Visualizer.presenter;

namespace Visualizer.controller;

public class HomeController
{
    public UiPresenter Presenter { get; init; }

    public HomeController()
    {
        Presenter = new UiPresenter();
    }
}