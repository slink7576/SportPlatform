import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UserClient, UsersListViewModel, UserDTO } from '../sport-platform-api';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public users: UserDTO[];

  constructor(client: UserClient) {
    client.get().subscribe(result => {
      console.log(result);
      this.users = result.users;
    });
  }
}

