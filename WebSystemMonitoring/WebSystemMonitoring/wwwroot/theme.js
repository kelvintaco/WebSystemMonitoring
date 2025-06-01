window.applyTheme = function (theme) {
    // Remove all Radzen theme classes
    document.body.classList.remove(
        'rz-theme-default', 'rz-theme-standard', 'rz-theme-dark',
        'rz-theme-humanistic', 'rz-theme-software', 'rz-theme-material'
    );
    // Add the new theme class
    document.body.classList.add('rz-theme-' + theme.replace(' ', '-'));
    localStorage.theme = theme;
}