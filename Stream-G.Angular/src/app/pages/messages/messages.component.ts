import { Component, OnInit } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { TwitchAuthorizationService } from 'src/app/services/twitch-authorization.service';
import { UserAuthentificationData } from 'src/app/models/UserAuthentificationData';


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



  constructor(private http: HttpClient, private twAithorize: TwitchAuthorizationService) { }
  user_token: string;
  user: UserAuthentificationData;

  ngOnInit() {
    this.twAithorize.startListeningTwitchAuthorize();
    this.user = this.twAithorize.getUser();

    this.twAithorize.userEmitter.subscribe((x: UserAuthentificationData) => {
      this.user = x; this.twAithorize.closeWindow();
    });
  }

   authorizeTwitch() {
      this.twAithorize.sendAuthorizeRequest();

     }

   sendToServerMessage(token: string): Observable<any> {
     console.log(token);
     const tokenHeader = new HttpHeaders();
     return this.http.post<any>('api/TwitchUser/message', {data: token}, {headers: tokenHeader});
   }
   
}