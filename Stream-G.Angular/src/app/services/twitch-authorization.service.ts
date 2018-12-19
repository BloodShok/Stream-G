import { Injectable, EventEmitter } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { UserAuthentificationData } from '../models/UserAuthentificationData';
import { Observable, Subscriber } from 'rxjs';
import { useAnimation } from '@angular/animations';
@Injectable({
  providedIn: 'root'
})
export class TwitchAuthorizationService {

  constructor() { }

  readonly value: string = 'https://id.twitch.tv/oauth2/authorize?response_type=code' +
  '&client_id=zelka51qk5amh7qm05a7vqtriwfv2k' +
  '&redirect_uri=http://localhost:4200/messages' +
  '&scope=viewing_activity_read&state=' + location.href;

  private _hubConnection = new  HubConnectionBuilder().withUrl('https://localhost:5001/authorizationnotify').build();
  private twitchWindow: Window;
  user: UserAuthentificationData;
  userEmitter = new EventEmitter<UserAuthentificationData>();
  sendAuthorizeRequest(): void {
    window.open(this.value);
  }

  startListeningTwitchAuthorize(): void {
    this._hubConnection.start();
    this._hubConnection.on('AuthenticationMessage',
     (user) => {this.userEmitter.emit(user); localStorage.setItem('twToken', user.accessToken); });
  }
  closeWindow(): void {
    this.twitchWindow.close();
  }

  saveUser(user: UserAuthentificationData): number {
    this.user = user;
    this.closeWindow();
    console.log(this.user);
    return 2;
  }

  getUser(): UserAuthentificationData {
    return this.user;
  }
}
