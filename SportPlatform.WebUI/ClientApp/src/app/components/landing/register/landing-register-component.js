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
            Name: ['', forms_1.Validators.required],
        });
        this.secondFormGroup = this._formBuilder.group({
            Email: ['', forms_1.Validators.email],
            Password: ['', forms_1.Validators.required,],
            ConfirmPassword: ['', forms_1.Validators.required],
        }, {
            validator: password_validator_1.PasswordValidation.MatchPassword
        });
    };
    LandingRegisterComponent.prototype.Register = function () {
        var command = new sport_platform_api_1.CreateUserCommand();
        command.email = this.secondFormGroup.controls['Email'].value;
        command.name = this.firstFormGroup.controls['Name'].value;
        command.password = this.secondFormGroup.controls['Password'].value;
        console.log(command);
        this._client.post(command).subscribe(function (c) { return console.log(c); });
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