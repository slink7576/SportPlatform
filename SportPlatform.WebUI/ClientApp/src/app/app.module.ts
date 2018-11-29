import { BrowserModule } from '@angular/platform-browser';
import { NgModule, TemplateRef } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { Client } from './sport-platform-api';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CustomMaterialModule } from './material-module';
import { LandingMainComponent } from './components/landing/main/landing-main-component';
import { AdminNavComponent } from './components/admin/nav/admin-nav-component';
import { AdminUsersComponent } from './components/admin/users/admin-users-component';
import { LandingRegisterComponent } from './components/landing/register/landing-register-component';
import { LandingLoginComponent } from './components/landing/login/landing-login-component';
import { CabinetUserComponent } from './components/cabinet/user/cabinet-user-component';
import { LoginUserService } from './services/login-user-service';
import { LoginAdminService } from './services/login-admin-service';
import { CabinetNavComponent } from './components/cabinet/nav/cabinet-nav-componentt';
import { InfoBlockComponent } from './components/shared/infoblock/infoblock-component';
import { MatStepLabel } from '@angular/material';


@NgModule({
  declarations: [
    AppComponent,
    LandingMainComponent,
    AdminNavComponent,
    LandingRegisterComponent,
    AdminUsersComponent,
    LandingLoginComponent,
    CabinetUserComponent,
    CabinetNavComponent,
InfoBlockComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: LandingMainComponent, pathMatch: 'full' },
      { path: 'user/dashboard', component: CabinetUserComponent, canActivate: [LoginUserService] },
      { path: 'admin/users', component: AdminUsersComponent, canActivate: [LoginAdminService] },
    ]),
    BrowserAnimationsModule,
    CustomMaterialModule
  ],
  providers: [Client, LoginUserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
