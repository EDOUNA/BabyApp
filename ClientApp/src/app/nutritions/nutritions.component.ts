import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-nutritions',
  templateUrl: './nutritions.component.html',
  styleUrls: ['./nutritions.component.css']
})
export class NutritionsComponent {
  public nutritions: Nutritions[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Nutritions[]>(baseUrl + 'api/nutritions/byChildId/1').subscribe(result => {
      this.nutritions = result;
      console.log(this.nutritions);
    }, error => console.error(error));
  }
}

interface Nutritions {
  id: number;
  createdTimestamp: string;
  updatedTimestamp: string;
  nutritionValue: number;
  child: {
    [key: string]: Child
  };
}

interface Child {
  id: number;
  name: string;
  createdTimestamp: string;
  updatedTimestamp: string;
  active: number;
}
