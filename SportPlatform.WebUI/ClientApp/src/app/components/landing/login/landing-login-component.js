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
var LandingLoginComponent = /** @class */ (function () {
    function LandingLoginComponent(_formBuilder, _router, _client) {
        this._formBuilder = _formBuilder;
        this._router = _router;
        this._client = _client;
        this.NotForgetPassword = true;
        this.Restored = false;
        this.isLoading = false;
        this.LoginError = false;
    }
    LandingLoginComponent.prototype.ngOnInit = function () {
        this.firstFormGroup = this._formBuilder.group({
            Email: ['', forms_1.Validators.compose([forms_1.Validators.required, forms_1.Validators.email])],
            Password: ['', forms_1.Validators.required],
        });
        this.secondFormGroup = this._formBuilder.group({
            Email: ['', forms_1.Validators.compose([forms_1.Validators.required, forms_1.Validators.email])],
        });
    };
    LandingLoginComponent.prototype.Login = function () {
        var _this = this;
        var command = new sport_platform_api_1.LoginUserQuery();
        command.email = this.firstFormGroup.controls['Email'].value;
        command.password = this.firstFormGroup.controls['Password'].value;
        this.isLoading = true;
        this._client.login(command).subscribe(function (data) {
            if (data) {
                localStorage.setItem('email', command.email);
                localStorage.setItem('password', command.password);
                _this._router.navigate(['user/dashboard']);
            }
            else {
                _this.isLoading = false;
                _this.LoginError = true;
            }
        });
    };
    LandingLoginComponent.prototype.Restore = function () {
        if (!this.Restored && this.secondFormGroup.valid) {
            // TODO: Restore password
            this.Restored = true;
        }
    };
    LandingLoginComponent.prototype.ForgetPassword = function () {
        this.NotForgetPassword = !this.NotForgetPassword;
    };
    LandingLoginComponent = __decorate([
        core_1.Component({
            selector: 'app-landing-login-component',
            templateUrl: './landing-login-component.html'
        })
    ], LandingLoginComponent);
    return LandingLoginComponent;
}());
exports.LandingLoginComponent = LandingLoginComponent;
//# sourceMappingURL=landing-login-component.js.map