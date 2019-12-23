import { Component } from '@angular/core';
import { Validators, FormBuilder, FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-create-nutrition',
  templateUrl: './create-nutrition.component.html',
  styleUrls: ['./create-nutrition.component.css']
})
export class CreateNutritionComponent {
  form: FormGroup;

  nutritionValue = new FormControl("", Validators.required);

  constructor(fb: FormBuilder) {
    this.form = fb.group({
      "nutritionValue": this.nutritionValue,
    });
  }

  onSubmit() {
    let nutritionValue = this.form.value.nutritionValue;
    console.log(nutritionValue);


  }
}
