import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-childeren',
  templateUrl: './childeren.component.html',
  styleUrls: ['./childeren.component.css']
})
export class ChilderenComponent {
  public childeren: Childeren[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Childeren[]>(baseUrl + 'api/childeren').subscribe(result => {
      this.childeren = result;
      console.log(this.childeren);
    }, error => console.error(error));
  }
}

interface Childeren {
  id: number;
  name: string;
  createdTimestamp: string;
  updateTimestamp: string;
  active: number;
}
