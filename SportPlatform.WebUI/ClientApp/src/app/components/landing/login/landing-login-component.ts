import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Client, LoginUserQuery } from '../../../sport-platform-api';
import { Router } from '@angular/router';

@Component(
  {
    selector: 'app-landing-login-component',
    templateUrl: './landing-login-component.html'
  })

export class LandingLoginComponent implements OnInit {
  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;
  NotForgetPassword: boolean = true;
  Restored: boolean = false;
  isLoading: boolean = false;
  LoginError: boolean = false;

  constructor(private _formBuilder: FormBuilder,
    private _router: Router,
    private _client: Client) { }

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      Email: ['', Validators.compose([Validators.required, Validators.email])],
      Password: ['', Validators.required],
    });
    this.secondFormGroup = this._formBuilder.group({
      Email: ['', Validators.compose([Validators.required, Validators.email])],
    });
  }

  Login() {
    let command = new LoginUserQuery();
    command.email = this.firstFormGroup.controls['Email'].value;
    command.password = this.firstFormGroup.controls['Password'].value;
    this.isLoading = true;
    this._client.login(command).subscribe(data => {
      if (data) {
        localStorage.setItem('email', command.email);
        localStorage.setItem('password', command.password);
        this._router.navigate(['user/dashboard']);
      }
      else {
        this.isLoading = false;
        this.LoginError = true;
      }
    });
    
  }

  Restore() {
    if (!this.Restored && this.secondFormGroup.valid) {
      // TODO: Restore password
      this.Restored = true;
    }
  }

  ForgetPassword() {
    this.NotForgetPassword = !this.NotForgetPassword;
  }
}
