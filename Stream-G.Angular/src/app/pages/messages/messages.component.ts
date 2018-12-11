import { Component, OnInit } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-messages',
  templateUrl: './messages.component.html',
  styleUrls: ['./messages.component.scss']
})
export class MessagesComponent implements OnInit {
  value = 'https://id.twitch.tv/oauth2/authorize?response_type=code' +
          '&client_id=zelka51qk5amh7qm05a7vqtriwfv2k' +
          '&redirect_uri=https://localhost:5001/api/TwitchAuthorization/authorize' +
          '&scope=viewing_activity_read&state=' + location.href;

  twitchWindow: Window;
  private _hubConnection = new  HubConnectionBuilder().withUrl('https://localhost:5001/authorizationnotify').build();
  constructor(private http: HttpClient) { }
  user_token: string;
  ngOnInit() {

    this._hubConnection.start();
    this._hubConnection.on('AuthenticationMessage',(code) => console.log(code));
    
  }

   authorizeTwitch() {
    this.twitchWindow = window.open(this.value, '_blank', 'width=500, height=400');
   }


   

   sendToServerMessage(token: string): Observable<any> {
     console.log(token);
     const tokenHeader = new HttpHeaders();
     return this.http.post<any>('api/TwitchUser/message', {data: token}, {headers: tokenHeader});
   }
}

class Tok {
  /**
   *
   */
  constructor(token: string) {
    this.token = token;
  }
 token: string;
}