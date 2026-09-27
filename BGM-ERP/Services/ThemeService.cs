using Microsoft.JSInterop;

namespace BGM_ERP.Services
{
    public class ThemeService
    {
        private bool _isDarkMode = false;
        private string _primaryColor = "#1E66C8";
        private IJSRuntime? _jsRuntime;

        public bool IsDarkMode => _isDarkMode;
        public string PrimaryColor => _primaryColor;

        public event Action? OnThemeChanged;

        public ThemeService() { }

        public void Initialize(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public void ToggleTheme()
        {
            _isDarkMode = !_isDarkMode;
            UpdateTheme();
        }

        public void SetTheme(bool isDark)
        {
            _isDarkMode = isDark;
            UpdateTheme();
        }

        public void SetPrimaryColor(string hexColor)
        {
            _primaryColor = hexColor;
            OnThemeChanged?.Invoke();
        }

        private void UpdateTheme()
        {
            OnThemeChanged?.Invoke();
            if (_jsRuntime != null)
            {
                _jsRuntime.InvokeVoidAsync("window.setTheme", _isDarkMode);
            }
        }
    }
}
