import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})

export class CustomToastr {
  constructor(private toastr: ToastrService) { }
  message(message: string, title: string, option: Partial<ToastrPositons>) {
    this.toastr[option.messageType](message, title, {
      positionClass: option.positon
    })
  }
}

export class ToastrPositons {
  messageType: ToastrMessageType;
  positon: ToastrPositon;
}

export enum ToastrMessageType {
  Error = "error",
  Info = "info",
  Success = "success",
  Warning = "warning"
}

export enum ToastrPositon {
  TopRight = "toast-top-right",
  BottomRight = "toast-bottom-right",
  BottomLeft = "toast-bottom-left",
  TopLeft = "toast-top-left",
  TopFullWidth = "toast-top-full-width",
  BottomFullWidth = "toast-bottom-full-width",
  TopCenter = "toast-top-center",
  BottomCenter = "toast-bottom-center"
}
