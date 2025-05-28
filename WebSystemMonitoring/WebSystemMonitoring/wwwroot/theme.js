window.themeManager = {
    setTheme: function (theme) {
        if (theme === "dark") {
            document.documentElement.classList.add("dark");
        } else {
            document.documentElement.classList.remove("dark");
        }
        localStorage.setItem("theme", theme);
    },
    getTheme: function () {
        return localStorage.getItem("theme");
    }
}; 