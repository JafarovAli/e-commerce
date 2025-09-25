import { Injectable } from '@angular/core';
declare var alertify: any;

@Injectable({
  providedIn: 'root'
})
export class Alertify {
  message(message: string, option: Partial<AlertifyOptions>) {
    alertify.set('notifer', 'delay', option.delay);
    alertify.set('notifer', 'position', option.positon);
    const msj = alertify[option.messageType](message);
    if (option.dismissOthers)
      msj.dismissOthers();

  }
}

export class AlertifyOptions {
  messageType: MessageType = MessageType.Success;
  positon: Positon = Positon.BottomRight;
  delay: number = 3;
  dismissOthers: boolean = false;
}

export enum MessageType {
  Error = "error",
  Message = "message",
  Success = "success",
  Notify = "notify"
}

export enum Positon {
  TopCenter = "top-center",
  TopRight = "top-right",
  TopLeft = "top-left",
  BottomRight = "bottom-right",
  BottomCenter = "bottom-center",
  BottomLeft = "bottom-left"
}