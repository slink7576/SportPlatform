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
  roles: string[] = [
    'Клиент',
    'Тренер'
  ];

  constructor(private _formBuilder: FormBuilder,
    private _client: Client) { }

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      Name: ['', Validators.compose([Validators.required, Validators.minLength(6)])],
    });
    this.secondFormGroup = this._formBuilder.group({
      Email: ['', Validators.compose([Validators.email, Validators.minLength(4)])],
      Password: ['', Validators.compose([Validators.required, Validators.minLength(6)])],
      ConfirmPassword: ['', Validators.compose([Validators.required, Validators.minLength(6)])],
      UserRole: ['', Validators.required]
    }, {
      validator: PasswordValidation.MatchPassword
      });
  }
  getErrorEmailMessage() {
    return this.secondFormGroup.controls['Email'].hasError('required') ? 'Введите значение' :
      this.secondFormGroup.controls['Email'].hasError('email') ? 'Неправильная почта' :
        '';
  }
  getErrorNameMessage() {
    return this.firstFormGroup.controls['Name'].hasError('required') ? 'Введите значение' :
      this.firstFormGroup.controls['Name'].hasError('minlength') ? 'Минимальная длина 6 символов' : ''
  }
  getErrorPasswordMessage() {
    return this.secondFormGroup.controls['Password'].hasError('required') ? 'Введите значение' :
      this.secondFormGroup.controls['Password'].hasError('minlength') ? 'Минимальная длина 6 символов' : ''
  }
  getErrorPasswordSubmitMessage() {
    return this.secondFormGroup.controls['ConfirmPassword'].hasError('required') ? 'Введите значение' :
      this.secondFormGroup.controls['ConfirmPassword'].hasError('minlength') ? 'Минимальная длина 6 символов' :
        this.secondFormGroup.controls['ConfirmPassword'].hasError('MatchPassword') ? 'Пароли должны совпадать' : ''
  }
  
  Register() {
    let command = new CreateUserCommand();
    command.email = this.secondFormGroup.controls['Email'].value;
    command.name = this.firstFormGroup.controls['Name'].value;
    command.password = this.secondFormGroup.controls['Password'].value;
    this._client.registerUser(command).subscribe(c => console.log(c));
  }
}
