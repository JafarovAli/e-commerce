import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Header } from './header/header';
import { Footer } from './footer/footer';
import { Sidebar } from './sidebar/sidebar';
import { MatListModule } from '@angular/material/list';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MatListModule,
    Header,
    Footer,
    Sidebar
  ],
  exports: [
    Header,
    Footer,
    Sidebar
  ]
})
export class ComponentsModule { }
