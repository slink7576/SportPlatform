import { CanActivate, Router } from "@angular/router";
import { Observable } from "rxjs";
import { Client, LoginUserQuery } from "../sport-platform-api";
import { Injectable } from '@angular/core';

@Injectable()

export class LoginUserService implements CanActivate {
  constructor(private _client: Client,
    private _router: Router) { }

  canActivate(): Observable<boolean> | boolean {
    let command = new LoginUserQuery();
    command.email = localStorage.getItem('email');
    command.password = localStorage.getItem('password');
    this._client.login(command).subscribe(data => {
      if (data == false) {
        this._router.navigate(['/']);
      } else {
        return true;
      }
    });
    return this._client.login(command);
  }
}
