import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Baskets } from './baskets';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    Baskets,
    RouterModule.forChild([
      {path : "", component: Baskets}
    ])
  ]
})
export class BasketsModule { }
