/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './Pages/**/*.{razor,html,cshtml}',
        './Components/**/*.{razor,html,cshtml}',
        './Shared/**/*.{razor,html,cshtml}',
        './wwwroot/index.html',
    ],
    darkMode: 'class',
    theme: {
        extend: {
            animation: {
                'fade-in-down': 'fadeInDown 1s ease-out',
                'fade-in-up': 'fadeInUp 1s ease-out 0.3s forwards',
                'float': 'float 3s ease-in-out infinite',
            },
            keyframes: {
                fadeInDown: {
                    '0%': { opacity: '0', transform: 'translateY(-20px)' },
                    '100%': { opacity: '1', transform: 'translateY(0)' },
                },
                fadeInUp: {
                    '0%': { opacity: '0', transform: 'translateY(20px)' },
                    '100%': { opacity: '1', transform: 'translateY(0)' },
                },
                float: {
                    '0%, 100%': { transform: 'translateY(0)' },
                    '50%': { transform: 'translateY(-10px)' },
                },
            },
            colors: {
                'primary-blue': 'rgba(18, 42, 255, 0.85)',
                'secondary-blue': 'rgba(134, 136, 243, 0.85)',
            },
        },
    },
    plugins: [],
} 