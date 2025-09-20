import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Layout } from './layout';
import { ComponentsModule } from './components/components-module';
import { RouterModule } from '@angular/router';
import { MatSidenavModule } from '@angular/material/sidenav';


@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    ComponentsModule,
    Layout,
    RouterModule,
    MatSidenavModule
  ],
  exports: [
    Layout
  ]
})
export class LayoutModule { }
