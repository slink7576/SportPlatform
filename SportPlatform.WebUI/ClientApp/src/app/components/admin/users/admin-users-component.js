"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var material_1 = require("@angular/material");
var AdminUsersComponent = /** @class */ (function () {
    function AdminUsersComponent() {
        this.opened = true;
        this.displayedColumns = ['id', 'email', 'name'];
        this.dataSource = new material_1.MatTableDataSource(UsersMock);
    }
    AdminUsersComponent.prototype.ngOnInit = function () {
        this.dataSource.paginator = this.paginator;
    };
    AdminUsersComponent.prototype.switch = function () {
        this.opened = !this.opened;
    };
    __decorate([
        core_1.ViewChild(material_1.MatPaginator)
    ], AdminUsersComponent.prototype, "paginator", void 0);
    AdminUsersComponent = __decorate([
        core_1.Component({
            selector: 'admin-users-component',
            templateUrl: 'admin-users-component.html',
            styleUrls: ['../admin.css']
        })
    ], AdminUsersComponent);
    return AdminUsersComponent;
}());
exports.AdminUsersComponent = AdminUsersComponent;
var UsersMock = [
    { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
    { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
    { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
    { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
    { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
    { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
    { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
    { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' }
];
//# sourceMappingURL=admin-users-component.js.map