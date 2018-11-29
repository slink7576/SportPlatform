import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component(
  {
    selector: 'app-cabinet-user-component',
    templateUrl: './cabinet-user-component.html'
  })

export class CabinetUserComponent {
  username: string = 'sergiy';
  opened: boolean = true;

  constructor(private _router: Router) { }

  switch(): void {
    this.opened = !this.opened;
  }

 
}
