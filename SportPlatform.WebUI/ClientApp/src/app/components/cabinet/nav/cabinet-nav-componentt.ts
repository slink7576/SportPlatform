import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component(
  {
    selector: 'app-cabinet-nav-component',
    templateUrl: './cabinet-nav-component.html'
  })

export class CabinetNavComponent {

  constructor(private _router: Router) { }

  Logout(): void {
    localStorage.removeItem('email');
    localStorage.removeItem('password');
    this._router.navigate(['/']);
  }
}
