import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Layout } from './layout';
import { ComponentsModule } from './components/components-module';



@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    ComponentsModule,
    Layout
  ],
  exports: [
    Layout
  ]
})
export class LayoutModule { }
