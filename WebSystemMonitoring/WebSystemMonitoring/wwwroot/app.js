﻿// Handle navbar toggling for mobile
document.addEventListener('DOMContentLoaded', function () {
    const navbarToggler = document.getElementById('navbar-toggler');
    const navScrollable = document.getElementById('nav-scrollable');

    if (navbarToggler && navScrollable) {
        navbarToggler.addEventListener('click', function () {
            navScrollable.classList.toggle('hidden');
            navScrollable.classList.toggle('block');
        });
    }

    // Close mobile menu when a link is clicked
    const navLinks = document.querySelectorAll('.nav-link');
    navLinks.forEach(link => {
        link.addEventListener('click', function () {
            if (window.innerWidth < 768 && !navScrollable.classList.contains('hidden')) {
                navScrollable.classList.add('hidden');
                navScrollable.classList.remove('block');
            }
        });
    });
});

window.applyTheme = function (theme) {
    document.body.classList.remove('rz-theme-default', 'rz-theme-dark', 'rz-theme-humanistic', 'rz-theme-software', 'rz-theme-material');
    document.body.classList.add('rz-theme-' + theme);
    localStorage.theme = theme;
}