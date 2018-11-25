"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var PasswordValidation = /** @class */ (function () {
    function PasswordValidation() {
    }
    PasswordValidation.MatchPassword = function (AC) {
        var Password = AC.get('Password').value; // to get value in input tag
        var ConfirmPassword = AC.get('ConfirmPassword').value; // to get value in input tag
        if (Password != ConfirmPassword) {
            console.log('false');
            AC.get('ConfirmPassword').setErrors({ MatchPassword: true });
        }
        else {
            console.log('true');
            return null;
        }
    };
    return PasswordValidation;
}());
exports.PasswordValidation = PasswordValidation;
//# sourceMappingURL=password-validator.js.map