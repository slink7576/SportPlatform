import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component(
  {
    selector: 'app-cabinet-profile-component',
    templateUrl: './cabinet-profile-component.html'
  })

export class CabinetProfileComponent {
  opened: boolean = true;

  constructor(private _router: Router) { }

  switch(): void {
    this.opened = !this.opened;
  }

 
}
