import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
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


@NgModule({
  declarations: [
    AppComponent,
    LandingMainComponent,
    AdminNavComponent,
  LandingRegisterComponent,
    AdminUsersComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: LandingMainComponent, pathMatch: 'full' },
      { path: 'admin/users', component: AdminUsersComponent },
    ]),
    BrowserAnimationsModule,
    CustomMaterialModule
  ],
  providers: [Client],
  bootstrap: [AppComponent]
})
export class AppModule { }
