var app = new Vue({
    el: '#app',
    data: {
         collapse: true
        , data: ""
    },
    methods:
    {
        openNav: function openNav() {
            document.getElementById("mySidenav").style.width = "200px";
            this.showLinks();
        }
        , showLinks: function showLinks() {
            document.getElementById("links").style.display = "block";
            this.collapse = false;
        }
        , closeNav: function closeNav() {
            document.getElementById("mySidenav").style.width = "60px";
            document.getElementById("links").style.display = "none";
            this.collapse = true;
        }
    }
    , mounted() {
        console.log("this is vue")
    }
})