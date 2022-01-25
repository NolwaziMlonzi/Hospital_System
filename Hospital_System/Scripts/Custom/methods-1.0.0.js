var methods =
{
    themes: function (theme) {
        var head = document.getElementsByTagName('head')[0];
        var link = document.createElement('link');
        link.id = "theme";
        link.rel = 'stylesheet';
        link.type = 'text/css';
        link.media = 'all';
        switch (theme) {
            case "ocean":
                link.href = "../Content/bootstrap_ocean.css";
                break;
            case "default":
            default:
                link.href =  "../Content/bootstrap.css";

        }

        head.appendChild(link);
    }
}