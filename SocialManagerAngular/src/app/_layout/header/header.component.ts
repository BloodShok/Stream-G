import { Component, OnInit } from '@angular/core';

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
  constructor() { }

  ngOnInit() {
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
