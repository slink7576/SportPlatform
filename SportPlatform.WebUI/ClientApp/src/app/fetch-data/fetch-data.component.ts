import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Client, UsersListViewModel, UserDTO } from '../sport-platform-api';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public users: UserDTO[];

  constructor(client: Client) {
    client.get().subscribe(result => {
      this.users = result.users;
    }, error => console.log(error));
  }
}

