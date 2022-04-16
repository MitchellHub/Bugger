module.exports = {
    purge: [],
    darkMode: false, // or 'media' or 'class'
    theme: {
        extend: {
            colors: {
                brand: {
                    light: "#A5B4FC",
                    DEFAULT: "#818CF8",
                    dark: "#6366F1",
                },
                fontFamily: {

                },
            },
        }
    },
    variants: {
        extend: {
            backgroundColor: ["active"],
        },
    },
    plugins: [],
}
