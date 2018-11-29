"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var sport_platform_api_1 = require("../../../sport-platform-api");
var password_validator_1 = require("../../../../validators/password-validator");
/**
 * @title Stepper overview
 */
var LandingRegisterComponent = /** @class */ (function () {
    function LandingRegisterComponent(_formBuilder, _client) {
        this._formBuilder = _formBuilder;
        this._client = _client;
    }
    LandingRegisterComponent.prototype.ngOnInit = function () {
        this.firstFormGroup = this._formBuilder.group({
            Name: ['', forms_1.Validators.compose([forms_1.Validators.required, forms_1.Validators.minLength(6)])],
        });
        this.secondFormGroup = this._formBuilder.group({
            Email: ['', forms_1.Validators.compose([forms_1.Validators.email, forms_1.Validators.minLength(4)])],
            Password: ['', forms_1.Validators.compose([forms_1.Validators.required, forms_1.Validators.minLength(6)])],
            ConfirmPassword: ['', forms_1.Validators.compose([forms_1.Validators.required, forms_1.Validators.minLength(6)])],
            UserRole: ['', forms_1.Validators.required]
        }, {
            validator: password_validator_1.PasswordValidation.MatchPassword
        });
    };
    LandingRegisterComponent.prototype.getErrorEmailMessage = function () {
        return this.secondFormGroup.controls['Email'].hasError('required') ? 'Введите значение' :
            this.secondFormGroup.controls['Email'].hasError('email') ? 'Неправильная почта' :
                '';
    };
    LandingRegisterComponent.prototype.getErrorNameMessage = function () {
        return this.firstFormGroup.controls['Name'].hasError('required') ? 'Введите значение' :
            this.firstFormGroup.controls['Name'].hasError('minlength') ? 'Минимальная длина 6 символов' : '';
    };
    LandingRegisterComponent.prototype.getErrorPasswordMessage = function () {
        return this.secondFormGroup.controls['Password'].hasError('required') ? 'Введите значение' :
            this.secondFormGroup.controls['Password'].hasError('minlength') ? 'Минимальная длина 6 символов' : '';
    };
    LandingRegisterComponent.prototype.getErrorPasswordSubmitMessage = function () {
        return this.secondFormGroup.controls['ConfirmPassword'].hasError('required') ? 'Введите значение' :
            this.secondFormGroup.controls['ConfirmPassword'].hasError('minlength') ? 'Минимальная длина 6 символов' :
                this.secondFormGroup.controls['ConfirmPassword'].hasError('MatchPassword') ? 'Пароли должны совпадать' : '';
    };
    LandingRegisterComponent.prototype.Register = function () {
        var command = new sport_platform_api_1.CreateUserCommand();
        command.email = this.secondFormGroup.controls['Email'].value;
        command.name = this.firstFormGroup.controls['Name'].value;
        command.password = this.secondFormGroup.controls['Password'].value;
        this._client.registerUser(command).subscribe(function (c) { return console.log(c); });
    };
    LandingRegisterComponent = __decorate([
        core_1.Component({
            selector: 'app-landing-register-component',
            templateUrl: 'landing-register-component.html'
        })
    ], LandingRegisterComponent);
    return LandingRegisterComponent;
}());
exports.LandingRegisterComponent = LandingRegisterComponent;
//# sourceMappingURL=landing-register-component.js.map