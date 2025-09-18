import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Customers } from './customers';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    Customers,
    RouterModule.forChild([
      {path : "", component: Customers}
    ])
  ]
})
export class CustomersModule { }
