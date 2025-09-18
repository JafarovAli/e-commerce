import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Orders } from './orders';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    Orders,
    RouterModule.forChild([
      {path : "", component: Orders}
    ])
  ]
})
export class OrdersModule { }
