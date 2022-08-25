import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { on } from 'events';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'client';
  constructor(private http: HttpClient ){}
  users:any;
  ngOnInit() {
  this.getUsers();
  }
  getUsers(){
    this.http.get('https://localhost:5001/api/users').subscribe({
      next:response=>this.users=response,
      error: error=> console.log(error)
    });
  }
}