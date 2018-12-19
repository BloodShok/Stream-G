import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LayoutDefenitionComponent } from '../_layout/layout-defenition/layout-defenition.component';
import { NewsComponent } from '../pages/news/news.component';
import { MessagesComponent } from '../pages/messages/messages.component';

const routes: Routes = [
  {
     path: '',
      component: LayoutDefenitionComponent,
      children: [
        {
          path: 'news',
          component: NewsComponent
        },
        {
          path: 'messages',
          component: MessagesComponent
        },
        {
          path: '',
          component: NewsComponent
        }
      ]
     }
];

@NgModule({
  imports: [
    [RouterModule.forRoot(routes)]
  ],
  declarations: [],
  exports: [RouterModule]
})


export class AppRouteModule { }
