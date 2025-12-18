window.theme = {
    get: () => localStorage.getItem("theme"),
    set: (theme) => localStorage.setItem("theme", theme)
};
