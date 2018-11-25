import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateUserCommand, Client } from '../../../sport-platform-api';
import { PasswordValidation } from '../../../../validators/password-validator';

/**
 * @title Stepper overview
 */
@Component({
  selector: 'app-landing-register-component',
  templateUrl: 'landing-register-component.html'
})
export class LandingRegisterComponent implements OnInit {
  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;

  constructor(private _formBuilder: FormBuilder,
    private _client: Client) { }

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      Name: ['', Validators.required],
    });
    this.secondFormGroup = this._formBuilder.group({
      Email: ['', Validators.email],
      Password: ['', Validators.required,],
      ConfirmPassword: ['', Validators.required],
    }, {
      validator: PasswordValidation.MatchPassword
      });
  }
  Register() {
    let command = new CreateUserCommand();
    command.email = this.secondFormGroup.controls['Email'].value;
    command.name = this.firstFormGroup.controls['Name'].value;
    command.password = this.secondFormGroup.controls['Password'].value;
    console.log(command);
    this._client.post(command).subscribe(c=> console.log(c));
  }
}
