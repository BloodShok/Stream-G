import { NgModule } from '@angular/core';
import {MatMenuModule} from '@angular/material/menu';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
@NgModule({
  imports: [
    MatMenuModule,
    MatButtonModule,
    MatIconModule
     ],
  exports: [
    MatMenuModule,
    MatButtonModule,
    MatIconModule
     ]
})
export class AngularMatrialModule { }
