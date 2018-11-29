import { CanActivate } from "@angular/router";
import { Observable } from "rxjs";

export class LoginAdminService implements CanActivate {
  canActivate(): Observable<boolean> | boolean {
    return true;
  }
}
