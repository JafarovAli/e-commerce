import { Component } from '@angular/core';
import { Header } from "./components/header/header";

@Component({
  selector: 'app-layout',
  templateUrl: './layout.html',
  styleUrl: './layout.scss',
  imports: [Header]
})
export class Layout {

}
