import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component(
  {
    selector: 'app-landing-main-component',
    templateUrl: './landing-main-component.html'
  })

export class LandingMainComponent implements OnInit{

  constructor(private _router: Router) { }

  ngOnInit() {
    if (localStorage.getItem('email') != null) {
      this._router.navigate(['user/dashboard']);
    } 
  }
}
