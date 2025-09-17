import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Header } from './header/header';
import { Footer } from './footer/footer';
import { Sidebar } from './sidebar/sidebar';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
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
