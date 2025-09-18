import { Component } from '@angular/core';
import { Header } from "./components/header/header";
import { Footer } from "./components/footer/footer";
import { Sidebar } from "./components/sidebar/sidebar";
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.html',
  styleUrl: './layout.scss',
  imports: [Header, Footer, Sidebar, RouterOutlet]
})
export class Layout {

}
