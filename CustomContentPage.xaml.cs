namespace $rootnamespace$;

public partial class $safeitemname$ : ContentPage
{
    private readonly $fileinputname$ViewModel _viewModel;
    public $safeitemname$($fileinputname$ViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.InitializeAsync();
    }
}