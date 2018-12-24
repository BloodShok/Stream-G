import { Component, OnInit } from '@angular/core';
import { TwitchAuthorizationService } from 'src/app/services/twitch-authorization.service';
import { UserAuthentificationData } from 'src/app/models/UserAuthentificationData';
import { DomSanitizer } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  readonly app_setings = 'app-setings';
  readonly user_setings = 'user-setings';

  currentWindowAppSetings: string;
  currentWindowUserSetings: string;
  trustedUrl: any;
  usl: string;
  constructor(private twAithorize: TwitchAuthorizationService, private sanitizer: DomSanitizer, private route: ActivatedRoute) { }
  user: UserAuthentificationData;
  ngOnInit() {
    // this.twAithorize.userEmitter.subscribe((x: UserAuthentificationData) => {
    //   this.user = x;
    //   this.trustedUrl = this.sanitizer.bypassSecurityTrustUrl(x.profileImageUrl);
    //   this.usl = `url(${this.user.profileImageUrl})`;
    //   console.log(this.usl);

      // this.route.data.subscribe(x => { console.log(x['code']); });
      // this.route.data.subscribe(x => { console.log('----------------' + x + '--------------------'); });
    //});
  }

  selectdAppSetings() {
    this.currentWindowAppSetings = this.app_setings;
  }

  selectdUserSetings(val: any) {
    this.currentWindowUserSetings = this.user_setings;
  }
  unSelectedUserSetings(e: any) {
    const classNames: any[] = e.path;
    if (!classNames.some(x => {
      if (x.className == null) {
         return false;
        } else {
        return x.className.includes('user-setings-container');
      }
    })) {
      this.currentWindowUserSetings = null;
    }
  }

  public get isSelectedAppSetings(): boolean {
    return this.currentWindowAppSetings === this.app_setings;
  }

  public get isSelectedUserSetings(): boolean {
    return this.currentWindowUserSetings === this.user_setings;
  }
}
