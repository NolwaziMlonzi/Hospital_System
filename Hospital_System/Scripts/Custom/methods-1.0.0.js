////var methods =
////{
////    themes: function (theme) {
////        var link = document.getElementsByTagName('link')[0];
////        link.id = "theme";
////        switch (theme) {
////            case "ocean":
////                link.href = "../Content/bootstrap_ocean.css";
////                break;
////            case "solar":
////                link.href = "../Content/bootstrap_solar.css";
////                break;
////            case "cyborg":
////                link.href = "../Content/bootstrap_cyborg.css";
////                break;
////            case "slate":
////                link.href = "../Content/bootstrap_slate.css";
////                break;
////            case "darkly":
////                link.href = "../Content/bootstrap_darkly.css";
////                break;
////            case "default":
////            default:
////                link.href =  "../Content/bootstrap.css";

////        }
////        console.log(document.getElementsByTagName('head'),"themes ",link)
////    },
////    Login: function () {
////        console.log("login executed")
////        let user = $("#username").val();
////        let pass = $("#password").val();
////        let credentials = {
////            username: user,
////            password: pass
////        }
////        doAPIRequest('/User/Login', credentials, 'POST', 'json', {}, this.LoginResponse);
////    },
////    LoginResponse: function (responseData) {
////        responseData && responseData.err ? methods.LoginError() : methods.LoginSuccess(responseData);
////        console.log("the response is ", responseData);
////    },
////    LoginSuccess: function (data) {
////        let alert = document.getElementById("loginScreen");
////        alert.style = 'display:none;';
////        document.getElementById("role").innerHTML = data.role + ' :';
////        document.getElementById("user").innerHTML = data.FirstName + " " + data.LastName;
////        methods.themes(data.Theme);
////        console.log("should be showing");
////    },
////    LoginError: function () {
////        let alert = document.getElementById("notification");
////        alert.className = "alert alert-danger";
////        alert.innerHTML = "Incorrect Username or Password";
////    },
////    GetTheme: function () {
////        document.getElementById("a").innerHTML = "loggedIn now"
////    }

////}