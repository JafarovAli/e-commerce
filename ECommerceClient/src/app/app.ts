import { Component, signal } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { AdminModule } from "./admin/admin-module";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, AdminModule, RouterLink],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  protected readonly title = signal('ECommerceClient');
}
