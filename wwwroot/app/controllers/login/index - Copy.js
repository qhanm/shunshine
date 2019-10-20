var LoginController = function (paramUrlLogin, paramUrlHomeIndex) {

    this.initial = function () {
        
        registerEvent();
    }

    var registerEvent = function () {

        $(document).on("click", "#btnLogin", function (event) {
            //event.preventDefault();

            $("#frmLogin").validate({
                debug: true,
                errorClass: "shunshine-invalid",
                rules: {
                    UserName: "required",
                    Password: "required"
                }
             
            })

            let UserName = $("#txtUsername").val();
            let PassWord = $("#txtPassword").val();

            login(UserName, PassWord);
        })
    }

    var login = function (UserName, PassWord) {
        $.ajax({
            type: "POST",
            url: paramUrlLogin,
            data: {
                UserName: UserName,
                Password: PassWord
            },
            success: function (response) {
                if (response.Success) {
                    window.location.href = paramUrlHomeIndex;
                } else {
                    $("#login-vaild").text(response.Message);
                    //shunshine.showMessage("#errorLogin", response.Message);
                }
            },
            error: function (response) {
                console.log(response);
                //shunshine.showMessage("#errorLogin", response.Message);
            }
        })
    }
}