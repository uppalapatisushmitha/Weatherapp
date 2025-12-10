window.guestSearch = {
    getCount: function () {
        return parseInt(localStorage.getItem("guestSearchCount")) || 0;
    },
    setCount: function (value) {
        localStorage.setItem("guestSearchCount", value);
    }
}
