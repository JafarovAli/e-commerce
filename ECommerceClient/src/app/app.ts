import { Component, signal } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { AdminModule } from "./admin/admin-module";
import { ToastrService } from 'ngx-toastr';
import { CustomToastr, ToastrMessageType, ToastrPositon } from './services/ui/custom-toastr';
import { NgxSpinnerComponent } from "ngx-spinner";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, AdminModule, RouterLink, NgxSpinnerComponent],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  protected readonly title = signal('ECommerceClient');

  constructor(toastr: CustomToastr) {
    toastr.message('Hello world!', 'Toastr fun!', {
      messageType: ToastrMessageType.Info,
      positon: ToastrPositon.BottomRight
    });
  }
}