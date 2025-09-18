import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Products } from './products';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    Products,
    RouterModule.forChild([
      { path: "", component: Products }
    ])
  ]
})
export class ProductsModule { }
