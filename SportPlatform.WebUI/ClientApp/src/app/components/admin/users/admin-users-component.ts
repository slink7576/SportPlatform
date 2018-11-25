import { Component, ViewChild, OnInit } from '@angular/core';
import { MatPaginator, MatTableDataSource } from '@angular/material';
import { UserDTO, IUserDTO, IUsersListViewModel } from '../../../sport-platform-api';

@Component({
  selector: 'admin-users-component',
  templateUrl: 'admin-users-component.html',
  styleUrls: ['../admin.css']
})

export class AdminUsersComponent implements OnInit {
  opened: boolean = true;
  displayedColumns: string[] = ['id', 'email', 'name'];
  dataSource = new MatTableDataSource<IUserDTO>(UsersMock);

  @ViewChild(MatPaginator) paginator: MatPaginator;

  ngOnInit() {
    this.dataSource.paginator = this.paginator;

  }
  switch(): void {
    this.opened = !this.opened;
  }
}
const UsersMock: IUserDTO[] = [
  { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
  { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
  { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
  { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
  { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
  { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
  { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' },
  { userId: 1, email: 'slnkonline2@gmail.com', name: 'Sergiy' }
];

