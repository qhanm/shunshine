var LoginController = function () {

    this.Initial = function () {
        registerEvent()
    }

    var registerEvent = function () {

        $(document).on("click", "#btnSubmitLogin", function (event) {

            event.preventDefault();
            var userName = $("#txtUserName").val();

            var password = $("#txtPassword").val();

            login(userName, password);
        })
    }

    var registerHandle = function () {

    }

    var login = function (txtUserName, txtPassword) {
        $.ajax({
            type: "POST",
            url: "/admin/login/authen",
            data: {
                UserName: txtUserName,
                Password: txtPassword,
            },
            success: function (response) {
                if (response.Success == true) {
                    window.location.href = "/admin/home/index";
                } else {
                    $("#txtErrorLogin").text(response.Message);
                }
            },
            error: function (response) {

            }
        })
    }
}