"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var sport_platform_api_1 = require("../sport-platform-api");
var core_1 = require("@angular/core");
var LoginUserService = /** @class */ (function () {
    function LoginUserService(_client, _router) {
        this._client = _client;
        this._router = _router;
    }
    LoginUserService.prototype.canActivate = function () {
        var _this = this;
        var command = new sport_platform_api_1.LoginUserQuery();
        command.email = localStorage.getItem('email');
        command.password = localStorage.getItem('password');
        this._client.login(command).subscribe(function (data) {
            if (data == false) {
                localStorage.removeItem('email');
                localStorage.removeItem('password');
                _this._router.navigate(['/']);
            }
            else {
                return true;
            }
        });
        return this._client.login(command);
    };
    LoginUserService = __decorate([
        core_1.Injectable()
    ], LoginUserService);
    return LoginUserService;
}());
exports.LoginUserService = LoginUserService;
//# sourceMappingURL=login-user-service.js.map