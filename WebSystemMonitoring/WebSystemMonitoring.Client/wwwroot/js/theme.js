// On page load or when changing themes, best to add inline in `head` to avoid FOUC
function initializeTheme() {
    document.documentElement.classList.toggle(
        'dark',
        localStorage.theme === 'dark' ||
        (!('theme' in localStorage) && window.matchMedia('(prefers-color-scheme: dark)').matches)
    );
}

window.applyTheme = function(theme) {
    if (theme === 'dark') {
        document.documentElement.classList.add('dark');
        localStorage.theme = 'dark';
    } else if (theme === 'light') {
        document.documentElement.classList.remove('dark');
        localStorage.theme = 'light';
    } else {
        // System preference
        localStorage.removeItem('theme');
        initializeTheme();
    }
}

window.loadTheme = function() {
    initializeTheme();
    return localStorage.theme || 'system';
}

// Apply theme on page load
document.addEventListener('DOMContentLoaded', initializeTheme); 