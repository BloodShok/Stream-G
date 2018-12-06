import { Component, OnInit } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { HttpClient } from '@angular/common/http';
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
  user_token: string = "asdasd";
  ngOnInit() {
    this._hubConnection.start();

    this._hubConnection.on(
      'AuthentificationMessage',
     (token: string, state: string) => { console.log(token); console.log(state); this.user_token = token; this.twitchWindow.close(); });
  }

   authorizeTwitch() {
    this.twitchWindow = window.open(this.value, '_blank', 'width=500, height=400');
   }


   getUserTwitch() {
     this.sendToServerMessage(this.user_token).subscribe(x => {
        console.log(x);
     });
   }

   sendToServerMessage(token: string): Observable<any> {
     console.log(token);
     return this.http.post<any>('api/TwitchUser/message', {data: token});
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