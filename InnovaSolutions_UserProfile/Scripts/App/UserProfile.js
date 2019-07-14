var user = (function ($) {
    var UIController = (function () {
        var DomElements = {
            $DivShowHidePassword: $("#show_hide_password"),
            $DivConfirmShowHidePassword: $("#confirm_show_hide_password"),
            $Password: $("#password"),
            $ConfirmPassword: $("#confirm_password"),
            $lnkLogin: $("lnkLogin"),
            $lnkSignUp: $("lnkSignup"),
            $DivContentContainer: $('#content-container'),
            $btnSignupSubmit: $('#btn-signup-submit'),
            $btnLoginSubmit: $('#btn-login-submit'),

        }
        return {
            DomElements: function () { return DomElements; }
        }

    })();

    var APIController = (function () {
        var apiInfo = {
            SIGNUP_LOAD_URL: '/user/loadsignup',
            LOGIN_LOAD_URL: '/user/loadlogin',
            SIGNUP_VERIFICATION_URL: '/user/verifysignup',
            LOGIN_VERIFICATION_URL: '/user/verifylogin',
        }
        return {
            GetAPIDetails: function () {
                return apiInfo;
            }
        }
    })();

    var Handler = (function (UI,API) {
        var elemetns = UI.DomElements();

        // toggle password visibility
        function SetPasswordToggle(pwdElement) {
            if (pwdElement.find('input').attr("type") == "text") {
                pwdElement.find('input').attr('type', 'password');
                pwdElement.find('div.input-group-addon i').addClass("fa-eye-slash");
                pwdElement.find('div.input-group-addon i').removeClass("fa-eye");
            } else if (pwdElement.find('input').attr("type") == "password") {
                pwdElement.find('input').attr('type', 'text');
                pwdElement.find('div.input-group-addon i').removeClass("fa-eye-slash");
                pwdElement.find('div.input-group-addon i').addClass("fa-eye");
            }
        }
        elemetns.$DivShowHidePassword.find('a').on('click', function (event) {
            event.preventDefault();
            SetPasswordToggle(elemetns.$DivShowHidePassword);
        });
        elemetns.$DivConfirmShowHidePassword.find('a').on('click', function (event) {
            event.preventDefault();
            SetPasswordToggle(elemetns.$DivConfirmShowHidePassword);
        });

        // to validate password
        function validatePassword() {
            if (elemetns.$Password.val() != elemetns.$ConfirmPassword.val()) {
                elemetns.$ConfirmPassword[0].setCustomValidity("Passwords Don't Match");
            } else {
                elemetns.$ConfirmPassword[0].setCustomValidity('');
            }
        }
        elemetns.$Password.on('change', validatePassword);
        elemetns.$ConfirmPassword.on('keyup', validatePassword);

        // load login form
        elemetns.$lnkLogin.on('click', function (event) {
            event.preventDefault();
            $.ajax({
                url: API.GetAPIDetails().LOGIN_LOAD_URL
                , success: function (result) {
                    $DivContentContainer.html(result);
                }
            });
        });

        // load signup form
        elemetns.$lnkSignUp.on('click', function (event) {
            event.preventDefault();
            $.ajax({
                url: API.GetAPIDetails().SIGNUP_LOAD_URL
                , success: function (result) {
                    $DivContentContainer.html(result);
                }
            });
        });

        elemetns.$btnLoginSubmit.on('click', function () {
            $.ajax({
                url: API.GetAPIDetails().LOGIN_VERIFICATION_URL
                , success: function (result) {
                    $DivContentContainer.html(result);
                }
            });
        });

        elemetns.$btnSignupSubmit.on('click', function () {
            $.ajax({
                url: API.GetAPIDetails().SIGNUP_VERIFICATION_URL
                , success: function (result) {
                    $DivContentContainer.html(result);
                }
            });
        });

    })(UIController,APIController);
})(jQuery);