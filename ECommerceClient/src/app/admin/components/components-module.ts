import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomersModule } from './customers/customers-module';
import { OrdersModule } from './orders/orders-module';
import { Dashboard } from './dashboard/dashboard';
import { ProductsModule } from './products/products-module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    CustomersModule,
    OrdersModule,
    ProductsModule,
    Dashboard
  ]
})
export class ComponentsModule { }
