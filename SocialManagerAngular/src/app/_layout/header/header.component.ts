import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  readonly app_setings = 'app-setings';
  readonly user_setings = 'user-setings';

  currentWindow: string;
  constructor() { }

  ngOnInit() {
  }

  selectdAppSetings() {
    this.currentWindow = this.app_setings;
    console.log(this.currentWindow);
  }

  selectdUserSetings(val: any) {
    this.currentWindow = this.user_setings;
    console.log(val.class);
  }
  unSelectedUserSetings(e: any) {
    const classNames: any[] = e.path;
    if (!classNames.some(x => x.className === 'container__item')) {
      this.currentWindow = null;
    }
  }
  public get isSelectedAppSetings(): boolean {
    return this.currentWindow === this.app_setings;
  }

  public get isSelectedUserSetings(): boolean {
    return this.currentWindow === this.user_setings;
  }
}
